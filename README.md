# dotnet-unit-tests

- Separated projects for the application and the tests


# Setup


- dotnet add package Microsoft.NET.Test.Sdk 
- dotnet add package xunit 
- dotnet add package xunit.runner.visualstudio 
- dotnet add package coverlet.collector 
- dotnet add package Moq

Add a reference of the application to the test project

```
<ItemGroup>
<ProjectReference Include="..\TestingBasics\TestingBasics.csproj" />
 </ItemGroup>
```

## Notes

To open the csproj file:

1. Right click over the project name and click on **Unload Project**.
1. When youre done, right click over the project name and click on **Reload Project**


### Common errors

**Cannot Start Program because it has more than one entrypoint**

1. open .csproj file
1. Add ```<GenerateProgramFile>false</GenerateProgramFile>`` to the ``<PropertyGroup>`` section


Program does not contain a static 'Main' method suitable for an entry point

1. open .csproj file
1. Add ```<GenerateProgramFile>false</GenerateProgramFile>`` to the ``<PropertyGroup>`` section


#Knowledge Base

https://dev.to/moe23/learn-unit-test-with-net-6-with-xunit-and-moq-k9i
