using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._3
{
    public class ClsLogic : Exception
    {
        public static string ThrowExceptionDay(int dia) {
            switch (dia)
            {
                case 1: 
                    return "Lunes";
                case 2: 
                    return "Martes";
                case 3: 
                    return "Miercoles";
                case 4: 
                    return "Jueves";
                case 5: 
                    return "Viernes";
                case 6: 
                    return "Sabado";
                case 7: 
                    return "Domingo";

                default:
                    throw new ArgumentOutOfRangeException();

            } 

        }
    }
}
