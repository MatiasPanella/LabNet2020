using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese un numero para un dia de la semana: 1-Lunes 2-Martes 3-Micercoles 4-Jueves 5-Viernes 6-Sabado 7-Domingo" );
            int dia = int.Parse(Console.ReadLine());
           
            try
            {
                Console.WriteLine( ClsLogic.ThrowExceptionDay(dia));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }
            Console.ReadKey();
        }
    }
}
