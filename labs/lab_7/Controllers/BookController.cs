using Microsoft.AspNetCore.Mvc;
using lab5.zadanie3;
namespace Lab_7.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public Book Get(int id)
        {
            return _bookRepository.Get(id);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }


        [HttpGet]
        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        [HttpPost]
        public void Create(Book input)
        {
            _bookRepository.Create(input);
        }

        [HttpPut]
        public void Update(Book input)
        {
            _bookRepository.Update(input);
        }

        [HttpGet]
        public List<Book> GetBooksByAuthor(string autor)
        {
            return _bookRepository.GetBooksByAuthor(autor);
        }

        [HttpGet]
        public List<Book> GetBooksByYear(int year)
        {
            return _bookRepository.GetBooksByYear(year);
        }

    }

}