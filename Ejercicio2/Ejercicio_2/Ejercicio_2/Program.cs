using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                int resultado, i;
                Console.WriteLine("Ingresa un numero");
                i = int.Parse(Console.ReadLine());
                resultado =(i/0);
                Console.WriteLine("operacion exitosa");
             }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Operación fallida");
                Console.WriteLine(ex.Message);
               
            }
            //LAS POSIBLES EXCEPCIONES PUEDEN SER DE FORMATO Y POR INGREGAR UN NUMERO MAYOR AL INT32 (OVERFLOW)
            catch (Exception ex)
            {
                Console.WriteLine("Operación fallida");
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
