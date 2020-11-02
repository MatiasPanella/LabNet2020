using System;
using System.Collections.Generic;
using Lab.Demo.Logic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Capas.Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            RegionLogic regionLogic = new RegionLogic();
            var regiones = regionLogic.Regions();
        }
    }
}
