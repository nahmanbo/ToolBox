using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer1 = new Hammer();
            Hammer hammer2 = new Hammer();
            Saw saw1 = new Saw();
            Wrench wrench1 = new Wrench();
            NailGun nailGun = new NailGun();
            WireStripper wireStripper = new WireStripper(); 
            
            Tool [] tools = new Tool[]{hammer1, hammer2, saw1, wrench1, nailGun, wireStripper};
            foreach (Tool tool in tools)
            {
                tool.Describe();
                tool.Use();
            }
        }
    }
}