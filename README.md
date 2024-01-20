# Summary

When a null value is given to Results.Json, it no longer outputs "null" in the response body, instead the response body is empty

# Repro steps

1. Run the ResultJsonRepro project as is
2. Observe that the browser will show

```json
null
```
3. Edit [ResultJsonRepro.csproj](.\ResultJsonRepro\ResultJsonRepro.csproj) by replacing the TargetFramework "net6.0" with "net8.0" (or "net7.0")
4. Run the ResultJsonRepro project again
5. Observe no content in the browser

> NOTE: for completeness I've also added an endpoint for "Mvc" ("/mvc") and "WebApi" ("/api") using the Json method on the Controller base class. Both of these remained to produce the expected output.

# Use case

Migrating from LTS .NET 6 to LTS .NET 8 broke several api contracts due to the lack of a response body, which when put live as if will break clients not in our control (it will fail to deserialize JSON)
