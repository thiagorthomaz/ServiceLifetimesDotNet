# This is a simple study about .NET service lifetimes.

When working with DI, understanding the lifecycle of service is essential to optimize resource usage, avoid memory leaks and unexpected behavior.

## Services can be registered with one of the following lifetimes:

### 1 - Transient:
A new instance is created every time it’s requested. Best for stateless services.

### 2 - Scoped:
A new instance is created once per request in a web app. Perfect for handling database connections.

### 3 - Singleton:
The service is created once per application lifetime and shared across all requests. Perfect for longings.


More details at: [https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection#service-lifetimes](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection#service-lifetimes)
