using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio_2._2
{
    class Program
    {
        public static int b { get;  set; }
        public static int a { get; set; }

        static void Main(string[] args)
        {
            do
            {
                try
                {
               
                    int resultado;
                    Console.WriteLine("ingrese un numero ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese otro numero ");
                    b = int.Parse(Console.ReadLine());
                    resultado = a.MakeDivision(b);
                    Console.WriteLine(resultado);
                   
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(new CustomExceptions(" ASI QUE BASTA DE QUERER DIVIDIR POR CERO"));        
                    Console.WriteLine(ex.Message);
                  
                }
                catch (Exception ex)
                {
                    Console.WriteLine(new CustomExceptions());
                    Console.WriteLine(ex.Message);
                }
               
            } while (a == 0 || b == 0);
            
            Console.ReadKey();
          
        }
    }
    
}
