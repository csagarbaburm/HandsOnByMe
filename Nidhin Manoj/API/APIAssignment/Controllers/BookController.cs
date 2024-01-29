using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIAssignment.Model;
using APIAssignment.Repositories;

namespace APIAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;
        public BookController()
        {
            bookRepository = new BookRepository();
        }
        [HttpPost, Route("AddBook")]
        public IActionResult Add(Book book)
        {
            try
            {
                bookRepository.Add(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                List<Book> res = bookRepository.GetAllBooks();
                return StatusCode(200, res);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetBooksByAuthor")]
        public IActionResult Get(string author)
        {
            try
            {
                List<Book> res = bookRepository.GetBooksByAuthor(author);
                return StatusCode(200, res);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetBooksByLanguage")]
        public IActionResult GetByLanguage(string author)
        {
            try
            {
                List<Book> res = bookRepository.GetBooksByLanguage(author);
                return StatusCode(200, res);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetBooksByYear")]
        public IActionResult GetByYear(int year)
        {
            try
            {
                List<Book> res = bookRepository.GetBooksByYear(year);
                return StatusCode(200, res);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetBooksByName/{name}")]
        public IActionResult GetByName(string name)
        {
            try
            {
               
                return StatusCode(200, bookRepository.GetBooksByName(name));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetBooksById/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {

                return StatusCode(200,bookRepository.GetBooksById(id));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpPut, Route("UpdateBook")]
        public IActionResult Update(Book book)
        {
            try
            {

                bookRepository.Update(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpDelete, Route("DeleteBook/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {

                bookRepository.Delete(id);
                return StatusCode(200, "deleted successfully");
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

    }
}
