using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//fluent Api
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
