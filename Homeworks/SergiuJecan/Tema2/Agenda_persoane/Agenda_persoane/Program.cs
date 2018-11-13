using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_persoane
{
    class Program
    {
        public static List<Persoana> lista = new List<Persoana>();
        static void Main(string[] args)
        {
            String operatie;

            Console.WriteLine("Aplicatia va Crea o lista de pesoane.");

            do
            {
                Console.WriteLine("Alegeti operatia:");

                Console.WriteLine("1 - Adaugare pesoana la lista");
                Console.WriteLine("2 - Sorteaza alfabetic");
                Console.WriteLine("3 - Sorteaza invers alfabetic");
                Console.WriteLine("4 - Sorteaza dupa ID");
                Console.WriteLine("5 - Cautare");
                Console.WriteLine("X - Exit");
                operatie = Console.ReadLine();

                switch (operatie.ToUpper())
                {
                    case "1":
                        AddPersoana();
                        break;
                    case "2":
                        SorteazaAlfabetic();
                        break;
                    case "3":
                        SorteazaInversAlfabetic();
                        break;
                    case "4":
                        SorteazaID();
                        break;
                    case "5":
                        Cautare();
                        break;
                }

                
            }
            while (operatie != "X");



        }

        private static void Cautare()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Dati numele de cautat: ");
            string cauta = Console.ReadLine();
            Console.WriteLine("S-a gasit cuvantul \" {0} \" : {1}", cauta, lista.FindAll(x => x.Nume.Contains(cauta)));

        }

        private static void SorteazaID()
        {
            // throw new NotImplementedException();
            lista.Sort((x,y) => x.Id.CompareTo(y.Id));
            foreach (var pers in lista)
            {
                Console.WriteLine(pers.Id + " " + pers.Nume);
            }
        }

        private static void SorteazaAlfabetic()
        {
            // throw new NotImplementedException();
            lista.Sort((x, y) => x.Nume.CompareTo(y.Nume));
            foreach (var pers in lista)
            {
                Console.WriteLine(pers.Id + " " + pers.Nume);
            }
        }

        private static void SorteazaInversAlfabetic()
        {
            // throw new NotImplementedException();
            lista.Sort((x, y) => y.Nume.CompareTo(x.Nume));
            foreach (var pers in lista)
            {
                Console.WriteLine(pers.Id + " " + pers.Nume);
            }
        }

        private static void AddPersoana()
        {
            //throw new NotImplementedException();
            Console.WriteLine("ID-ul persoanei: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numele: ");
            string nume = Console.ReadLine();

            Persoana persoanaDeAdaugat = new Persoana(id, nume);
            lista.Add(persoanaDeAdaugat);

        }
    }
}
