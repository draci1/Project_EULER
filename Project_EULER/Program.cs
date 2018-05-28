using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_EULER
{
    class Program
    {
        static void Capitalize()
        {
            int temp = 0;
            Console.Write("Jepni tekstin tuaj qe ta konvertoni ne shkronja te medha: ");
            string a = Console.ReadLine();
            char[] separated = new char[a.Length];
            foreach (char x in a)
            {
                separated[temp] = x;
                temp++;
            }
            temp = 0;
            for (int i = 0; i < separated.Length; i++)
            {
                if (Convert.ToInt32(separated[i]) >= 97 && Convert.ToInt32(separated[i]) <= 122)
                {
                    temp = Convert.ToInt32(separated[i]);
                    temp = temp - 32;
                    separated[i] = Convert.ToChar(temp);
                }
            }
            a = "";
            foreach (char x in separated)
            {
                a = a + x;
            }
            Console.WriteLine(a);
            //attemps of solving: 5
            //solved via: debugging, http://ee.hawaii.edu/~tep/EE160/Book/chap4/subsection2.1.1.1.html
        }
        static void Sum_of_Multiples()
        {
            Console.Write("Ju lutem jepni shumefishin e pare: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ju lutem jepni shumefishin e dyte: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write("Deri te cili numer deshironi te llogarisni: ");
            int finish = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 0; i < finish; i++) 
            {
                if (i % first == 0 || i % second == 0) 
                    s = s + i;
            }
            Console.WriteLine("Shuma e shumefishave te {0} dhe {1} deri ne {2} eshte: {3}", first, second, finish, s);
        }
        static void Fibonacci_Sum()
        {
            Console.Write("Ju lutem jepni numrin kufitar: ");
            int finish = int.Parse(Console.ReadLine());
            int sum = 0;
            int x = 1;
            int y = 2;
            while (x <= finish)
            {
                if (x % 2 == 1)
                    sum = sum + x;
                int z = x + y;
                x = y;
                y = z;
            }
            Console.WriteLine("Shuma e numrave tek te vargut eshte: " + sum);
            //attemps of solving: 5
            //solved via: still not solved(debugging only)
        }
        static void Prime_Factors()
        {
            Console.Write("Ju lutem jepni numrin tuaj: ");
            float n = float.Parse(Console.ReadLine());
            var primes = new List<int>();
            for (var i = 2; i <= n; i++)
            {
                var ok = true;
                foreach (var prime in primes)
                {
                    if (prime * prime > i)
                        break;
                    if (i % prime == 0)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                    primes.Add(i);
            }
            foreach (float x in primes)
                Console.Write(x + "  ");
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---------------------------------------\n\t\t|Programs solved by Florijan Ibraimi   |\n\t\t|Problems can be found at Project Euler|\n\t\t|Date: 13/12/2016 18:53                |\n\t\t----------------------------------------\n");
            while (true)
            {
                
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("| 1.Konvertimi i shkronjave te vogla ne ate te madh                                                  |");
                Console.WriteLine("| 2.Shuma e shumefishave te dy numrave deri ne nje numer kufizues n                                  |");
                Console.WriteLine("| 3.Shuma e numrave tek te vargut te Fibonaqos deri te numri kufizues n                              |");
                Console.WriteLine("| 4.Gjetja e faktoreve te thjeshte te nje numri                                                      |");
                Console.WriteLine("| 5.Dalja nga konsola                                                                                |");
                Console.WriteLine("------------------------------------------------------------------------------------------------------\n");
                Console.Write("Ju lutem jepni numrin e programit te te cilit deshironi te perdorni: ");
                string input = "";
                ConsoleKeyInfo key;
                //Citation_1

                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.Backspace)
                    {
                        double val = 0;
                        bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                        if (_x)
                        {
                            input += key.KeyChar;
                            Console.Write(key.KeyChar);
                        }
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                        {
                            input = input.Substring(0, (input.Length - 1));
                            Console.Write("\b \b");
                        }
                    }
                }
                // Stops Receving Keys Once Enter is Pressed
                while (key.Key != ConsoleKey.Enter);
                int x = Convert.ToInt32(input);
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\n\n");
                //End_Of_Citation_1: http://stackoverflow.com/a/13106530

                switch (x)
                {
                    case 1:
                        Capitalize();
                        break;
                    case 2:
                        Sum_of_Multiples();
                        break;
                    case 3:
                        Fibonacci_Sum();
                        break;
                    case 4:
                        Prime_Factors();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("\n------------------------------------------------------------------------------------------------------");
                Console.Write("Deshironi te perdorni ndonje metode tjeter?[Y,N]: ");
                string weiter = Console.ReadLine();
                if (weiter == "N" || weiter=="n" || weiter=="No" ||weiter=="no" || weiter== "J" || weiter == "j" || weiter == "Jo" || weiter == "jo") break;
            }
            

        }
    }
}
