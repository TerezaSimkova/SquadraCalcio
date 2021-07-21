using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraCalcio
{
    class Calciatori : Atleti
    {
        public enumRuolo Role { get; set; }
        public int NumMaglia { get; set; }

        public Calciatori(string firstName, string lastName, int age, enumRuolo role, int numMaglia)
            : base(firstName, lastName, age)
        {
            Role = role;
            NumMaglia = numMaglia;

        }
        public Calciatori()
        {

        }


    }
    public enum enumRuolo
    {
        centrocampista,
        difensore,
        attacante,
        portiere
    }
}
