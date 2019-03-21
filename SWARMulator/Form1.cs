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
            new Ant();


            Settings.Width = 20;
            Settings.Height = 20;
            Settings.Walls = 0;
            Settings.Ants = 5;
            Settings.Size = 30;
            Settings.Base.X = 1;
            Settings.Base.Y = 1;
            Settings.Food.X = 1;
            Settings.Food.Y = 1;
            Settings.Running = false;
            
            Ant.NumOfAnts = 0;
            Ant.AntList = new int[Settings.Ants,4];
        }

        static Random random = new Random();

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
                //set koords
                x1 = Settings.Base.X;
                x2 = Settings.Base.X + cells;
                y1 = y;
                y2 = y;
                //multiply with field size
                x1 = x1 * cellSize;
                x2 = x2 * cellSize;
                y1 = y1 * cellSize;
                y2 = y2 * cellSize;
                //remove one size
                x1 = x1 - cellSize;
                x2 = x2 - cellSize;
                y1 = y1 - cellSize;
                y2 = y2 - cellSize;

                g.DrawLine(p, x1, y1, x2, y2);
            }
            
            //senkrecht
            for (int x = Settings.Base.X; x < (i + Settings.Base.X); ++x)
            {
                //set koords
                x1 = x;
                x2 = x;
                y1 = Settings.Base.Y;
                y2 = Settings.Base.Y + cells;
                //multiply with field size
                x1 = x1 * cellSize;
                x2 = x2 * cellSize;
                y1 = y1 * cellSize;
                y2 = y2 * cellSize;
                //remove one size
                x1 = x1 - cellSize;
                x2 = x2 - cellSize;
                y1 = y1 - cellSize;
                y2 = y2 - cellSize;

                g.DrawLine(p, x1, y1, x2, y2);
            }

            AntListBox.Items.Clear();
            int i1 = Ant.NumOfAnts;
            int n = 0;
            int ax;
            int ay;
            int ad;

            while (i1 > n)
            {
                ax = Ant.AntList[n, 1];
                ay = Ant.AntList[n, 2];
                ad = Ant.AntList[n, 3];
                Console.WriteLine(ad);
                n = Ant.AntList[n, 0];

                AntListBox.Items.Add(n.ToString() + ": ( " + ax.ToString() + " | " + ay.ToString() + " )");
                e.Graphics.FillEllipse(Brushes.Black, (ax * 30) - 25, (ay * 30) - 25, 20, 20);

                if (Settings.Running)
                {
                    //choose new direction
                    int NumOfDirections = 0;
                    bool R = false;
                    bool L = false;
                    bool D = false;
                    bool U = false;

                    if (ax < Settings.Width && ad != 2)
                    {
                        NumOfDirections++;
                        R = true;
                    }
                    if (ax > 1 && ad != 1)
                    {
                        NumOfDirections++;
                        L = true;
                    }
                    if (ay < Settings.Height && ad != 4)
                    {
                        NumOfDirections++;
                        D = true;
                    }
                    if (ay > 1 && ad != 3)
                    {
                        NumOfDirections++;
                        U = true;
                    }

                    List<string> directions = new List<string>();

                    if (R) directions.Add("R");
                    if (L) directions.Add("L");
                    if (D) directions.Add("D");
                    if (U) directions.Add("U");

                    string[] directionsList = directions.ToArray();


                    
                    int rnd = random.Next(0, NumOfDirections);

                    string direc = directionsList[rnd];

                    if (direc == "R")
                    {
                        Ant.AntList[n - 1, 1]++;
                        Ant.AntList[n - 1, 3] = 1;
                    }
                    if (direc == "L")
                    {
                        Ant.AntList[n - 1, 1]--;
                        Ant.AntList[n - 1, 3] = 2;
                    }
                    if (direc == "D")
                    {
                        Ant.AntList[n - 1, 2]++;
                        Ant.AntList[n - 1, 3] = 3;
                    }
                    if (direc == "U")
                    {
                        Ant.AntList[n - 1, 2]--;
                        Ant.AntList[n - 1, 3] = 4;
                    }
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Settings.Base.X = random.Next(1, Settings.Width - 1);
            Settings.Base.Y = random.Next(1, Settings.Height - 1);

            Ant.NumOfAnts = 0;
            Ant.AntList = new int[Settings.Ants,4];

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

        }

        private void SpawnAnt_Click(object sender, EventArgs e)
        {
            Ant A1 = new Ant();
            int spawn = A1.Spawn();
            if (spawn == 1)
            {
                MessageBox.Show("Die maximale Anzahl an Ameisen wurde erreicht!", "Maximale Ameisen-Anzahl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            simulationArea.Refresh();
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            if (Settings.Running)
            {
                btnStart.Text = "Simulation starten";
                Settings.Running = false;
            } else
            {
                btnStart.Text = "Simulation stoppen";
                Settings.Running = true;
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
