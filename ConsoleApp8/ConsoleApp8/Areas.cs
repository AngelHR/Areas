using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Areas
    {
        private double Pi = 3.1416;
        private double Altura { get; set; }
        private double Base { get; set; }
        private double Radio { get; set; }

        public void Rectangulo(double p, double b)
        {
            Altura = p;
            Base = b;
        }

        public double AreaRec()
        {
            double r =Altura * Base;
            return r;
        }
        public void Ciculo()
        {
            Console.WriteLine("Dame el radio del circulo");
            Radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Su area {0}",AreaC());
        }
        public double AreaC()
        {
            double r = Pi * Pot(Radio, 2); ;
            return r;
        }
        public void Cono()
        {
            Console.WriteLine("Dame el radio del cono");
            Radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame la altura del cono");
            Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Su area es: {0}",AreaC()*Altura/2);
        }

        public double Pot(double r, int e)
        {
            double res;
            if (e == 0)
                return 1;
            else
                res = r * Pot(r, e - 1);
            return res;
        }

            public void Menu(Areas h, int n)
        {

                switch (n)
                {
                    case 1:
                        int r, t;
                        Console.WriteLine("Dame la base del Rectangulo\n");
                        r = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dame la base del Rectangulo\n");
                        t = int.Parse(Console.ReadLine());
                        Rectangulo(r, t);
                        Console.WriteLine($"Su Area es:{ AreaRec()}\n");
                       
                        break;
                    case 2:
                        Ciculo();
                        break;
                    case 3:
                        Cono();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo....\n");
                        break;
                    default:
                        Console.WriteLine("Selecciona la opcion funcional.");
                        break;
                   
                }
           
        }

}
}
