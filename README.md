# Clean Architecture with ASP.NET

This repository contains an example of a project using Clean Architecture in ASP.NET. It demonstrates the use of the CQRS and Mediator patterns, as well as the Circuit Breaker and Retry patterns using the Polly package.

## Getting Started

To get started with this project:

1. Clone this repository
2. Open the solution in Visual Studio or your preferred IDE
3. Restore the NuGet packages
4. Run the migration commands for update database as following Project Setup section

## Project Setup

First, create a database called "Clean".

### With .NET CLI

1. Open a terminal or command prompt.
2. Navigate to the root directory of your solution.
3. Delete the existing migration folder and all its contents. 

Note that The migration folder already exists and if you want to delete it and create new migration files, you can follow these step otherwise you can skip this one:
Run the below migration commands mentioned earlier to create a new migration:

```
dotnet ef migrations add initial -s CleanArchitecture.Presentation/CleanArchitecture.Presentation.csproj -p CleanArchitecture.Infrastructure.Persistence/CleanArchitecture.Infrastructure.Persistence.csproj
```

This command will create a new migration with the name "initial".

After the migration is added, run the following command to apply the migration and create the table:
```
dotnet ef database update -s CleanArchitecture.Presentation/CleanArchitecture.Presentation.csproj -p CleanArchitecture.Infrastructure.Persistence/CleanArchitecture.Infrastructure.Persistence.csproj
```

This command updates the database based on the latest migration, creating the necessary tables.

These CLI commands use the dotnet ef tool to interact with Entity Framework Core and perform migrations and database operations.

### With Package Manager Console (PMC)

Alternatively, if you prefer using Package Manager Console (PMC) commands in Visual Studio, you can use the following commands:

1. Open Visual Studio and the solution containing the "Clean" project.
2. Open the Package Manager Console by going to Tools -> NuGet Package Manager -> Package Manager Console.
3. In the Package Manager Console, select the startup project as "CleanArchitecture.Presentation" from the dropdown.
4. Run the following command to add a migration:
Note that The migration folder already exists and if you want to delete it and create new migration files, you can follow these step otherwise you can skip this one:

```
Add-Migration initial -Project CleanArchitecture.Infrastructure.Persistence
```

5. After the migration is added, run the following command to update the database:

```
Update-Database -Project CleanArchitecture.Infrastructure.Persistence
```

These PMC commands provide a similar workflow to the CLI commands but are executed within Visual Studio.
Please note that you may need to adjust the project names and paths based on your specific project structure.

## Project Structure

The project is structured following the principles of Clean Architecture, with separate projects for the Domain, Application, Infrastructure, and Presentation layers.

### CQRS and Mediator Pattern

The Command Query Responsibility Segregation (CQRS) pattern is used to separate the read and write operations of the application. The Mediator pattern is implemented using the MediatR library, allowing loose coupling between objects by having these objects communicate indirectly.

### Circuit Breaker and Retry Patterns with Polly

The Polly package is used to implement resilience and transient-fault-handling capabilities. The Circuit Breaker pattern prevents an application from performing operations that are likely to fail. The Retry pattern enables an application to retry an operation in the expectation that it'll succeed.

## Learn More

If you want to learn more about how this project is built and understand the concepts in depth, you can follow this YouTube playlist [https://www.youtube.com/playlist?list=PLN5rV4x2x5XcRubBzzDQ_WApzFBPAgnoh]. It contains a full video course explaining all the details of this project.

Happy coding!