# HeroAPI

HeroAPI is an api made in dotnet core 2.1 that implements a crud in its endpoint.

## Getting Started 
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- .NET Core 2.2
- MariaDB 10.1.38

### Installing

Download the project using git with the command below.

``
git clone https://github.com/RodrigoSouzaCamelo/HeroAPI.git
``

#### Create a migration
When the download is complete, enter the HeroAPI/ folder and run the following command to add an initial migration.

``
dotnet ef Data/Migrations add InitialCreate
``

Three files are added to your project under the Migrations directory:

- XXXXXXXXXXXXXX_InitialCreate.cs--The main migrations file. Contains the operations necessary to apply the migration (in Up()) and to revert it (in Down()).

- XXXXXXXXXXXXXX_InitialCreate.Designer.cs--The migrations metadata file. Contains information used by EF.

- MyContextModelSnapshot.cs--A snapshot of your current model. Used to determine what changed when adding the next migration.

#### Update the database
Next, apply the migration to the database to create the schema.

``
dotnet ef database update
``

#### Configure the connection to the database

In the `Startup.ConfigureService()` method, add your connection to the database.

```
services.AddDbContextPool<HeroDbContext>( 
    options => options.UseMySql("Server=localhost;Database=HeroAPI;User=admin;Password=admin;", // replace with your Connection String
        mySqlOptions =>
        {
            mySqlOptions.ServerVersion(new Version(10, 1, 38), ServerType.MySql); // replace with your Server Version and Type
        }
));
```

### Running
To run the project run the command below.

``
dotnet run
``

## Author

- Rodrigo Souza Camelo
