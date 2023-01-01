
if you have new field for the data contracts use this steps.(Open Package Manager Console and choose IsraaApp.Data)

PM> enable-migrations -Force
PM> add-migration #YourMigrationName
PM> update-database

 