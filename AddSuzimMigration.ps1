$MigrationName = Read-Host "Please, enter Migration name"

dotnet ef migrations add $MigrationName -c SizumContextPostgres -o .\Migrations\Suzim -s src/Store.Postgres  -v -- --CreateMigrationOnly 

Read-Host -Prompt "Press Enter to exit"