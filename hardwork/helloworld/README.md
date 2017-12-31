How to run it?

1. install dotnet.
    + windows: install visual studio then you will have develop cmd.
    + linux: install dotnet core.

2. run it.
    + windows: `csc /out:My.exe File.cs`
    + linux: like this `dotnet /usr/share/dotnet/sdk/2.0.0/Roslyn/csc.exe -r:/usr/share/dotnet/shared/Microsoft.NETCore.App/2.0.0/System.Private.CoreLib.dll -r:/usr/share/dotnet/shared/Microsoft.NETCore.App/2.0.0/System.Console.dll -r:/usr/share/dotnet/shared/Microsoft.NETCore.App/2.0.0/System.Runtime.dll HelloWorld.cs`