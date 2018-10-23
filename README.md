# Homely - ASP.NET Core WebApi core library.
This library contains an opinioned `program.cs` class which is to reduce the ceremony for creating WebApi's. 

Basically, we (at Homely) use the same `program.cs` code for litterally all of our microservices. So instead of just copying/pasting this code or having [this same code in our Template](https://github.com/Homely/Homely.AspNetCore.WebApi.Template), we've provided this code as a NuGet package so it's easy to update all-or-any microservice if we decide to change something (e.g. we decide to change to a different logging framework).

NOTE: This is a `netcoreapp` application and not a `netstandard` library. So it can only be referenced in another `netcoreapp` .NET Core Application.

---
## How to use

1. `install-package Homely.AspNetCore.WebApi.Core` into your .NET Core Application.

2. In your own `program.cs` file:

```
public static Task Main(string[] args)
{
    return Homely.AspNetCore.WebApi.Core.Main<Startup>(args);
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
