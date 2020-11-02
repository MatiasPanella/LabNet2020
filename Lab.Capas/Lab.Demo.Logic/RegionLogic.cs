using Lab.Demo.Entities;
using Lab.Demo.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.Logic
{
    public class RegionLogic
    {
        public List<Region> Regions()
        {
            NorthwindContext context = new NorthwindContext();
            return context.Region.ToList();
        }
    }
}
