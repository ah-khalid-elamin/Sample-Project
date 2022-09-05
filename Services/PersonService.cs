using Sample_Project.AppContext;
using Sample_Project.Models;

namespace Sample_Project.Services
{
    public class PersonService : IPersonService
    {
        private readonly ApplicationContext _context;
        public PersonService(ApplicationContext context)
        {
            _context = context;
        }
        public List<Person> GetPersons()
        {
            return _context.Persons.ToList();
        }
    }
}
