namespace PhonebookApiWidthDb.Models
{
    public class ContactStorageException : Exception
    {
        public ContactStorageException(Exception innerException, string message) : base (message, innerException) 
        {
            
        }

    }
}
