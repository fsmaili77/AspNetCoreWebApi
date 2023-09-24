# ASP.NET Core WEB API
ASP.NET Core Web API is a framework for building web services and RESTful APIs using the ASP.NET Core platform. It allows you to create HTTP-based services that can be consumed by a wide range of clients, such as web applications, mobile apps, desktop applications, and other services. Here are some key concepts and components associated with ASP.NET Core Web API:
1. **Routing:** ASP.NET Core Web API uses routing to map incoming HTTP requests to controller actions. The routing system helps determine which controller and action should handle a specific request based on the URL and HTTP method (GET, POST, PUT, DELETE, etc.).
2. **Controllers:** Controllers in ASP.NET Core Web API are classes that define the endpoints (actions) for your API. Each controller corresponds to a specific resource or logical grouping of related endpoints. These controllers contain action methods that handle HTTP requests and return HTTP responses.
3. **Actions:** Actions are methods within a controller that respond to HTTP requests. They are responsible for processing incoming requests, performing business logic, and returning HTTP responses. Actions are typically annotated with attributes like `[HttpGet]`, `[HttpPost]`, etc., to specify the HTTP methods they can handle.
4. **Model Binding:** Model binding is the process of mapping incoming HTTP request data (e.g., query parameters, route data, request body) to parameters of an action method. ASP.NET Core provides automatic model binding, which simplifies the extraction of data from requests.
5. **Content Negotiation:** ASP.NET Core Web API supports content negotiation, allowing clients to request data in different formats (JSON, XML, etc.) based on their preferences. The API can automatically serialize and format data in the requested format.
6. **Middleware:** Middleware components in ASP.NET Core Web API handle various aspects of request processing, such as authentication, routing, error handling, and CORS (Cross-Origin Resource Sharing). Middleware can be added to the pipeline to customize the behavior of the API.
7. **Dependency Injection:** ASP.NET Core provides built-in support for dependency injection, allowing you to inject services and components into your controllers and other classes. This promotes modularity, testability, and separation of concerns in your API.
8. **Attribute Routing:** ASP.NET Core Web API allows you to define routes using attributes like `[Route]` directly on controller classes and action methods. This enables a more fine-grained control over the API's URL structure.
9. **Request and Response Objects:** ASP.NET Core provides objects like `HttpRequest` and `HttpResponse` that allow you to access and manipulate the details of incoming requests and outgoing responses.
10. **Data Validation and Model Validation:** You can use data annotations, data validation attributes, and model validation to ensure that the incoming data is valid and meets your requirements. This helps improve the security and integrity of your API.
11. **Authorization and Authentication:** ASP.NET Core provides a flexible system for implementing authentication and authorization, allowing you to control access to API endpoints based on user roles, claims, or policies.
12. **Serialization and Deserialization:** ASP.NET Core supports automatic serialization of objects to JSON or other formats and deserialization of incoming data from HTTP requests. This is essential for processing data in a format that clients can understand.

ASP.NET Core Web API is a versatile framework for building web services, and it's widely used for creating APIs that serve a variety of applications and platforms. It is a part of the broader ASP.NET Core ecosystem, which provides tools and libraries for building modern web applications and services.

## The flow for creation of ASP.NET Core Web API applications:
1.	**Install essential packages:** 
     -	Microsoft.EntityFrameworkCore.SqlServer
     -	Microsoft.EntityFrameworkCore.Tools
2.	**Create Model class** (ex: Cities)
3.	**DbContext** with essential connection strings + **DbSet** and override OnModelCreating method for data seed
4.	**ConnectionStrings** (For database connection; ex: in the **appsetings.json** file)
5.	**Add DbContext** service to the **Program.cs** file.
6.	**Create Migrations** (with NuGet package manager console PM> Add-Migration Initial)
7.	**Update Database** (PM> Update-Database)
8.	**Add Controllers**


