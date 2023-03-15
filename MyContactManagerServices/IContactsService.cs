using ContactWebModels;

namespace MyContactManagerServices
{
    public interface IContactsService
    {
        Task<IList<Contact>> GetAllAsync();
        Task<Contact?> GetAsync(int id);
        Task<int> AddOrUpdateAsync(Contact contact);
        Task<int> DeleteAsync(Contact contact);
        Task<int> DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
