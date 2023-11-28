using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models;

[Table("user")]
public class UserModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long id { get; set; }

    [Required]
    public string username { get; set; }

    [Required]
    public string email { get; set; }

    [Required]
    public string avatar { get; set; }
}