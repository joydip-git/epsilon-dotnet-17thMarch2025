
namespace ContactManagementSystem.Models
{
    public interface IContactManager
    {
        Task<List<ContactModel>> FetchAllContactsAsync();
        Task<ContactModel> GetContactAsync(string mobileNo);
        Task<bool> UpdateContactAsync(ContactModel contact);
        Task<bool> AddContactAsync(ContactModel contact);
        Task<bool> DeleteContactAsync(string mobileNo);
    }
}