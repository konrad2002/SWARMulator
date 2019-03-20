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
            trackBarWidth.Value = Settings.Width;
            settingsWidth.Text = Settings.Width.ToString();
            trackBarHeight.Value = Settings.Height;
            settingsHeight.Text = Settings.Height.ToString();
            trackBarWalls.Value = Settings.Walls;
            settingsWalls.Text = Settings.Walls.ToString();
            trackBarAnts.Value = Settings.Ants;
            settingsAnts.Text = Settings.Ants.ToString();
        }

        private void trackBarWidth_Scroll(object sender, EventArgs e)
        {
            settingsWidth.Text = trackBarWidth.Value.ToString();
        }

        private void trackBarHeight_Scroll(object sender, EventArgs e)
        {
            settingsHeight.Text = trackBarHeight.Value.ToString();
        }

        private void trackBarWalls_Scroll(object sender, EventArgs e)
        {
            settingsWalls.Text = trackBarWalls.Value.ToString();
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

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
