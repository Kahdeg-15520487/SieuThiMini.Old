using System;
using System.IO;
using System.Data.OleDb;

using Microsoft.Extensions.Configuration;
using System.Data;
using System.Text;
using CSVSchema;
using Newtonsoft.Json;
using System.Reflection;

namespace MdbToSqLiteConverter
{
    class DanhMuc
    {
        public string MADM { get; set; }
        public string TENDM { get; set; }
    }

    class SanPham
    {
        public string MASP { get; set; }
        public string TENSP { get; set; }
        public int SOLUONG { get; set; }
        public int DONGIA { get; set; }
        public string XUATXU { get; set; }
        public string MADM { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var configBuilder = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            //var config = configBuilder.Build();

            //Console.WriteLine(config["ConnectionStrings:DefaultConnection"]);
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LegacyDatabase\\Bai 1 - dbSanPham.mdb");
            if (args.Length == 1)
            {
                path = args[0];
            }

            if (!File.Exists(path))
            {
                Console.WriteLine("{0} does not exist", path);
            }

            var danhmucData = ReadData("Provider=Microsoft.JET.OLEDB.4.0;" + $"data source={path}", "select * from tbDANHMUC");
            var sanphamData = ReadData("Provider=Microsoft.JET.OLEDB.4.0;" + $"data source={path}", "select * from tbSANPHAM");

            var danhmucs = CSV.Deserialize<DanhMuc>(danhmucData);
            var sanphams = CSV.Deserialize<SanPham>(sanphamData);

            var danhmucSerialized = JsonConvert.SerializeObject(danhmucs)
                .Replace("MADM", "id")
                .Replace("TENDM", "tenDanhMuc")
                .Replace("\"", "\\\"")
                ;

            var sanphamSerialized = JsonConvert.SerializeObject(sanphams)
                .Replace("MASP", "id")
                .Replace("TENSP", "tenSanPham")
                .Replace("SOLUONG", "soLuong")
                .Replace("DONGIA", "donGia")
                .Replace("XUATXU", "xuatXu")
                .Replace("MADM", "danhMucId")
                .Replace("\"", "\\\"")
                ;

            File.WriteAllText("danhmuc.json", danhmucSerialized);
            File.WriteAllText("sanpham.json", sanphamSerialized);

            Console.ReadLine();
        }

        private static void ReadData()
        {

        }

        private static string ReadData(string connectionString, string queryString)
        {
            StringBuilder sb = new StringBuilder();
            using (StringWriter sw = new StringWriter(sb))
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbCommand command = new OleDbCommand(queryString, connection);

                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    sw.WriteLine("|");

                    var schema = reader.GetSchemaTable();
                    var nameCol = schema.Columns["ColumnName"];
                    foreach (DataRow row in schema.Rows)
                    {
                        Console.Write($"{row[nameCol]}\t");
                        sw.Write($"{row[nameCol]}|");
                    }
                    Console.WriteLine();
                    sw.WriteLine();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write($"{reader[i].ToString()}\t");
                            sw.Write($"{reader[i].ToString()}|");
                        }
                        Console.WriteLine();
                        sw.WriteLine();
                    }
                    reader.Close();
                }
            }
            return sb.ToString();
        }
    }
}
