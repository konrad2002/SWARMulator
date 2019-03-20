using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWARMulator
{
    class Settings
    {
        public static int Width { get; private set; }
        public static int Height { get; private set; }
        public static int Walls { get; private set; }
        public static int Ants { get; private set; }

        public Settings()
        {
            Width = 20;
            Height = 20;
            Walls = 0;
            Ants = 1;
        }
    }
}
