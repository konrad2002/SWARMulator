namespace SWARMulator
{
    partial class formSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settingsHeight = new System.Windows.Forms.TextBox();
            this.settingsWidth = new System.Windows.Forms.TextBox();
            this.trackBarHeight = new System.Windows.Forms.TrackBar();
            this.trackBarWidth = new System.Windows.Forms.TrackBar();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.settingsSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.settingsAnts = new System.Windows.Forms.TextBox();
            this.settingsWalls = new System.Windows.Forms.TextBox();
            this.labelWalls = new System.Windows.Forms.Label();
            this.trackBarAnts = new System.Windows.Forms.TrackBar();
            this.labelAnts = new System.Windows.Forms.Label();
            this.trackBarWalls = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.settingsColor = new System.Windows.Forms.CheckBox();
            this.settingsHits = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWalls)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.settingsHeight);
            this.groupBox1.Controls.Add(this.settingsWidth);
            this.groupBox1.Controls.Add(this.trackBarHeight);
            this.groupBox1.Controls.Add(this.trackBarWidth);
            this.groupBox1.Controls.Add(this.labelHeight);
            this.groupBox1.Controls.Add(this.labelWidth);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(404, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulationsbereich";
            // 
            // settingsHeight
            // 
            this.settingsHeight.Location = new System.Drawing.Point(64, 57);
            this.settingsHeight.Margin = new System.Windows.Forms.Padding(2);
            this.settingsHeight.Name = "settingsHeight";
            this.settingsHeight.ReadOnly = true;
            this.settingsHeight.Size = new System.Drawing.Size(48, 20);
            this.settingsHeight.TabIndex = 4;
            // 
            // settingsWidth
            // 
            this.settingsWidth.Location = new System.Drawing.Point(64, 17);
            this.settingsWidth.Margin = new System.Windows.Forms.Padding(2);
            this.settingsWidth.Name = "settingsWidth";
            this.settingsWidth.ReadOnly = true;
            this.settingsWidth.Size = new System.Drawing.Size(48, 20);
            this.settingsWidth.TabIndex = 1;
            // 
            // trackBarHeight
            // 
            this.trackBarHeight.Location = new System.Drawing.Point(113, 57);
            this.trackBarHeight.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarHeight.Maximum = 30;
            this.trackBarHeight.Minimum = 10;
            this.trackBarHeight.Name = "trackBarHeight";
            this.trackBarHeight.Size = new System.Drawing.Size(286, 45);
            this.trackBarHeight.TabIndex = 3;
            this.trackBarHeight.Value = 10;
            this.trackBarHeight.Scroll += new System.EventHandler(this.trackBarHeight_Scroll);
            // 
            // trackBarWidth
            // 
            this.trackBarWidth.Location = new System.Drawing.Point(113, 17);
            this.trackBarWidth.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarWidth.Maximum = 30;
            this.trackBarWidth.Minimum = 10;
            this.trackBarWidth.Name = "trackBarWidth";
            this.trackBarWidth.Size = new System.Drawing.Size(286, 45);
            this.trackBarWidth.TabIndex = 2;
            this.trackBarWidth.Value = 10;
            this.trackBarWidth.Scroll += new System.EventHandler(this.trackBarWidth_Scroll);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(13, 57);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(36, 13);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Höhe:";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(13, 17);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(37, 13);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Breite:";
            // 
            // settingsSave
            // 
            this.settingsSave.Location = new System.Drawing.Point(268, 320);
            this.settingsSave.Margin = new System.Windows.Forms.Padding(2);
            this.settingsSave.Name = "settingsSave";
            this.settingsSave.Size = new System.Drawing.Size(70, 23);
            this.settingsSave.TabIndex = 1;
            this.settingsSave.Text = "Speichern";
            this.settingsSave.UseVisualStyleBackColor = true;
            this.settingsSave.Click += new System.EventHandler(this.settingsSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(343, 320);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.settingsAnts);
            this.groupBox2.Controls.Add(this.settingsWalls);
            this.groupBox2.Controls.Add(this.labelWalls);
            this.groupBox2.Controls.Add(this.trackBarAnts);
            this.groupBox2.Controls.Add(this.labelAnts);
            this.groupBox2.Controls.Add(this.trackBarWalls);
            this.groupBox2.Location = new System.Drawing.Point(9, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(404, 110);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulation";
            // 
            // settingsAnts
            // 
            this.settingsAnts.Location = new System.Drawing.Point(64, 58);
            this.settingsAnts.Margin = new System.Windows.Forms.Padding(2);
            this.settingsAnts.Name = "settingsAnts";
            this.settingsAnts.ReadOnly = true;
            this.settingsAnts.Size = new System.Drawing.Size(48, 20);
            this.settingsAnts.TabIndex = 10;
            // 
            // settingsWalls
            // 
            this.settingsWalls.Location = new System.Drawing.Point(64, 19);
            this.settingsWalls.Margin = new System.Windows.Forms.Padding(2);
            this.settingsWalls.Name = "settingsWalls";
            this.settingsWalls.ReadOnly = true;
            this.settingsWalls.Size = new System.Drawing.Size(48, 20);
            this.settingsWalls.TabIndex = 6;
            // 
            // labelWalls
            // 
            this.labelWalls.AutoSize = true;
            this.labelWalls.Location = new System.Drawing.Point(13, 19);
            this.labelWalls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWalls.Name = "labelWalls";
            this.labelWalls.Size = new System.Drawing.Size(46, 13);
            this.labelWalls.TabIndex = 5;
            this.labelWalls.Text = "Mauern:";
            // 
            // trackBarAnts
            // 
            this.trackBarAnts.Location = new System.Drawing.Point(113, 58);
            this.trackBarAnts.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarAnts.Maximum = 100;
            this.trackBarAnts.Name = "trackBarAnts";
            this.trackBarAnts.Size = new System.Drawing.Size(286, 45);
            this.trackBarAnts.TabIndex = 9;
            this.trackBarAnts.Scroll += new System.EventHandler(this.trackBarAnts_Scroll);
            // 
            // labelAnts
            // 
            this.labelAnts.AutoSize = true;
            this.labelAnts.Location = new System.Drawing.Point(13, 58);
            this.labelAnts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnts.Name = "labelAnts";
            this.labelAnts.Size = new System.Drawing.Size(50, 13);
            this.labelAnts.TabIndex = 7;
            this.labelAnts.Text = "Ameisen:";
            // 
            // trackBarWalls
            // 
            this.trackBarWalls.Location = new System.Drawing.Point(113, 19);
            this.trackBarWalls.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarWalls.Maximum = 100;
            this.trackBarWalls.Name = "trackBarWalls";
            this.trackBarWalls.Size = new System.Drawing.Size(286, 45);
            this.trackBarWalls.TabIndex = 8;
            this.trackBarWalls.Scroll += new System.EventHandler(this.trackBarWalls_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.settingsColor);
            this.groupBox3.Controls.Add(this.settingsHits);
            this.groupBox3.Location = new System.Drawing.Point(9, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 76);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grafikeintellungen";
            // 
            // settingsColor
            // 
            this.settingsColor.AutoSize = true;
            this.settingsColor.Location = new System.Drawing.Point(16, 43);
            this.settingsColor.Name = "settingsColor";
            this.settingsColor.Size = new System.Drawing.Size(179, 17);
            this.settingsColor.TabIndex = 1;
            this.settingsColor.Text = "Fehldbenutzung farbig darstellen";
            this.settingsColor.UseVisualStyleBackColor = true;
            // 
            // settingsHits
            // 
            this.settingsHits.AutoSize = true;
            this.settingsHits.Location = new System.Drawing.Point(16, 20);
            this.settingsHits.Name = "settingsHits";
            this.settingsHits.Size = new System.Drawing.Size(196, 17);
            this.settingsHits.TabIndex = 0;
            this.settingsHits.Text = "Zahl der Feldbenutzungen anzeigen";
            this.settingsHits.UseVisualStyleBackColor = true;
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 352);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.settingsSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formSettings";
            this.Text = "Einstellungen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWalls)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBarWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox settingsHeight;
        private System.Windows.Forms.TextBox settingsWidth;
        private System.Windows.Forms.TrackBar trackBarHeight;
        private System.Windows.Forms.Button settingsSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox settingsAnts;
        private System.Windows.Forms.TextBox settingsWalls;
        private System.Windows.Forms.Label labelWalls;
        private System.Windows.Forms.TrackBar trackBarAnts;
        private System.Windows.Forms.Label labelAnts;
        private System.Windows.Forms.TrackBar trackBarWalls;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox settingsColor;
        private System.Windows.Forms.CheckBox settingsHits;
    }
}