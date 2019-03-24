namespace SWARMulator
{
    partial class main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationArea = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelAnts = new System.Windows.Forms.Label();
            this.labelWalls = new System.Windows.Forms.Label();
            this.settingsWidth = new System.Windows.Forms.Label();
            this.settingsAnts = new System.Windows.Forms.Label();
            this.settingsWalls = new System.Windows.Forms.Label();
            this.settingsHeight = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.Panel();
            this.SpawnAllAnts = new System.Windows.Forms.Button();
            this.AntListBox = new System.Windows.Forms.ListBox();
            this.SpawnAnt = new System.Windows.Forms.Button();
            this.settingsBase = new System.Windows.Forms.Label();
            this.settingsFood = new System.Windows.Forms.Label();
            this.labelBase = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulationArea)).BeginInit();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1020, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // simulationArea
            // 
            this.simulationArea.BackColor = System.Drawing.Color.White;
            this.simulationArea.Location = new System.Drawing.Point(12, 42);
            this.simulationArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simulationArea.Name = "simulationArea";
            this.simulationArea.Size = new System.Drawing.Size(500, 561);
            this.simulationArea.TabIndex = 1;
            this.simulationArea.TabStop = false;
            this.simulationArea.Paint += new System.Windows.Forms.PaintEventHandler(this.simulationArea_Paint);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(45, 20);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(197, 36);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Simulation starten";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(45, 60);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(197, 36);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Landschaft generieren";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(53, 106);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(49, 17);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "Breite:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(53, 132);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(46, 17);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "Höhe:";
            // 
            // labelAnts
            // 
            this.labelAnts.AutoSize = true;
            this.labelAnts.Location = new System.Drawing.Point(53, 185);
            this.labelAnts.Name = "labelAnts";
            this.labelAnts.Size = new System.Drawing.Size(66, 17);
            this.labelAnts.TabIndex = 7;
            this.labelAnts.Text = "Ameisen:";
            // 
            // labelWalls
            // 
            this.labelWalls.AutoSize = true;
            this.labelWalls.Location = new System.Drawing.Point(53, 158);
            this.labelWalls.Name = "labelWalls";
            this.labelWalls.Size = new System.Drawing.Size(60, 17);
            this.labelWalls.TabIndex = 6;
            this.labelWalls.Text = "Mauern:";
            // 
            // settingsWidth
            // 
            this.settingsWidth.AutoSize = true;
            this.settingsWidth.Location = new System.Drawing.Point(172, 106);
            this.settingsWidth.Name = "settingsWidth";
            this.settingsWidth.Size = new System.Drawing.Size(16, 17);
            this.settingsWidth.TabIndex = 8;
            this.settingsWidth.Text = "0";
            // 
            // settingsAnts
            // 
            this.settingsAnts.AutoSize = true;
            this.settingsAnts.Location = new System.Drawing.Point(172, 185);
            this.settingsAnts.Name = "settingsAnts";
            this.settingsAnts.Size = new System.Drawing.Size(16, 17);
            this.settingsAnts.TabIndex = 9;
            this.settingsAnts.Text = "0";
            // 
            // settingsWalls
            // 
            this.settingsWalls.AutoSize = true;
            this.settingsWalls.Location = new System.Drawing.Point(172, 158);
            this.settingsWalls.Name = "settingsWalls";
            this.settingsWalls.Size = new System.Drawing.Size(16, 17);
            this.settingsWalls.TabIndex = 10;
            this.settingsWalls.Text = "0";
            // 
            // settingsHeight
            // 
            this.settingsHeight.AutoSize = true;
            this.settingsHeight.Location = new System.Drawing.Point(172, 132);
            this.settingsHeight.Name = "settingsHeight";
            this.settingsHeight.Size = new System.Drawing.Size(16, 17);
            this.settingsHeight.TabIndex = 11;
            this.settingsHeight.Text = "0";
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.Time);
            this.sidebar.Controls.Add(this.SpawnAllAnts);
            this.sidebar.Controls.Add(this.AntListBox);
            this.sidebar.Controls.Add(this.SpawnAnt);
            this.sidebar.Controls.Add(this.settingsBase);
            this.sidebar.Controls.Add(this.settingsFood);
            this.sidebar.Controls.Add(this.labelBase);
            this.sidebar.Controls.Add(this.labelFood);
            this.sidebar.Controls.Add(this.btnStart);
            this.sidebar.Controls.Add(this.settingsHeight);
            this.sidebar.Controls.Add(this.btnGenerate);
            this.sidebar.Controls.Add(this.settingsWalls);
            this.sidebar.Controls.Add(this.labelWidth);
            this.sidebar.Controls.Add(this.settingsAnts);
            this.sidebar.Controls.Add(this.labelHeight);
            this.sidebar.Controls.Add(this.settingsWidth);
            this.sidebar.Controls.Add(this.labelWalls);
            this.sidebar.Controls.Add(this.labelAnts);
            this.sidebar.Location = new System.Drawing.Point(535, 42);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(414, 561);
            this.sidebar.TabIndex = 12;
            // 
            // SpawnAllAnts
            // 
            this.SpawnAllAnts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpawnAllAnts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpawnAllAnts.ForeColor = System.Drawing.Color.White;
            this.SpawnAllAnts.Location = new System.Drawing.Point(44, 287);
            this.SpawnAllAnts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpawnAllAnts.Name = "SpawnAllAnts";
            this.SpawnAllAnts.Size = new System.Drawing.Size(197, 36);
            this.SpawnAllAnts.TabIndex = 19;
            this.SpawnAllAnts.Text = "Alle Ameisen erzeugen";
            this.SpawnAllAnts.UseVisualStyleBackColor = false;
            this.SpawnAllAnts.Click += new System.EventHandler(this.SpawnAllAnts_Click);
            // 
            // AntListBox
            // 
            this.AntListBox.FormattingEnabled = true;
            this.AntListBox.ItemHeight = 16;
            this.AntListBox.Items.AddRange(new object[] {
            "1 ( 1 | 1 )"});
            this.AntListBox.Location = new System.Drawing.Point(249, 22);
            this.AntListBox.Margin = new System.Windows.Forms.Padding(4);
            this.AntListBox.Name = "AntListBox";
            this.AntListBox.Size = new System.Drawing.Size(126, 340);
            this.AntListBox.TabIndex = 18;
            // 
            // SpawnAnt
            // 
            this.SpawnAnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpawnAnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpawnAnt.ForeColor = System.Drawing.Color.White;
            this.SpawnAnt.Location = new System.Drawing.Point(45, 327);
            this.SpawnAnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpawnAnt.Name = "SpawnAnt";
            this.SpawnAnt.Size = new System.Drawing.Size(197, 36);
            this.SpawnAnt.TabIndex = 16;
            this.SpawnAnt.Text = "Ameise erzeugen";
            this.SpawnAnt.UseVisualStyleBackColor = false;
            this.SpawnAnt.Click += new System.EventHandler(this.SpawnAnt_Click);
            // 
            // settingsBase
            // 
            this.settingsBase.AutoSize = true;
            this.settingsBase.Location = new System.Drawing.Point(172, 225);
            this.settingsBase.Name = "settingsBase";
            this.settingsBase.Size = new System.Drawing.Size(16, 17);
            this.settingsBase.TabIndex = 15;
            this.settingsBase.Text = "0";
            // 
            // settingsFood
            // 
            this.settingsFood.AutoSize = true;
            this.settingsFood.Location = new System.Drawing.Point(172, 252);
            this.settingsFood.Name = "settingsFood";
            this.settingsFood.Size = new System.Drawing.Size(16, 17);
            this.settingsFood.TabIndex = 14;
            this.settingsFood.Text = "0";
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(53, 225);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(110, 17);
            this.labelBase.TabIndex = 12;
            this.labelBase.Text = "Ameisenhaufen:";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Location = new System.Drawing.Point(53, 252);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(49, 17);
            this.labelFood.TabIndex = 13;
            this.labelFood.Text = "Futter:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(41, 1);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(76, 17);
            this.Time.TabIndex = 20;
            this.Time.Text = "Zeit: 00:00";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1020, 617);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.simulationArea);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "main";
            this.Text = "SWARMulator";
            this.Load += new System.EventHandler(this.main_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulationArea)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.PictureBox simulationArea;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelAnts;
        private System.Windows.Forms.Label labelWalls;
        private System.Windows.Forms.Label settingsWidth;
        private System.Windows.Forms.Label settingsAnts;
        private System.Windows.Forms.Label settingsWalls;
        private System.Windows.Forms.Label settingsHeight;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label settingsBase;
        private System.Windows.Forms.Label settingsFood;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Button SpawnAnt;
        private System.Windows.Forms.ListBox AntListBox;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Button SpawnAllAnts;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Label Time;
    }
}

