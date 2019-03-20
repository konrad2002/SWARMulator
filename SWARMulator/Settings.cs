using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWARMulator
{
    class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Walls { get; set; }
        public static int Ants { get; set; }
        public static int Size { get; set; }

        public class Base
        {
            public static int X { get; set; }
            public static int Y { get; set; }
        }

        public class Food
        {
            public static int X { get; set; }
            public static int Y { get; set; }
        }

        public Settings()
        {
            Width = 20;
            Height = 20;
            Walls = 0;
            Ants = 1;
            Size = 30;
            Base.X = 0;
            Base.Y = 0;
            Food.X = 0;
            Food.Y = 0;
        }
    }
}
