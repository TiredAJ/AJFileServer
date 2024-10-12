using System.Text.Json.Serialization;

namespace AJFileServer.DTOs;

[JsonSerializable(typeof(TagDTO))]
public record TagDTO
{
    public string? Name { get; set; } = null;
    public List<TagDTO>? Tags { get; set; } = null;
}
