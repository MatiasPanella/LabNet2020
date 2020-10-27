using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._4
{
    public class ClsCustomException :  Exception
    { 
        public ClsCustomException (string message) : base ("Mensaje de ecxepcion customizada: " + message){
            }
        
    }
}
