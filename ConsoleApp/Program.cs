using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor v = new Vetor();

            string A = "A";
            string B = "B";
            string C = "C";
            string D = "D";
            string E = "E";
            string F = "F";
            string G = "G";
            string H = "H";
            string I = "I";

            v.Adicionar(A);
            v.Adicionar(B);
            v.Adicionar(C);
            v.Adicionar(D);
            v.Adicionar(E);
            v.Adicionar(F);
            v.Adicionar(G,10);
            v.Adicionar(H,2);
            v.Adicionar(I,2);

            Console.WriteLine(v);
            


           
            Console.WriteLine("S: " + v.Contem("S"));
            Console.ReadKey();

        }
    }
}
