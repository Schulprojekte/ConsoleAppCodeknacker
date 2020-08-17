using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodeknacker
{
    class Program
    {
        private static int i, j, k, l;
        private static char a, b, c, d;

        private static string e, f, g, h, code, testZahl, geknackt = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie den zu knackenden Code mit 4 Großbuchstaben ein: ");
            code = Convert.ToString(Console.ReadLine());
            knacker();
            Console.WriteLine("Der eingegebene Code war: " + geknackt);
            Console.ReadKey();
        }

        private static void knacker()
        {
            for(i = 65; i <= 90; i++) //bis 90 nur Großbuchstaben bis 122 Groß- und Kleinschreibung
            {
                for(j = 65; j <= 90; j++)
                {
                    for(k = 65; k <= 90; k++)
                    {
                        for(l = 65; l <= 90; l++)
                        {
                            a = Convert.ToChar(i);
                            b = Convert.ToChar(j);
                            c = Convert.ToChar(k);
                            d = Convert.ToChar(l);
                            e = Convert.ToString(a);
                            f = Convert.ToString(b);
                            g = Convert.ToString(c);
                            h = Convert.ToString(d);

                            testZahl = e + f + g + h;

                            if(testZahl == code)
                            {
                                geknackt = testZahl;
                            }
                            Console.WriteLine(testZahl);
                        } //4 Klammern für for Schleife
                    }
                }
            }
        } // Methode
    }
}