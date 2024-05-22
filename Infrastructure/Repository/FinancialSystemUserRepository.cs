using Domain.Interfaces;
using Entities.Entities;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository;

public class FinancialSystemUserRepository : GenericsRepository<FinancialSystemUser>, IFinancialSystemUser
{
    public Task<IList<FinancialSystemUser>> GetSystemUsers(Guid systemId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveSystemUsers(List<FinancialSystemUser> users)
    {
        throw new NotImplementedException();
    }

    public Task<FinancialSystemUser> GetFinancialSystemUserById(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<FinancialSystemUser> GetFinancialSystemUserByEmail(string userEmail)
    {
        throw new NotImplementedException();
    }
}