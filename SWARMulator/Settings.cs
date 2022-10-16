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
        public static bool Running { get; set; }
        public static int Time { get; set; }
        public static int Steps { get; set; }
        public static bool ShowHits { get; set; }
        public static bool ColorHits { get; set; }
        public static bool SetCoords { get; set; }

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

        public void Reset()
        {

        }

        public Settings()
        {
        }
    }
}
