[![](https://img.shields.io/nuget/v/soenneker.dtos.webcookie.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.webcookie/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.webcookie/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.webcookie/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.webcookie.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.webcookie/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.webcookie/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.webcookie/actions/workflows/codeql.yml)

# Soenneker.Dtos.WebCookie

A .NET type representing an HTTP cookie.

## Install

```bash
dotnet add package Soenneker.Dtos.WebCookie
```

## What you get

- `WebCookie` — A .NET type representing an HTTP cookie.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `WebCookie.Name` | Gets or sets the name of the cookie. | Gets or sets the name of the cookie. |
| `WebCookie.Value` | Gets or sets the value of the cookie. | Gets or sets the value of the cookie. |
| `WebCookie.Domain` | Gets or sets the domain for which the cookie is valid. | Gets or sets the domain for which the cookie is valid. |
| `WebCookie.Path` | Gets or sets the path for which the cookie is valid. | Gets or sets the path for which the cookie is valid. |
| `WebCookie.Secure` | Gets or sets a value indicating whether the cookie is secure (transmitted over HTTPS only). | Gets or sets a value indicating whether the cookie is secure (transmitted over HTTPS only). |
| `WebCookie.IsHttpOnly` | Gets or sets a value indicating whether the cookie is accessible only through HTTP requests. | Gets or sets a value indicating whether the cookie is accessible only through HTTP requests. |
| `WebCookie.Expiry` | Gets or sets the expiration time of the cookie. | Gets or sets the expiration time of the cookie. |
| `WebCookie.SameSite` | Gets or sets the SameSite attribute of the cookie, specifying its SameSite policy. | Gets or sets the SameSite attribute of the cookie, specifying its SameSite policy. |
| `WebCookie.CreationTime` | Gets or sets the creation time of the cookie. | Gets or sets the creation time of the cookie. |
| `WebCookie.LastAccessTime` | Gets or sets the last access time of the cookie. | Gets or sets the last access time of the cookie. |
| `WebCookie.IsPersistent` | Gets or sets a value indicating whether the cookie is persistent. | Gets or sets a value indicating whether the cookie is persistent. |
| `WebCookie.Source` | Gets or sets the source of the cookie (e.g., browser or extension). | Gets or sets the source of the cookie (e.g., browser or extension). |
