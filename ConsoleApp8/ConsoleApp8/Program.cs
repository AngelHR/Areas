using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Areas Area1 = new Areas();
            do
            {
                Console.WriteLine("Que desea Obtener\n[1]Area De un Rectangulo\n[2]Area de un Circulo\n[3]Area del cono\n[4]Salir\n");
                n = int.Parse(Console.ReadLine());
                Area1.Menu(Area1, n);
                if (n == 4)
                    break;
            }while(n != 4);
        }
    }
}
