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
            Settings.ShowHits = false;
            Settings.ColorHits = true;
            
            Ant.NumOfAnts = 0;
            Ant.NumOfFinishers = 0;
            Ant.AntList = new int[Settings.Ants,4];

            FieldUses = new int[100000, 3];
            Fields = 0;
            Secounds = 0;

            Walls = new int[Settings.Walls, 2];
        }

        public static int[,] FieldUses { get; set; }
        public static int[,] Walls { get; set; }
        public static int Fields { get; set; }
        public static int Secounds { get; set; }
        public static int Minutes { get; set; }

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
            Ant.NumOfFinishers = 0;
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

            FieldUses = new int[100000, 3];
            Walls = new int[Settings.Walls, 2];
            Secounds = 0;
            Minutes = 0;
            Settings.Time = 0;
            Settings.Running = false;

            Fields = Settings.Width * Settings.Height;
            FieldUses[0, 0] = 0;
            FieldUses[0, 1] = 0;
            FieldUses[0, 2] = 0;

            int i = 1;
            // count x and y
            int cx = 1;
            int cy = 1;

            while (i <= Fields)
            {
                FieldUses[i, 0] = cx;
                FieldUses[i, 1] = cy;
                FieldUses[i, 2] = 0;

                if (cx >= Settings.Width)
                {
                    cx = 1;
                    cy++;
                } else
                {
                    cx++;
                }

                i++;
            }

            simulationArea.Refresh();
        }

        static Random random = new Random();

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSettings form = new formSettings();
            form.Show();
        }

        // executed from timer
        private void simulationArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);

            // draw grid
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

            // mark fields
            Color c = Color.FromArgb(50, 0, 110, 255);
            SolidBrush sb = new SolidBrush(c);
            int j = 1;
            int fx = 0;
            int fy = 0;
            int fu = 0;
            int tr = 0;

            //color each fields
            if (Settings.Running && Ant.NumOfAnts > 0)
            {
                while (j <= Fields)
                {
                    fx = FieldUses[j, 0];
                    fy = FieldUses[j, 1];
                    fu = FieldUses[j, 2];

                    if (Settings.ColorHits)
                    {
                        tr = fu * 100 / Ant.NumOfAnts;
                        if (tr > 255)
                        {
                            tr = 255;
                        }

                        c = Color.FromArgb(tr, 0, 110, 255);
                        sb = new SolidBrush(c);
                        e.Graphics.FillRectangle(sb, (fx * 30) - 30, (fy * 30) - 30, 30, 30);
                    }

                    if (Settings.ShowHits)
                    {
                        Font font = new Font("Arial", 8);
                        e.Graphics.DrawString(fu.ToString(), font, Brushes.Black, new Point((fx * 30) - 30, (fy * 30) - 30));
                    }

                    j++;
                }
            }

            // draw walls
            if (Settings.Walls > 0)
            {
                int i = 0;
                int wx = 0;
                int wy = 0;
                while (i <= Settings.Walls)
                {
                    wx = Walls[i, 0];
                    wy = Walls[i, 1];

                    c = Color.FromArgb(255, 255, 0, 0);
                    sb = new SolidBrush(c);
                    e.Graphics.FillRectangle(sb, (wx * 30) - 30, (wy * 30) - 30, 30, 30);

                    i++;
                }
            }

            // draw Base
            c = Color.FromArgb(255, 255, 195, 0);
            sb = new SolidBrush(c);

            e.Graphics.FillRectangle(sb, (Settings.Base.X * 30) - 30, (Settings.Base.Y * 30) - 30, 90, 90);
            e.Graphics.DrawRectangle(p, (Settings.Base.X * 30) - 30, (Settings.Base.Y * 30) - 30, 90, 90);
            e.Graphics.FillEllipse(Brushes.White, (Settings.Base.X * 30) - 15, (Settings.Base.Y * 30) - 15, 60, 60);
            g.DrawLine(p, (Settings.Base.X * 30), (Settings.Base.Y * 30) + 20, (Settings.Base.X * 30) + 16, (Settings.Base.Y * 30) + 5);
            g.DrawLine(p, (Settings.Base.X * 30) + 30, (Settings.Base.Y * 30) + 20, (Settings.Base.X * 30) + 14, (Settings.Base.Y * 30) + 5);

            // draw Food
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
            int field = 0;

            while (i1 > n)
            {
                ax = Ant.AntList[n, 1];
                ay = Ant.AntList[n, 2];
                ad = Ant.AntList[n, 3];
                Console.WriteLine(ad);

                // add field hit counter +1
                if (ax != 0 && ay != 0)
                {
                    field = (ay * Settings.Width) - (Settings.Width - ax);
                    FieldUses[field, 2]++;
                }

                // Mark field

                //if (!(ax >= Settings.Base.X && ax < Settings.Base.X + 3 && ay >= Settings.Base.Y && ay < Settings.Base.Y + 3))
                //{
                //    c = Color.FromArgb(50, 0, 110, 255);
                //    sb = new SolidBrush(c);
                //    e.Graphics.FillRectangle(sb, (ax * 30) - 30, (ay * 30) - 30, 30, 30);
                //}


                // if at food
                if (ax >= Settings.Food.X && ax < Settings.Food.X + 3 && ay >= Settings.Food.Y && ay < Settings.Food.Y + 3)
                {
                    Ant.AntList[n, 1] = 0;
                    Ant.AntList[n, 2] = 0;
                    Ant.AntList[n, 3] = 0;
                    ax = ay = 0;
                    Ant.NumOfFinishers++;
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
            if (Settings.Running)
            {
                simulationArea.Refresh();
                Ant.NumOfLivings = Ant.NumOfAnts - Ant.NumOfFinishers;
                if (Ant.NumOfLivings == 0 && Ant.NumOfAnts > 0)
                {
                    Ant.NumOfAnts = 0;
                    int points = ((Settings.Width * Settings.Height) / Settings.Time) * 100;
                    Secounds = 0;
                    Minutes = 0;
                    Settings.Time = 0;
                    Settings.Running = false;
                    Time.Text = "Zeit: 00:00";
                    btnStart.Text = "Simulation starten";
                    MessageBox.Show("Alle Ameisen haben das Ziel erreicht! Punktzahl: " + points.ToString(), "Alle Ameisen im Ziel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenerateMap();
                }
                settingsAnts.Text = Ant.NumOfLivings.ToString() + " / " + Settings.Ants.ToString();
            }
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

        private void clock_Tick(object sender, EventArgs e)
        {
            string Display1 = "";
            string Display2 = "";
            if (Settings.Running)
            {
                Settings.Time++;
                Secounds++;

                if (Secounds >= 60)
                {
                    Minutes++;
                    Secounds = 0;
                }

                if (Secounds < 10)
                {
                    Display1 = "0" + Secounds.ToString();
                } else
                {
                    Display1 = Secounds.ToString();
                }

                if (Minutes < 10)
                {
                    Display2 = "0" + Minutes.ToString();
                }
                else
                {
                    Display2 = Minutes.ToString();
                }

                Time.Text = "Zeit: " + Display2 + ":" + Display1;
            }
        }

        private void landschaftGenerierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateMap();
        }

        private void startenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Running)
            {
                btnStart.Text = "Simulation starten";
                Settings.Running = false;
            }
            else
            {
                btnStart.Text = "Simulation stoppen";
                Settings.Running = true;
            }
        }

        private void ameisenErzeugenToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void simulationArea_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            int clickX = coordinates.X / 30 + 1;
            int clickY = coordinates.Y / 30 + 1;
            MessageBox.Show("( " + clickX.ToString() + " | " + clickY.ToString() + " )");
        }
    }
}
