dotnet restore
dotnet build
cd SieuThiMini.DAL
dotnet ef database drop
dotnet ef database update
