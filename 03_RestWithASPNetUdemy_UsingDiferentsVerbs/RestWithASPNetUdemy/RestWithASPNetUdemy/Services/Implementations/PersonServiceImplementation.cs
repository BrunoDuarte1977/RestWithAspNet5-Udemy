using RestWithASPNetUdemy.Model;
using System.Runtime.Versioning;
using System.Xml.Linq;

namespace RestWithASPNetUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public Person Update(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }

        public Person FindById(long id)
        {
            return new Person { 
                Id = IncrementAndGet(),
                FirstName = "Bruno",
                LastName = "Silva",
                Adress = "Rua do Saci",
                Gender = "Male"
            };
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        private Person MockPerson(int i)
        { 
            i = i + 1;
            string fName = GenerateName(3);

            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = fName,
                LastName = GenerateName(6),
                Adress = fName + " Adress",
                Gender = (new Random()).Next(2) == 0 ? "Male" : "Female"
            };
        }

        private int IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }
    }
}
