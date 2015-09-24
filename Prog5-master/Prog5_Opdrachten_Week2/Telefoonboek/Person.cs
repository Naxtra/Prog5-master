using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefoonboek
{
    class Person : IPerson
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String TelephoneNumber { get; set; }

        public void FullName()
        {
            String fullName = FirstName + " " + LastName;
        }
    }
}
