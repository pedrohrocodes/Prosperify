using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities;

[Table("SistemaFinanceiro")]
public class FinancialSystem : Base
{
    public int Month { get; set; }
    public int Year { get; set; }
    public int CloseDay { get; set; }
    public bool GenerateCopyExpense { get; set; }
    public int CopyMonth { get; set; }
    public int CopyYear { get; set; }
}