using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities;

[Table("UsuarioSistemaFinanceiro")]
public class FinancialSystemUser
{
    public Guid Id { get; set; }
    public string UserEmail { get; set; }
    public bool Admin { get; set; }
    public bool ActualSystem { get; set; }
    
    [ForeignKey("SistemaFinanceiro")]
    [Column(Order = 1)]
    public Guid SystemId { get; set; }
    public virtual FinancialSystem FinancialSystem { get; set; }
}