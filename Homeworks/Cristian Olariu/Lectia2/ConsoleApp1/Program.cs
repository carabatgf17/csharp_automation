namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Persoana
    {
        public Persoana(string id, string prenume, string nume)
        {
            this.Id = id;
            this.Nume = nume;
            this.Prenume = prenume;
        }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Id { get; set; }

        public override string ToString()
        {
            return "ID:" + this.Id + " " + this.Nume + " " + this.Prenume;
        }
    }

    public class Program
    {
        public static void Main()
        {
            var persons = new List<Persoana>();
            persons.Add(new Persoana("ID2", "Cristian", "Olariu"));
            persons.Add(new Persoana("ID1", "Ilie", "Olariu"));
            persons.Add(new Persoana("ID3", "Cristian", "Vasile"));
            persons.Add(new Persoana("ID5", "Atti", "Vasile"));
            persons.Add(new Persoana("ID4", "Dacian", "Gheorghe"));
            Console.WriteLine("\nLista este");
            foreach (Persoana aPerson in persons)
            {
                Console.WriteLine(aPerson);
            }
            Console.WriteLine("\nOrdonare dupa ID - descrescator");
            foreach (Persoana aPerson in persons.OrderByDescending(p => p.Id))
            {
                Console.WriteLine(aPerson);
            }
            Console.WriteLine("\nOrdonare dupa Nume - crescator");
            foreach (Persoana aPerson in persons.OrderBy(p => p.Nume))
            {
                Console.WriteLine(aPerson);
            }
            string numeDat = "Olariu";
            Console.WriteLine("\nSe cauta dupa {0} ...", numeDat);
            var numeDatRezultat = persons.Where(p => p.Nume == numeDat);
            if (numeDatRezultat.Any())
            {
                foreach (Persoana aPerson in persons.Where(p => p.Nume == numeDat))
                {
                    Console.WriteLine(aPerson);
                }
            }
            else
            {
                Console.WriteLine("Nu sunt persoane cu numele {0}", numeDat);
            }
            Console.ReadKey();
        }
    }
}
