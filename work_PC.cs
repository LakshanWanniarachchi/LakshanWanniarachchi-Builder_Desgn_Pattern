using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_store
{
    public class work_PC : Computer_Builder
    {




        Computer computer;



        public work_PC()
        {



            computer = new Computer();
        }







        public Computer Build()
        {
           return computer;
        }

        public void BuildGraphics_Card()
        {
            computer.setGraphics_Card("AMD");
        }

        public void BuildOperating_System()
        {
            computer.setOperating_System("Windows");
        }

        public void BuildPower_Supply()
        {
            computer.setPower_Supply("250W");
        }

        public void BuildProcessor()
        {
            computer.setProcessor("AMD");
        }

        public void BuildStorage()
        {
            computer.setStorage("SSD-500GB");
        }

        public void BuildRAM()
        {
            computer.setRAM("16GB");
        }
    }
    
}
