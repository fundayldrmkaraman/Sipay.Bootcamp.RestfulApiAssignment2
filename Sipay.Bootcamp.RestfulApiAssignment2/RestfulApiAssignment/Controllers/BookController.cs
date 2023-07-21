using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestfulApiAssignment.Books;
using RestfulApiAssignment.Models;

namespace RestfulApiAssignment.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> _books = new List<Book>
        { 
            new Book { Id = 1, Title = "Sefiller", Author = "Victor Hugo" },
            new Book { Id = 2, Title = "Beyaz Diş", Author = "Jack London" },
            new Book { Id = 3, Title= "Araba Sevdası", Author= "Recaizade Mahmut Ekrem"},
            new Book { Id = 4, Title= "Vadideki Zambak", Author= "Honoré de Balzac"}
        };

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(_books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _books.Find(b => b.Id == id);
            if (book == null)
            {
                return NotFound("Book not found");
            }

            return Ok(book);
        }

        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            if (book == null)
            {
                return BadRequest("Invalid book data");
            }

            book.Id = GetNextBookId();

            _books.Add(book);

            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Book updatedBook)
        {
            var existingBook = _books.Find(b => b.Id == id);
            if (existingBook == null)
            {
                return NotFound("Book not found");
            }

            existingBook.Title = updatedBook.Title;
            existingBook.Author = updatedBook.Author;

            return Ok(existingBook);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = _books.Find(b => b.Id == id);
            if (book == null)
            {
                return NotFound("Book not found");
            }

            _books.Remove(book);

            return NoContent();
        }

        private int GetNextBookId()
        {
            if (_books.Count == 0)
            {
                return 1;
            }

            int maxId = int.MinValue;
            foreach (var book in _books)
            {
                if (book.Id > maxId)
                {
                    maxId = book.Id;
                }
            }

            return maxId + 1;
        }
    }
}

