using System.Text.Json.Serialization;
using System;
using Newtonsoft.Json;

namespace Soenneker.Dtos.WebCookie;

/// <summary>
/// A .NET type representing an HTTP cookie
/// </summary>
public class WebCookie
{
    /// <summary>
    /// Gets or sets the name of the cookie.
    /// </summary>
    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the value of the cookie.
    /// </summary>
    [JsonProperty("value")]
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// Gets or sets the domain for which the cookie is valid.
    /// </summary>
    [JsonProperty("domain")]
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// Gets or sets the path for which the cookie is valid.
    /// </summary>
    [JsonProperty("path")]
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the cookie is secure (transmitted over HTTPS only).
    /// </summary>
    [JsonProperty("secure")]
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the cookie is accessible only through HTTP requests.
    /// </summary>
    [JsonProperty("httpOnly")]
    [JsonPropertyName("httpOnly")]
    public bool? IsHttpOnly { get; set; }

    /// <summary>
    /// Gets or sets the expiration time of the cookie.
    /// </summary>
    [JsonProperty("expiry")]
    [JsonPropertyName("expiry")]
    public DateTime? Expiry { get; set; }

    /// <summary>
    /// Gets or sets the SameSite attribute of the cookie, specifying its SameSite policy.
    /// </summary>
    [JsonProperty("sameSite")]
    [JsonPropertyName("sameSite")]
    public string? SameSite { get; set; }

    /// <summary>
    /// Gets or sets the creation time of the cookie.
    /// </summary>
    [JsonProperty("creationTime")]
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// Gets or sets the last access time of the cookie.
    /// </summary>
    [JsonProperty("lastAccessTime")]
    [JsonPropertyName("lastAccessTime")]
    public DateTime? LastAccessTime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the cookie is persistent.
    /// </summary>
    [JsonProperty("isPersistent")]
    [JsonPropertyName("isPersistent")]
    public bool? IsPersistent { get; set; }

    /// <summary>
    /// Gets or sets the source of the cookie (e.g., browser or extension).
    /// </summary>
    [JsonProperty("source")]
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
