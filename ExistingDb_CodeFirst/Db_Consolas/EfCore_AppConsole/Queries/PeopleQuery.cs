using EfCore_AppConsole.Configuration;
using Efcore_DbLibrary;
using Microsoft.EntityFrameworkCore;

namespace EfCore_AppConsole.Queries
{
    public static class PeopleQuery
    {
        static DbContextOptionsBuilder<AdventureWorksContext> optionsBuilder = AppSetup._optionsBuilder;
        public static void ListPeople()
        {
            using (var db = new AdventureWorksContext(optionsBuilder.Options))
            {
                var people = db.People.OrderBy(x => x.LastName).Take(40)
                      .ToList();

                foreach (var person in people)
                {
                    Console.WriteLine($"{person.LastName} {person.FirstName}");
                }
            }
        }
    }
}
