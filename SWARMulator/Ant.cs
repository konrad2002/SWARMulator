using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWARMulator
{
    class Ant
    {
        public void Spawn()
        {
            new Settings();
            new Settings.Base();

            int x = Settings.Base.X;
            int y = Settings.Base.Y;
        }
    }
}
