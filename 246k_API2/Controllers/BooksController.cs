using _246k_API2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _246k_API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // Общий учебный список книг
        private static List<Book> books = new()
        {
            new Book { Id = 1, Title = "C#", Price = 500 },
            new Book { Id = 2, Title = "WPF", Price = 700 },
            new Book { Id = 3, Title = "API", Price = 900 }
        };
        
        
        // GET http://localhost:5000/api/books
        [HttpGet]
        public IActionResult GetAll()
        {
            // Возвращаем статус 200 и список книг
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Ищем книгу по идентификатору
            Book book = books.FirstOrDefault(b => b.Id == id);

            // Если книги нет, возвращаем 404
            if (book == null) 
                return NotFound();

            // Иначе возвращаем найденную книгу
            return Ok(book);

        }

        [HttpPost]
        public IActionResult Create([FromBody] Book book)
        {
            // Назначаем новый идентификатор
            book.Id = books.Max(b => b.Id) + 1;

            // Добавляем объект в общий список
            books.Add(book);

            // Возвращаем созданный объект
            return Ok(book);
        }







    }
}
