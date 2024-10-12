using CSharpFunctionalExtensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace AJFileServer.Models;

[Table("tag")]
public class Tag
{
    [Column("id")]
    private int ID { get; set; }
    [Column("name")]
    private String _Name = string.Empty;
    [Column("tags")]
    private List<Tag> _Tags = new();
    
    public Maybe<string> Name { get => _Name; set => _Name = value.GetValueOrThrow(new ArgumentNullException(nameof(Name))); }
    public Maybe<List<Tag>> Tags { get => _Tags; set => _Tags = value.GetValueOrThrow(new ArgumentNullException(nameof(Tags))); }
}
