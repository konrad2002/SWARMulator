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
    public partial class formSettings : Form
    {
        public formSettings()
        {
            InitializeComponent();
            new Settings();
            new Ant();
            trackBarWidth.Value = Settings.Width;
            settingsWidth.Text = Settings.Width.ToString();
            trackBarHeight.Value = Settings.Height;
            settingsHeight.Text = Settings.Height.ToString();
            trackBarWalls.Value = Settings.Walls;
            settingsWalls.Text = Settings.Walls.ToString();
            trackBarAnts.Value = Settings.Ants;
            settingsAnts.Text = Settings.Ants.ToString();
            settingsHits.Checked = Settings.ShowHits;
            settingsColor.Checked = Settings.ColorHits;
        }

        public void SetMaxWalls()
        {
            trackBarWalls.Maximum = trackBarWidth.Value * trackBarHeight.Value / 9;
        }

        private void trackBarWidth_Scroll(object sender, EventArgs e)
        {
            settingsWidth.Text = trackBarWidth.Value.ToString();
            SetMaxWalls();
        }

        private void trackBarHeight_Scroll(object sender, EventArgs e)
        {
            settingsHeight.Text = trackBarHeight.Value.ToString();
            SetMaxWalls();
        }

        private void trackBarWalls_Scroll(object sender, EventArgs e)
        {
            settingsWalls.Text = trackBarWalls.Value.ToString();
            SetMaxWalls();
        }

        private void trackBarAnts_Scroll(object sender, EventArgs e)
        {
            settingsAnts.Text = trackBarAnts.Value.ToString();
        }

        private void settingsSave_Click(object sender, EventArgs e)
        {
            Settings.Width = trackBarWidth.Value;
            Settings.Height = trackBarHeight.Value;
            Settings.Walls = trackBarWalls.Value;
            Settings.Ants = trackBarAnts.Value;
            Settings.ShowHits = settingsHits.Checked;
            Settings.ColorHits = settingsColor.Checked;
            Ant.NumOfAnts = 0;
            Ant.AntList = new int[Settings.Ants,4];
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
