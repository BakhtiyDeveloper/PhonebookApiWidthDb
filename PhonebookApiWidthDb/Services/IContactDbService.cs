using PhonebookApiWidthDb.Models;

namespace PhonebookApiWidthDb.Services
{
    public interface IContactDbService
    {
        Task<Contacts> AddContactAsync(Contacts contacts);

        Task<Contacts> UpdateContactAsync(Contacts contacts);

        Task<Contacts> RemoveContactAsync(Contacts contacts);
    }
}
