using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraCalcio
{
    class Arbitro : Atleti
    {
        public int NumAnniCarriera { get; set; }
        public Arbitro(string firstName, string lastName, int age, int numAnniCarriera)
            : base(firstName, lastName, age)
        {
            NumAnniCarriera = numAnniCarriera;
        }
        public Arbitro()
        {

        }
    }
}
