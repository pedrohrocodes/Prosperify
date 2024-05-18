using System.ComponentModel.DataAnnotations.Schema;
using Entities.Enums;

namespace Entities.Entities;

[Table("Despesa")]
public class Expense : Base
{
    public decimal Value { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    
    public EnumExpenseType ExpenseType { get; set; }
    
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime PayDate { get; set; }
    public DateTime DueDate { get; set; }

    public bool IsPay { get; set; }
    public bool IsOutOfDate { get; set; }

    [ForeignKey("Categoria")]
    [Column(Order = 1)]
    public Guid CategoryId { get; set; }
    public virtual Category Category { get; set; }
}