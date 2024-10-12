using System.Text.Json.Serialization;

namespace AJFileServer.DTOs;

[JsonSerializable(typeof(FileDTO))]
public record FileDTO
{
    public string? FileName { get; set; } = null;
    public string? FilePath { get; set; } = null;
    public string? Description { get; set; } = null;
    public string? Tags { get; set; } = null;
}
