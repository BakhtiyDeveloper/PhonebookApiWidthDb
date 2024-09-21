namespace PhonebookApiWidthDb.Models
{
    public class NullContactsException : Exception
    {
        public NullContactsException(string message) : base (message) 
        {
            
        }

    }
}
