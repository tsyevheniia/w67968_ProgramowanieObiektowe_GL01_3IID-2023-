using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lab_7.Controllers
{
    namespace Lab7.Controllers
    {
        [Route("api/[controller]/[action]")]
        [ApiController]
        public class BookController : ControllerBase
        {
            private readonly BookRepository _bookRepository;

            public BookController(BookRepository bookRepository)
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
            public List<Book> GetBooksByAuthor(string author)
            {
                return _bookRepository.GetBooksByAuthor(author);
            }

            [HttpGet]
            public List<Book> GetBooksByPublishYear(int year)
            {
                return _bookRepository.GetBooksByPublishYear(year);
            }

        }

        public class BookRepository
        {
        }
    }

