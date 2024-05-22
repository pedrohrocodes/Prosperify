using Entities.Entities;

namespace Domain.Interfaces;

public interface ICategory : IGeneric<Category>
{
    Task<IList<Category>> GetUserCategoriesList(Guid userId);
}