using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace computer_store
{
   

    public class gaming_PC : Computer_Builder
    {



        Computer computer;



        public gaming_PC ()
        {



            computer = new Computer ();
        }


        public void BuildProcessor()
        {
            computer.setProcessor("Intel");
        }

        public void BuildRAM()
        {
            computer.setRAM("32GB");
        }

        public void BuildStorage()
        {
            computer.setStorage("SSD  + 1TB");
        }

        public void BuildGraphics_Card()
        {
            computer.setGraphics_Card("NVIDIA ");
        }

        public void BuildPower_Supply()
        {
            computer.setPower_Supply("350W");
        }

        public void BuildOperating_System()
        {
            computer.setOperating_System("Windows");
        }

        public Computer Build()
        {
           return computer;
        }
    }
}
