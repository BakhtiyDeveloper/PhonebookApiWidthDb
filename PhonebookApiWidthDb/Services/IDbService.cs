using Microsoft.EntityFrameworkCore;
using PhonebookApiWidthDb.Models;

namespace PhonebookApiWidthDb.Services
{
    public interface IDbService 
    {
        Task<Contacts> AddContactDbAsync(Contacts contacts);

        Task<Contacts> UpdateContactDbAsync(Contacts contacts);

        Task<Contacts> RemoveContactDbAsync(Contacts contacts);
        void OnConfiguring(DbContextOptionsBuilder optionsBuilder, IConfiguration configuration);
        void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
    }
}