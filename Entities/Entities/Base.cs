using System.ComponentModel.DataAnnotations;
using Entities.Notifications;

namespace Entities.Entities;

public class Base : Notify
{
    [Display(Name = "Código")]
    public Guid Id { get; set; }
    
    [Display(Name = "Nome")]
    public string Name { get; set; }
}