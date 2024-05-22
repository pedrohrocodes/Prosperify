using Domain.Interfaces;
using Entities.Entities;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository;

public class CategoryRepository : GenericsRepository<Category>, ICategory
{
    public Task<IList<Category>> GetUserCategoriesList(Guid userId)
    {
        throw new NotImplementedException();
    }
}