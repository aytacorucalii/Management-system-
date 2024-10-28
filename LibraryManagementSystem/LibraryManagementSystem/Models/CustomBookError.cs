
namespace LibraryManagementSystem.Models
{
    [Serializable]
    internal class CustomBookError : Exception
    {
        public CustomBookError()
        {
        }

        public CustomBookError(string? message) : base(message)
        {
        }

        public CustomBookError(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}