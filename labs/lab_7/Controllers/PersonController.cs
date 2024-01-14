using Microsoft.AspNetCore.Mvc;
using lab5.zadanie3;
namespace Lab7.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public List<Person> GetAll()
        {
            return _personRepository.GetAll();
        }

        [HttpPost]
        public void BorrowBook( int id, int bookId)
        {
            _personRepository.BorrowBook(id, bookId);
        }

        [HttpGet]
        public List<Book> GetBorrowedBook(int id)
        {
            return _personRepository.GetBorrowedBooks(id);
        }

        [HttpGet]
        public Person Get(int id)
        {
            return _personRepository.Get(id);
        }

        [HttpPost]
        public void Create(Person person)
        {
            _personRepository.Create(person);
        }

        [HttpPut]
        public void Update(Person person)
        {
            _personRepository.Update(person);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _personRepository.Delete(id);
        }
    }
}