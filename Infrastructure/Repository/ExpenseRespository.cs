using Domain.Interfaces;
using Entities.Entities;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository;

public class ExpenseRespository : GenericsRepository<Expense>, IExpense
{
    public Task<IList<Expense>> GetUserExpensesList(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Expense>> GetUserLateExpensesList(Guid userId)
    {
        throw new NotImplementedException();
    }
}