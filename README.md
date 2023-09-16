# Clean Architecture with ASP.NET

This repository contains an example of a project using Clean Architecture in ASP.NET. It demonstrates the use of the CQRS and Mediator patterns, as well as the Circuit Breaker and Retry patterns using the Polly package.

## Project Structure

The project is structured following the principles of Clean Architecture, with separate projects for the Domain, Application, Infrastructure, and Presentation layers.

### CQRS and Mediator Pattern

The Command Query Responsibility Segregation (CQRS) pattern is used to separate the read and write operations of the application. The Mediator pattern is implemented using the MediatR library, allowing loose coupling between objects by having these objects communicate indirectly.

### Circuit Breaker and Retry Patterns with Polly

The Polly package is used to implement resilience and transient-fault-handling capabilities. The Circuit Breaker pattern prevents an application from performing operations that are likely to fail. The Retry pattern enables an application to retry an operation in the expectation that it'll succeed.

## Getting Started

To get started with this project:

1. Clone this repository
2. Open the solution in Visual Studio
3. Restore the NuGet packages
4. Build and run the solution

## Learn More

If you want to learn more about how this project is built and understand the concepts in depth, you can follow this YouTube playlist [https://www.youtube.com/playlist?list=PLN5rV4x2x5XcRubBzzDQ_WApzFBPAgnoh]. It contains a full video course explaining all the details of this project.

Happy coding!