dotnet clean
dotnet restore
dotnet build --configuration Release
dotnet publish -c Release 