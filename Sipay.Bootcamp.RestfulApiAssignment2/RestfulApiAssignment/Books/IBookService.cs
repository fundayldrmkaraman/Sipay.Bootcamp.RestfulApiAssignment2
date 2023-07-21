using RestfulApiAssignment.Models;

namespace RestfulApiAssignment.Books
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
    }
}
