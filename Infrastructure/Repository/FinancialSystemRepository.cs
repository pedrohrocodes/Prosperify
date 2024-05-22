using Domain.Interfaces;
using Entities.Entities;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository;

public class FinancialSystemRepository : GenericsRepository<FinancialSystem>, IFinancialSystem
{
    
}