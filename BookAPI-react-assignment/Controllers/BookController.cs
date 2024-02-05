using BookAPI_react_assignment.Entities;
using BookAPI_react_assignment.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI_react_assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookController : ControllerBase
    {
        public BookRepository bookRepository;

        public BookController(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [HttpPost("AddBook")]
        public IActionResult AddBook(Book book)
        {
            bookRepository.AddBook(book);
            return StatusCode(200, book);
        }
        [HttpGet("GetAllBooks")]
        public IActionResult GetAllBook() { 
            return StatusCode(200,bookRepository.GetAllBooks());
        }

        [HttpGet("GetBookByID/{id}")]
        public IActionResult GetBook(string id)
        {
            return Ok(bookRepository.GetBook(id));
        }


        [HttpPut("EditBook")]
        public IActionResult UpdateBook(Book book)
        {
            bookRepository.UpdateBook(book);
            return StatusCode(200, book);
        }

        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(string id)
        {
            bookRepository.DeleteBook(id);
            return Ok("Book Deleted");
        }


    }
}
