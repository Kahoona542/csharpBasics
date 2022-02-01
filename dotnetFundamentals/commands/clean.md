# dotnet clean

The dotnet clean command cleans the output of the previous build. It's implemented as an MSBuild target, so the project is evaluated when the command is run. Only the outputs created during the build are cleaned. Both intermediate (obj) and final output (bin) folders are cleaned.

## Resources

-[Dotnet clean Documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-clean)

---

[Back to home](../README.md)