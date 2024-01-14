using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_7;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab7.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
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
        public void BorrowBook(long id, int bookId)
        {
            _personRepository.BorrowBook(id, bookId);
        }

        [HttpGet]
        public List<Book> GetBorrowedBook(long id)
        {
            return _personRepository.GetBorrowedBook(id);
        }

        [HttpGet]
        public Person Get(long id)
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
