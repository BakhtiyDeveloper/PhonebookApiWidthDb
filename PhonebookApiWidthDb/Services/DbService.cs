using Microsoft.EntityFrameworkCore;
using PhonebookApiWidthDb.Models;
using STX.EFxceptions.SqlServer;

namespace PhonebookApiWidthDb.Services
{
    public class DbService : EFxceptionsContext, IDbService
    {
        private IConfiguration configuration;

        public DbService(IConfiguration configurationKons)
        {
            configuration = configurationKons;
            this.Database.Migrate();
        }

        public DbSet<Contacts> contacts { get; set; }

        public async Task<Contacts> AddContactDbAsync(Contacts contacts)
        {
            DbService dbService = new DbService(configuration);
            await dbService.contacts.AddAsync(contacts);
            await dbService.SaveChangesAsync();

            return contacts;
        }

        public void OnConfiguring(DbContextOptionsBuilder optionsBuilder, IConfiguration configuration)
        {
            throw new NotImplementedException();
        }

        public async Task<Contacts> RemoveContactDbAsync(Contacts contacts)
        {
            DbService dbService = new DbService(configuration);
            dbService.contacts.Remove(contacts);
            await dbService.SaveChangesAsync();

            return contacts;
        }

        public async Task<Contacts> UpdateContactDbAsync(Contacts contacts)
        {
            DbService dbService = new DbService(configuration);
            dbService.contacts.Update(contacts);
            await dbService.SaveChangesAsync();

            return contacts;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string? connectionDbPath = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionDbPath);
        }

        void IDbService.OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
