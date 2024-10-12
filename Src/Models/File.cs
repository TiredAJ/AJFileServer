using CSharpFunctionalExtensions;
using System.ComponentModel.DataAnnotations.Schema;

using MString = CSharpFunctionalExtensions.Maybe<System.String>;
using TagList = System.Collections.Generic.List<AJFileServer.Models.Tag>;

namespace AJFileServer.Models;

[Table("files")]
public class File
{
    [Column("id")]
    private int _ID { get; set; }
    
    [Column("fileName")]
    private string? _FileName { get; set; } = null;
    
    [Column("filePath")]
    private string? _FilePath { get; set; } = null;
    
    [Column("description")]
    private string? _Description { get; set; } = null;
    
    [Column("tags")]
    private List<Tag>? _Tags { get; set; } = null;


    public int ID { get => _ID; }
    public MString FileName 
    {
        get => _FileName; 
        set => value.GetValueOrThrow(new ArgumentNullException(nameof(FileName)));
    }

    public MString FilePath
    {
        get => _FileName;
        set => value.GetValueOrThrow(new ArgumentNullException(nameof(FilePath)));
    }

    public MString Description
    {
        get => _Description;
        set => value.GetValueOrThrow(new ArgumentNullException(nameof(Description)));
    }

    public Maybe<TagList> Tags
    {
        get => _Tags;
        set => value.GetValueOrThrow(new ArgumentNullException(nameof(Tags)));
    }
}
