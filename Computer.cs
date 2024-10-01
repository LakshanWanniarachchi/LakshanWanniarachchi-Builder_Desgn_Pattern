using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_store
{
    public class Computer
    {


        public string Processor  { get; set; }

        public string RAM { get; set; }

        public string Storage { get; set; }

        public string Graphics_Card { get; set; }

        public string Power_Supply { get; set; }


        public string Operating_System { get; set; }





        public void setProcessor (string Processor)
        {

            this.Processor = Processor;


        }

        public void setRAM(string v)
        {

            this.RAM = RAM;


        }

        public void setStorage(String Storage) { 

            this.Storage = Storage;


        }


        public void setGraphics_Card(String Graphics_Card)
        {

            this.Graphics_Card = Graphics_Card;


        }


        public void setPower_Supply(String Power_Supply)
        {

            this.Power_Supply = Power_Supply;


        }

        public void setOperating_System( String Operating_System)
        {

            this.Operating_System = Operating_System;


        }

        public void Display()
        {



            Console.WriteLine(Processor + " " + RAM + " " + Storage + " " + Graphics_Card + " " + Power_Supply + " " + Operating_System);
        }










    }
}
