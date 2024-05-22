using Entities.Entities;

namespace Domain.Interfaces;

public interface IFinancialSystemUser : IGeneric<FinancialSystemUser>
{
    Task<IList<FinancialSystemUser>> GetSystemUsers(Guid systemId);
    Task RemoveSystemUsers(List<FinancialSystemUser> users);
    Task<FinancialSystemUser> GetFinancialSystemUserById(Guid userId);
    Task<FinancialSystemUser> GetFinancialSystemUserByEmail(string userEmail);
}