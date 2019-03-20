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

        public Ant()
        {
            new Settings();
        }

        public string Spawn()
        {
            if (NumOfAnts < Settings.Ants)
            {
                AntList[NumOfAnts,0] = NumOfAnts + 1;

                Random random = new Random();
                AntList[NumOfAnts, 1] = random.Next(Settings.Base.X, Settings.Base.X + 3);
                AntList[NumOfAnts, 2] = random.Next(Settings.Base.Y, Settings.Base.Y + 3);
                NumOfAnts = NumOfAnts + 1;
                return "Spawning Ant " + NumOfAnts + " ...";
            } else
            {
                return "get max number of ants! " + NumOfAnts + " / " + Settings.Ants;
            }
        }
    }
}
