[![](https://img.shields.io/nuget/v/soenneker.dtos.webcookie.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.webcookie/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.webcookie/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.webcookie/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.webcookie.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.webcookie/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.webcookie/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.webcookie/actions/workflows/codeql.yml)

# Soenneker.Dtos.WebCookie

A serializable snapshot of HTTP cookie data and browser metadata. It supports both `System.Text.Json` and Newtonsoft.Json, but it does not itself parse, store, or enforce cookies.

## Install

```bash
dotnet add package Soenneker.Dtos.WebCookie
```

## Usage

```csharp
using Soenneker.Dtos.WebCookie;

var cookie = new WebCookie
{
    Name = "preferences",
    Value = "compact",
    Domain = "example.com",
    Path = "/",
    Secure = true,
    IsHttpOnly = true,
    SameSite = "Lax",
    Expiry = DateTime.UtcNow.AddDays(30),
    IsPersistent = true,
    Source = "browser"
};
```

All members are optional so partial snapshots can be deserialized. `SameSite` and `Source` are unconstrained strings. `Expiry`, `CreationTime`, and `LastAccessTime` use `DateTime`; preserve or normalize the intended time zone before comparing values from different systems.

`Secure`, `IsHttpOnly`, `SameSite`, `Domain`, and `Path` are data on this DTO only. Setting them does not configure an ASP.NET response, a browser, `CookieContainer`, or any other cookie store. Validate names, domains, paths, expiry, and policy values before translating untrusted data into a live cookie.

Cookie values can contain session credentials. Avoid logging or persisting this DTO in plaintext, and do not accept a client-supplied cookie snapshot as proof of authentication.
