using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefoonboek
{
    class TelephoneBoek
    {
        public List<IPerson> people { get; set; }

        public TelephoneBoek(List<IPerson> people) {
            this.people = people;
        }

        public List<IPerson> SortByLastName()
        {
            return people.OrderBy(lastName => lastName.LastName).ToList();
        }

        public List<IPerson> FirstNameStartWith(char letter)
        {
            //van uitwerking
            return people.Where(p => p.FirstName[0] == letter).OrderBy(p => p.LastName).ToList();
        }

        public List<IPerson> LastNameLongerThen(int minLength)
        {
            return people.Where(p => p.LastName.Length > minLength).OrderBy(p => p.LastName).ToList();
        }

        public List<IPerson> SortByLastNameLength()
        {
            return people.OrderBy(p => p.LastName.Length).ToList();
        }

        public int peopleInList
        {
            get { return people.Count; }
        }
    }
}
