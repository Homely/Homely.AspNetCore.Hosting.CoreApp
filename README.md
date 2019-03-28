<div>
    <p align="center">
    <img src="https://imgur.com/9E8hN79.png" alt="Homely - ASP.NET Core MVC Helpers" />
    </p>
</div>

# Homely - ASP.NET Core 'Hosting' core application-library.
This application-library contains an opinioned `program.cs` class which is to reduce the ceremony for creating ASP.NET Core "Web Hosting" applications. 

Basically, we (at Homely) use the same `program.cs` code for litterally all of our microservices. So instead of just copying/pasting this code or having [this same code in our Template](https://github.com/Homely/Homely.AspNetCore.WebApi.Template), we've provided this code as a NuGet package so it's easy to update all-or-any microservice if we decide to change something (e.g. we decide to change to a different logging framework).

NOTE: This is a `netcoreapp` application and not a `netstandard` library. So it can only be referenced in another `netcoreapp` .NET Core Application.

[![Build status](https://ci.appveyor.com/api/projects/status/m97lxr4ytwvmhfqj/branch/master?svg=true)](https://ci.appveyor.com/project/Homely/homely-aspnetcore-hosting-coreapp/branch/master)

---
## Why use this? What's wrong with the default standard program.cs?

We're just _extending_ the default `program.cs` content that comes out of the box by wrapping the default code inside `Serilog` error handling. So if _any_ error occurs at any stage of the program (most importantly, at the EARLY starting/initialization stages, `Serilog` will nicely handle this.

That's it :) 

Reducing boilerplate code.

---
## How to use

1. `install-package Homely.AspNetCore.Hosting.CoreApp.Program.Main` into your ASP.NET Core application.

2. In your own `program.cs` file:

```
public static Task Main(string[] args)
{
    return Homely.AspNetCore.Hosting.CoreApp.Main<Startup>(args);
}
```

NOTE: the `Startup` class should be _your_ `Startup.cs` class.

---

## Contributing

Discussions and pull requests are encouraged :) Please ask all general questions in this repo or pick a specialized repo for specific, targetted issues. We also have a [contributing](https://github.com/Homely/Homely/blob/master/CONTRIBUTING.md) document which goes into detail about how to do this.

## Code of Conduct
Yep, we also have a [code of conduct](https://github.com/Homely/Homely/blob/master/CODE_OF_CONDUCT.md) which applies to all repositories in the (GitHub) Homely organisation.

## Feedback
Yep, refer to the [contributing page](https://github.com/Homely/Homely/blob/master/CONTRIBUTING.md) about how best to give feedback - either good or needs-improvement :)

---
