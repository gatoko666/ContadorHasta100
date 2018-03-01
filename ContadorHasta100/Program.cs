using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Utilizando un iterador escribir en pantalla los números del 1 al 100 de dos en dos.

namespace ContadorHasta100
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 1;
                
                    for (int i = 1; i<=50 ;i++)
                    {
                        
                        Console.WriteLine(contador);
                        contador++;
                        contador++;
          }
                    Console.Read();               
            }
        }
    }

   

