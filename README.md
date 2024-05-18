# Buber Dinner

Buber Dinner is a sample application that allows users to turn their homes into restaurants, similar to Airbnb's model for hotels. This project is built using C# and follows principles of Domain-Driven Design (DDD) and Clean Architecture.

## Table of Contents
- [Features](#features)
- [Technologies](#technologies)
- [Architecture](#architecture)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

## Features
- Turn your home into a restaurant
- Manage reservations and orders
- User authentication with JWT
- Follows Clean Architecture principles
- Implements DDD concepts

## Technologies
- .NET 7
- Entity Framework Core
- Mediator pattern
- FluentValidation
- FunctionalDDD
- Mapster
- JWT for authentication

## Architecture
The application is structured based on Clean Architecture principles, which include the following layers:

1. **Domain Layer**: Contains business logic, aggregate roots, entities, and value objects.
2. **Application Layer**: Includes business logic and serves as a bridge between the domain and infrastructure layers.
3. **Infrastructure Layer**: Implements interfaces defined in the application layer and handles external communications.
4. **Presentation Layer**: Manages HTTP requests and translates them into commands and queries for the application layer.

### Domain Layer
- Business logic
- Aggregate roots
- Entities
- Value objects

### Application Layer
- Business logic
- CQRS (Command Query Responsibility Segregation)
- Use cases

### Infrastructure Layer
- Data access
- External service integrations

### Presentation Layer
- API controllers
- Request handling
