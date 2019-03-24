using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWARMulator
{
    class Ant
    {
        public static int[,] AntList { get; set; }
        public static int NumOfAnts { get; set; }
        public static int NumOfFinishers { get; set; }
        public static int NumOfLivings { get; set; }

        static Random random = new Random();

        public Ant()
        {
            new Settings();
        }

        public int Spawn()
        {
            if (NumOfAnts < Settings.Ants)
            {
                AntList[NumOfAnts,0] = NumOfAnts + 1;
                
                AntList[NumOfAnts, 1] = random.Next(Settings.Base.X, Settings.Base.X + 3);
                AntList[NumOfAnts, 2] = random.Next(Settings.Base.Y, Settings.Base.Y + 3);
                NumOfAnts = NumOfAnts + 1;
                Console.WriteLine("Spawning Ant " + NumOfAnts + " ...");
                return 0;
            } else
            {
                Console.WriteLine("get max number of ants! " + NumOfAnts + " / " + Settings.Ants);
                return 1;
            }
        }
    }
}
