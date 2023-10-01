$MigrationName = Read-Host "Please, enter Migration name"

dotnet ef migrations add $MigrationName -c IdentityContextPostgres -o .\Migrations\Identity -s src/Store.Postgres -v -- --CreateMigrationOnly

Read-Host -Prompt "Press Enter to exit"