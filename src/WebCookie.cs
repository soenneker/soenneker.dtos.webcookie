using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System;
using Newtonsoft.Json;

namespace Soenneker.Dtos.WebCookie;

/// <summary>
/// A .NET type representing an HTTP cookie
/// </summary>
[DataContract]
public class WebCookie
{
    /// <summary>
    /// Gets or sets the name of the cookie.
    /// </summary>
    [JsonProperty("name")]
    [JsonPropertyName("name")]
    [DataMember(Name = "name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the value of the cookie.
    /// </summary>
    [JsonProperty("value")]
    [JsonPropertyName("value")]
    [DataMember(Name = "value")]
    public string? Value { get; set; }

    /// <summary>
    /// Gets or sets the domain for which the cookie is valid.
    /// </summary>
    [JsonProperty("domain")]
    [JsonPropertyName("domain")]
    [DataMember(Name = "domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// Gets or sets the path for which the cookie is valid.
    /// </summary>
    [JsonProperty("path")]
    [JsonPropertyName("path")]
    [DataMember(Name = "path")]
    public string? Path { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the cookie is secure (transmitted over HTTPS only).
    /// </summary>
    [JsonProperty("secure")]
    [JsonPropertyName("secure")]
    [DataMember(Name = "secure")]
    public bool? Secure { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the cookie is accessible only through HTTP requests.
    /// </summary>
    [JsonProperty("httpOnly")]
    [JsonPropertyName("httpOnly")]
    [DataMember(Name = "httpOnly")]
    public bool? IsHttpOnly { get; set; }

    /// <summary>
    /// Gets or sets the expiration time of the cookie.
    /// </summary>
    [JsonProperty("expiry")]
    [JsonPropertyName("expiry")]
    [DataMember(Name = "expiry")]
    public DateTime? Expiry { get; set; }

    /// <summary>
    /// Gets or sets the SameSite attribute of the cookie, specifying its SameSite policy.
    /// </summary>
    [JsonProperty("sameSite")]
    [JsonPropertyName("sameSite")]
    [DataMember(Name = "sameSite")]
    public string? SameSite { get; set; }

    /// <summary>
    /// Gets or sets the creation time of the cookie.
    /// </summary>
    [JsonProperty("creationTime")]
    [JsonPropertyName("creationTime")]
    [DataMember(Name = "creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// Gets or sets the last access time of the cookie.
    /// </summary>
    [JsonProperty("lastAccessTime")]
    [JsonPropertyName("lastAccessTime")]
    [DataMember(Name = "lastAccessTime")]
    public DateTime? LastAccessTime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the cookie is persistent.
    /// </summary>
    [JsonProperty("isPersistent")]
    [JsonPropertyName("isPersistent")]
    [DataMember(Name = "isPersistent")]
    public bool? IsPersistent { get; set; }

    /// <summary>
    /// Gets or sets the source of the cookie (e.g., browser or extension).
    /// </summary>
    [JsonProperty("source")]
    [JsonPropertyName("source")]
    [DataMember(Name = "source")]
    public string? Source { get; set; }
}
