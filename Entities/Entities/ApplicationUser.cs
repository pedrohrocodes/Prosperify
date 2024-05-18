using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Entities.Entities;

public class ApplicationUser : IdentityUser
{
    [Column("USR_ID")]
    public Guid UserId { get; set; }
    
    [Column("USR_CPF")]
    public string CPF { get; set; }
}