using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._2
{
    public class CustomExceptions : Exception
    {
        public CustomExceptions(string message) : base("En la Real Academia Española dijeron que no se puede dividir por cero." + message){
           
        }
        public CustomExceptions() : base("Seguro ingresaste una letra o no ingresaste nada"){ }
    }
}
