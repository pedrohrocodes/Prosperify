using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities;

[Table("Categoria")]
public class Category : Base
{
    [ForeignKey("SistemaFinanceiro")]
    [Column(Order = 1)]
    public Guid SystemId { get; set; }

    public virtual FinancialSystem FinancialSystem { get; set; }
}