using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ClsCustomException("Algo mal habras hecho para que te salga este mensaje, solo Dios sabra que sera...");
            }
            catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
