using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_store
{
    public class Director
    {



        Computer_Builder computer_Builder;
        public Director(Computer_Builder computer_Builder) {
        
        
        this.computer_Builder = computer_Builder;
        
        
        }




        public Computer Constrct() {


            this.computer_Builder.BuildProcessor();
            this.computer_Builder.BuildStorage();
            this.computer_Builder.BuildGraphics_Card();
            this.computer_Builder.BuildRAM();
            this.computer_Builder.BuildPower_Supply();
            this.computer_Builder.BuildOperating_System();

            return this.computer_Builder.Build();





        }
    }
}
