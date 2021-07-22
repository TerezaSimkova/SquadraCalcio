using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraCalcio
{
    class Atleti
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public int Age { get; set; }

        public Atleti(string firstName, string lastName, int age)
        {
            FirstName = firstName; //costruttore
            LastName = lastName;
            Age = age;

        }
        public Atleti()
        {

        }
    }

}
