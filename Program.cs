using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_store
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Computer computer = new Director(new work_PC()).Constrct();
            computer.Display();
        }
    }
}
