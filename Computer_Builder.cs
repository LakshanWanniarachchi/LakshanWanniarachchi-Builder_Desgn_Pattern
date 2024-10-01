using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_store
{
    public interface Computer_Builder
    {
        void BuildProcessor();
        void BuildRAM ();
        void BuildStorage();
        void BuildGraphics_Card();
        void BuildPower_Supply();
        void BuildOperating_System();

        Computer Build();
    }
}
