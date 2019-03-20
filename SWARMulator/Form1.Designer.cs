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
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationArea = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.loadSettings = new System.Windows.Forms.Button();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelAnts = new System.Windows.Forms.Label();
            this.labelWalls = new System.Windows.Forms.Label();
            this.settingsWidth = new System.Windows.Forms.Label();
            this.settingsAnts = new System.Windows.Forms.Label();
            this.settingsWalls = new System.Windows.Forms.Label();
            this.settingsHeight = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            this.mainMenu.Size = new System.Drawing.Size(836, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.dateiToolStripMenuItem.Text = "Datei";
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
            this.simulationArea.Name = "simulationArea";
            this.simulationArea.Size = new System.Drawing.Size(500, 500);
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
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(198, 36);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Simulation starten";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // loadSettings
            // 
            this.loadSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadSettings.ForeColor = System.Drawing.Color.White;
            this.loadSettings.Location = new System.Drawing.Point(45, 76);
            this.loadSettings.Name = "loadSettings";
            this.loadSettings.Size = new System.Drawing.Size(198, 36);
            this.loadSettings.TabIndex = 3;
            this.loadSettings.Text = "Einstellungen übernehmen";
            this.loadSettings.UseVisualStyleBackColor = false;
            this.loadSettings.Click += new System.EventHandler(this.loadSettings_Click);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(42, 138);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(49, 17);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "Breite:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(42, 164);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(46, 17);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "Höhe:";
            // 
            // labelAnts
            // 
            this.labelAnts.AutoSize = true;
            this.labelAnts.Location = new System.Drawing.Point(42, 216);
            this.labelAnts.Name = "labelAnts";
            this.labelAnts.Size = new System.Drawing.Size(66, 17);
            this.labelAnts.TabIndex = 7;
            this.labelAnts.Text = "Ameisen:";
            // 
            // labelWalls
            // 
            this.labelWalls.AutoSize = true;
            this.labelWalls.Location = new System.Drawing.Point(42, 190);
            this.labelWalls.Name = "labelWalls";
            this.labelWalls.Size = new System.Drawing.Size(60, 17);
            this.labelWalls.TabIndex = 6;
            this.labelWalls.Text = "Mauern:";
            // 
            // settingsWidth
            // 
            this.settingsWidth.AutoSize = true;
            this.settingsWidth.Location = new System.Drawing.Point(120, 138);
            this.settingsWidth.Name = "settingsWidth";
            this.settingsWidth.Size = new System.Drawing.Size(16, 17);
            this.settingsWidth.TabIndex = 8;
            this.settingsWidth.Text = "0";
            // 
            // settingsAnts
            // 
            this.settingsAnts.AutoSize = true;
            this.settingsAnts.Location = new System.Drawing.Point(120, 216);
            this.settingsAnts.Name = "settingsAnts";
            this.settingsAnts.Size = new System.Drawing.Size(16, 17);
            this.settingsAnts.TabIndex = 9;
            this.settingsAnts.Text = "0";
            // 
            // settingsWalls
            // 
            this.settingsWalls.AutoSize = true;
            this.settingsWalls.Location = new System.Drawing.Point(120, 190);
            this.settingsWalls.Name = "settingsWalls";
            this.settingsWalls.Size = new System.Drawing.Size(16, 17);
            this.settingsWalls.TabIndex = 10;
            this.settingsWalls.Text = "0";
            // 
            // settingsHeight
            // 
            this.settingsHeight.AutoSize = true;
            this.settingsHeight.Location = new System.Drawing.Point(120, 164);
            this.settingsHeight.Name = "settingsHeight";
            this.settingsHeight.Size = new System.Drawing.Size(16, 17);
            this.settingsHeight.TabIndex = 11;
            this.settingsHeight.Text = "0";
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.btnStart);
            this.sidebar.Controls.Add(this.settingsHeight);
            this.sidebar.Controls.Add(this.loadSettings);
            this.sidebar.Controls.Add(this.settingsWalls);
            this.sidebar.Controls.Add(this.labelWidth);
            this.sidebar.Controls.Add(this.settingsAnts);
            this.sidebar.Controls.Add(this.labelHeight);
            this.sidebar.Controls.Add(this.settingsWidth);
            this.sidebar.Controls.Add(this.labelWalls);
            this.sidebar.Controls.Add(this.labelAnts);
            this.sidebar.Location = new System.Drawing.Point(535, 42);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(274, 252);
            this.sidebar.TabIndex = 12;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(836, 557);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.simulationArea);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "main";
            this.Text = "SWARMulator";
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
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button loadSettings;
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
    }
}

