using System.Text.Json.Serialization;
using System;

namespace Soenneker.Dtos.WebCookie;

/// <summary>
/// Represents a serializable snapshot of HTTP cookie data and browser metadata.
/// </summary>
public sealed class WebCookie
{
    /// <summary>
    /// Gets or sets the name of the cookie.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the value of the cookie.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// Gets or sets the domain for which the cookie is valid.
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// Gets or sets the path for which the cookie is valid.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the cookie is secure (transmitted over HTTPS only).
    /// </summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }

    /// <summary>
    /// Gets or sets whether client-side scripts should be prevented from accessing the cookie.
    /// </summary>
    [JsonPropertyName("httpOnly")]
    public bool? IsHttpOnly { get; set; }

    /// <summary>
    /// Gets or sets the expiration time of the cookie.
    /// </summary>
    [JsonPropertyName("expiry")]
    public DateTime? Expiry { get; set; }

    /// <summary>
    /// Gets or sets the SameSite attribute of the cookie, specifying its SameSite policy.
    /// </summary>
    [JsonPropertyName("sameSite")]
    public string? SameSite { get; set; }

    /// <summary>
    /// Gets or sets the creation time of the cookie.
    /// </summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// Gets or sets the last access time of the cookie.
    /// </summary>
    [JsonPropertyName("lastAccessTime")]
    public DateTime? LastAccessTime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the cookie is persistent.
    /// </summary>
    [JsonPropertyName("isPersistent")]
    public bool? IsPersistent { get; set; }

    /// <summary>
    /// Gets or sets the source of the cookie (e.g., browser or extension).
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}
