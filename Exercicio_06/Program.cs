using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estruturas de repetição

            //FOR
            int i;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                
                  //WHILE
                  while (i <= 10)
                  {
                      Console.WriteLine(i);
                      i++;
                  }

                        //FOREACH
                        string[] nomes = { "Cleber", "Carol", "Denis", "Roberto" };
                        foreach (string pessoa in nomes)
                        {
                            Console.WriteLine(pessoa);
                        }
                Console.ReadKey();
            }

        }
    }
}