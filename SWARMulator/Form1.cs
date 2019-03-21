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

        public void GenerateMap()
        {
            Settings.Base.X = random.Next(1, Settings.Width - 1);
            Settings.Base.Y = random.Next(1, Settings.Height - 1);

            GenFood:
            bool error = false;
            int fx = 0;
            int fy = 0;
            fx = random.Next(1, Settings.Width - 1);
            fy = random.Next(1, Settings.Height - 1);
            if (fx > (Settings.Base.X - 4) && fx < (Settings.Base.X + 4))
            {
                error = true;
            }

            if (fy > (Settings.Base.Y - 4) && fy < (Settings.Base.Y + 4))
            {
                error = true;
            }

            if (error)
            {
                goto GenFood;
            } else
            {
                Settings.Food.X = fx;
                Settings.Food.Y = fy;
            }

            Ant.NumOfAnts = 0;
            Ant.AntList = new int[Settings.Ants, 4];

            settingsWidth.Text = Settings.Width.ToString();
            settingsHeight.Text = Settings.Height.ToString();
            settingsWalls.Text = Settings.Walls.ToString();
            settingsAnts.Text = "0 / " + Settings.Ants.ToString();
            settingsBase.Text = "( " + Settings.Base.X.ToString() + " | " + Settings.Base.Y.ToString() + " )";
            settingsFood.Text = "( " + Settings.Food.X.ToString() + " | " + Settings.Food.Y.ToString() + " )";

            simulationArea.Width = Settings.Width * Settings.Size + 1;
            simulationArea.Height = Settings.Height * Settings.Size + 1;

            sidebar.Left = Settings.Width * Settings.Size + 20;

            AntListBox.Height = Settings.Ants * 15;
            sidebar.Height = Settings.Ants * 15 + 450;

            this.Width = Settings.Width * Settings.Size + 300;
            this.Height = Settings.Height * Settings.Size + 85;
            AntListBox.Items.Clear();
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
            
            p = new Pen(Color.Black, 5);

            // Draw Base
            Color c = Color.FromArgb(255, 255, 195, 0);
            SolidBrush sb = new SolidBrush(c);

            e.Graphics.FillRectangle(sb, (Settings.Base.X * 30) - 30, (Settings.Base.Y * 30) - 30, 90, 90);
            e.Graphics.DrawRectangle(p, (Settings.Base.X * 30) - 30, (Settings.Base.Y * 30) - 30, 90, 90);
            e.Graphics.FillEllipse(Brushes.White, (Settings.Base.X * 30) - 15, (Settings.Base.Y * 30) - 15, 60, 60);
            g.DrawLine(p, (Settings.Base.X * 30), (Settings.Base.Y * 30) + 20, (Settings.Base.X * 30) + 16, (Settings.Base.Y * 30) + 5);
            g.DrawLine(p, (Settings.Base.X * 30) + 30, (Settings.Base.Y * 30) + 20, (Settings.Base.X * 30) + 14, (Settings.Base.Y * 30) + 5);

            // Draw Food
            c = Color.FromArgb(255, 127, 255, 0);
            sb = new SolidBrush(c);

            e.Graphics.FillRectangle(sb, (Settings.Food.X * 30) - 30, (Settings.Food.Y * 30) - 30, 90, 90);
            e.Graphics.DrawRectangle(p, (Settings.Food.X * 30) - 30, (Settings.Food.Y * 30) - 30, 90, 90);
            e.Graphics.FillEllipse(Brushes.White, (Settings.Food.X * 30) - 15, (Settings.Food.Y * 30) - 15, 60, 60);
            g.DrawLine(p, (Settings.Food.X * 30), (Settings.Food.Y * 30), (Settings.Food.X * 30), (Settings.Food.Y * 30) + 30);
            g.DrawLine(p, (Settings.Food.X * 30) + 15, (Settings.Food.Y * 30), (Settings.Food.X * 30) + 15, (Settings.Food.Y * 30) + 30);
            g.DrawLine(p, (Settings.Food.X * 30) + 30, (Settings.Food.Y * 30), (Settings.Food.X * 30) + 30, (Settings.Food.Y * 30) + 30);

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

                // if at food
                if (ax >= Settings.Food.X && ax < Settings.Food.X + 3 && ay >= Settings.Food.Y && ay < Settings.Food.Y + 3)
                {
                    Ant.AntList[n, 1] = 0;
                    Ant.AntList[n, 2] = 0;
                    Ant.AntList[n, 3] = 0;
                    ax = ay = 0;
                }

                n = Ant.AntList[n, 0];

                int items = AntListBox.Items.Count;

                if (items < n)
                {
                    AntListBox.Items.Add(n.ToString() + ": ( " + ax.ToString() + " | " + ay.ToString() + " )");
                } else
                {
                    if (ax != 0 && ay != 0)
                    {
                        AntListBox.Items[n - 1] = (n.ToString() + ": ( " + ax.ToString() + " | " + ay.ToString() + " )");
                    } else
                    {
                        AntListBox.Items[n - 1] = (n.ToString() + ": am Ziel!");
                    }
                }

                e.Graphics.FillEllipse(Brushes.Black, (ax * 30) - 25, (ay * 30) - 25, 20, 20);

                if (Settings.Running && ax != 0 && ay != 0)
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
            GenerateMap();
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
            settingsAnts.Text = Ant.NumOfAnts.ToString() + " / " + Settings.Ants.ToString();
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

        private void main_Load(object sender, EventArgs e)
        {
            GenerateMap();
        }

        private void SpawnAllAnts_Click(object sender, EventArgs e)
        {
            int i = Ant.NumOfAnts;
            int j = Settings.Ants;

            while (i < j)
            {
                Ant A1 = new Ant();
                A1.Spawn();
                i++;
            }
        }
    }
}
