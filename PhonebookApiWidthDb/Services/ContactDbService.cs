using Microsoft.EntityFrameworkCore;
using PhonebookApiWidthDb.Models;

namespace PhonebookApiWidthDb.Services
{
    public class ContactDbService : IContactDbService
    {
        private DbService dbService;

        public ContactDbService(DbService dbServiceCons)
        {
            dbService = dbServiceCons; 
        }

        public async Task<Contacts> AddContactAsync(Contacts contacts)
        {
            if (contacts == null)
                throw new NullContactsException("Xatolik"); 

            return await dbService.AddContactDbAsync(contacts);
        }

        public Task<Contacts> RemoveContactAsync(Contacts contacts)
        {
            if (contacts == null)
                throw new NullContactsException("Xatolik");

            return dbService.RemoveContactDbAsync(contacts);
        }

        public Task<Contacts> UpdateContactAsync(Contacts contacts)
        {
            try
            {
                if (contacts == null)
                    throw new NullContactsException("Xatolik");

                return dbService.UpdateContactDbAsync(contacts);
            }
            catch (DbUpdateException ex) 
            {
                throw new ContactStorageException(ex, "Baza uxladi !!!");
            }
        }
    }
}
