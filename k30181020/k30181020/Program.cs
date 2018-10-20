using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k30181020
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IPrzedstawSie> Obiekty = new List<IPrzedstawSie>();
            List<Figura> ListaFigur = new List<Figura>();

            

            Obiekty.Add(new Osoba());
            Obiekty.Add(new Prostokat(12, 41));
            Obiekty.Add(new Kwadrat(34));
            Obiekty.Add(new Okrag(4.0f));

            foreach (var Obj in Obiekty)
            {
                Console.WriteLine(Obj.PrzedstawSie);
            }
            //Console.WriteLine($"Figura = {obj}");


            Console.WriteLine($"Ilosc instancji={Figura.LiczbaInstancji}");
            Console.ReadKey();

        }
    }
}
