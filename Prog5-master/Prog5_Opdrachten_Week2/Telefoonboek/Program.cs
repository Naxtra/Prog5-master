using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefoonboek{

    class Program
    {
        static void Main(string[] args)
        {
            List <IPerson> people = new List<IPerson>() {
                new Person() {
                    FirstName = "Aard",
                    LastName = "Brunschot",
                    TelephoneNumber = "0612345678",
                },
                new Person(){
                    FirstName = "Bea",
                    LastName = "Bla",
                    TelephoneNumber = "0643428924",
                },
                new Person(){
                    FirstName = "Celine",
                    LastName = "van Hamond",
                    TelephoneNumber = "0648239452",
                }

            };

            TelephoneBoek book = new TelephoneBoek(people);

            Console.WriteLine("### Sorteren op achternaam ###");
            var result = book.SortByLastName();
            PrintList(result);
            Console.WriteLine("");

            Console.WriteLine("### Firstname begint met 'B' ###");
            result = book.FirstNameStartWith('B');
            PrintList(result);
            Console.WriteLine("");

            Console.WriteLine("### Lastname langer dan 9 ###");
            result = book.LastNameLongerThen(9);
            PrintList(result);
            Console.WriteLine("");

            Console.WriteLine("### Sorteren op achternaam lengte ###");
            result = book.SortByLastNameLength();
            PrintList(result);
            Console.WriteLine("");

            Console.ReadLine();
        }

        public static void PrintList(List<IPerson> people)
        {
            for (int index = 1; index - 1 < people.Count; index++)
            {
                IPerson person = people[index - 1];
                Console.WriteLine(index + ". " + person.FirstName + " " + person.LastName + " - " + person.TelephoneNumber);
            }
        }
    }
}
