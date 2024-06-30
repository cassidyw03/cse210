# Modern Example

This example requires the 3rd party package dotnet add package [Json.Net](https://www.newtonsoft.com/json) The built in JSON serializer to C# would also work but you would have to lookup which `attributes` to use and how to register a `converter` for your class(es).

**DO NOT USE** the download option on the website. It is easier to install the package with the following command: `dotnet add package Newtonsoft.Json`

Remember that this command must be run in the root of your program, the directory where the `[project name].csproj` file exists.