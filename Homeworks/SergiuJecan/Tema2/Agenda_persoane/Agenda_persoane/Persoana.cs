using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_persoane
{
    class Persoana
    {
        public int Id { get; }
        public string Nume { get; set; }

        public Persoana(int id, string nume)
        {
            Id = id;
            Nume = nume;
        }
    }
}
