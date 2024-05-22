using Entities.Entities;

namespace Domain.Interfaces;

public interface IFinancialSystem : IGeneric<FinancialSystem>
{
    Task<IList<FinancialSystem>> GetUserSystemList(Guid userId);
}