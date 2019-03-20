using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWARMulator
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            new Settings();
            new Settings.Base();
            new Settings.Food();
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSettings form = new formSettings();
            form.Show();
        }

        private void simulationArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);

            int cells;
            if (Settings.Width > Settings.Height)
            {
                cells = Settings.Width + 1;
            } else
            {
                cells = Settings.Height + 1;
            }

            int cellSize = Settings.Size;

            for (int y = 0; y < cells; ++y)
            {
                g.DrawLine(p, 0, y * cellSize, cells * cellSize, y * cellSize);
            }

            for (int x = 0; x < cells; ++x)
            {
                g.DrawLine(p, x * cellSize, 0, x * cellSize, cells * cellSize);
            }

            cells = 3;
            int i = 4;
            cellSize = Settings.Size;
            p = new Pen(Color.Black, 3);
            int x1;
            int x2;
            int y1;
            int y2;

            //waagerecht
            for (int y = Settings.Base.Y; y < (i + Settings.Base.Y); ++y)
            {
                Console.WriteLine("y: " + y.ToString());
                x1 = Settings.Base.X;
                x2 = Settings.Base.X + cells;
                y1 = y;
                y2 = y;
                g.DrawLine(p, x1 * cellSize, y1 * cellSize, x2 * cellSize, y2 * cellSize);
            }
            
            //senkrecht
            for (int x = Settings.Base.X; x < (i + Settings.Base.X); ++x)
            {
                Console.WriteLine("x: " + x.ToString());
                x1 = x;
                x2 = x;
                y1 = Settings.Base.Y;
                y2 = Settings.Base.Y + cells;
                g.DrawLine(p, x1 * cellSize, y1 * cellSize, x2 * cellSize, y2 * cellSize);
            }
            Console.WriteLine("-----------------------");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Settings.Base.X = random.Next(1, Settings.Width - 2);
            Settings.Base.Y = random.Next(1, Settings.Height - 2);

            settingsWidth.Text = Settings.Width.ToString();
            settingsHeight.Text = Settings.Height.ToString();
            settingsWalls.Text = Settings.Walls.ToString();
            settingsAnts.Text = Settings.Ants.ToString();
            settingsBase.Text = "( " + Settings.Base.X.ToString() + " | " + Settings.Base.Y.ToString() + " )";
            settingsFood.Text = "( " + Settings.Food.X.ToString() + " | " + Settings.Food.Y.ToString() + " )";

            simulationArea.Width = Settings.Width * Settings.Size + 1;
            simulationArea.Height = Settings.Height * Settings.Size + 1;

            sidebar.Left = Settings.Width * Settings.Size + 20;

            this.Width = Settings.Width * Settings.Size + 300;
            this.Height = Settings.Height * Settings.Size + 85;

            simulationArea.Refresh();
        }
    }
}
