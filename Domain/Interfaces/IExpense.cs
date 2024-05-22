using Entities.Entities;

namespace Domain.Interfaces;

public interface IExpense : IGeneric<Expense>
{
    Task<IList<Expense>> GetUserExpensesList(Guid userId);
    Task<IList<Expense>> GetUserLateExpensesList(Guid userId);
}