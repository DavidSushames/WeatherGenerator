namespace Weather_Generation
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRollAll = new System.Windows.Forms.Button();
            this.btnRoll1 = new System.Windows.Forms.Button();
            this.btnRoll2 = new System.Windows.Forms.Button();
            this.lblRollAll = new System.Windows.Forms.Label();
            this.lblRoll2 = new System.Windows.Forms.Label();
            this.lblRoll1 = new System.Windows.Forms.Label();
            this.gbxSeason = new System.Windows.Forms.GroupBox();
            this.trbSeasonWind = new System.Windows.Forms.TrackBar();
            this.trbSeasonPrec = new System.Windows.Forms.TrackBar();
            this.trbSeasonTemp = new System.Windows.Forms.TrackBar();
            this.dgvWeather = new System.Windows.Forms.DataGridView();
            this.RollCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeatherVals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeatherConds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WHazards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblPrec = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.lblSliderTemp = new System.Windows.Forms.Label();
            this.lblSliderPrec = new System.Windows.Forms.Label();
            this.lblSliderWind = new System.Windows.Forms.Label();
            this.gbxClimate = new System.Windows.Forms.GroupBox();
            this.trbClimateWind = new System.Windows.Forms.TrackBar();
            this.trbClimatePrec = new System.Windows.Forms.TrackBar();
            this.trbClimateTemp = new System.Windows.Forms.TrackBar();
            this.lblSeasonText = new System.Windows.Forms.Label();
            this.lblClimateText = new System.Windows.Forms.Label();
            this.tbxWindMod = new System.Windows.Forms.TextBox();
            this.tbxPrecMod = new System.Windows.Forms.TextBox();
            this.tbxTempMod = new System.Windows.Forms.TextBox();
            this.lblMod = new System.Windows.Forms.Label();
            this.gbxSeason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSeasonWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSeasonPrec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSeasonTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeather)).BeginInit();
            this.gbxClimate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbClimateWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbClimatePrec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbClimateTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollAll
            // 
            this.btnRollAll.Location = new System.Drawing.Point(775, 25);
            this.btnRollAll.Name = "btnRollAll";
            this.btnRollAll.Size = new System.Drawing.Size(100, 23);
            this.btnRollAll.TabIndex = 3;
            this.btnRollAll.Text = "Roll All Dice";
            this.btnRollAll.UseVisualStyleBackColor = true;
            this.btnRollAll.Click += new System.EventHandler(this.btnRollAll_Click);
            // 
            // btnRoll1
            // 
            this.btnRoll1.Location = new System.Drawing.Point(775, 123);
            this.btnRoll1.Name = "btnRoll1";
            this.btnRoll1.Size = new System.Drawing.Size(100, 23);
            this.btnRoll1.TabIndex = 21;
            this.btnRoll1.Text = "Roll One Dice";
            this.btnRoll1.UseVisualStyleBackColor = true;
            this.btnRoll1.Click += new System.EventHandler(this.btnRoll1_Click);
            // 
            // btnRoll2
            // 
            this.btnRoll2.Location = new System.Drawing.Point(775, 75);
            this.btnRoll2.Name = "btnRoll2";
            this.btnRoll2.Size = new System.Drawing.Size(100, 23);
            this.btnRoll2.TabIndex = 22;
            this.btnRoll2.Text = "Roll Two Dice";
            this.btnRoll2.UseVisualStyleBackColor = true;
            this.btnRoll2.Click += new System.EventHandler(this.btnRoll2_Click);
            // 
            // lblRollAll
            // 
            this.lblRollAll.AutoSize = true;
            this.lblRollAll.Location = new System.Drawing.Point(789, 11);
            this.lblRollAll.Name = "lblRollAll";
            this.lblRollAll.Size = new System.Drawing.Size(71, 13);
            this.lblRollAll.TabIndex = 24;
            this.lblRollAll.Text = "Fully Random";
            // 
            // lblRoll2
            // 
            this.lblRoll2.AutoSize = true;
            this.lblRoll2.Location = new System.Drawing.Point(789, 61);
            this.lblRoll2.Name = "lblRoll2";
            this.lblRoll2.Size = new System.Drawing.Size(71, 13);
            this.lblRoll2.TabIndex = 25;
            this.lblRoll2.Text = "Very Random";
            // 
            // lblRoll1
            // 
            this.lblRoll1.AutoSize = true;
            this.lblRoll1.Location = new System.Drawing.Point(789, 109);
            this.lblRoll1.Name = "lblRoll1";
            this.lblRoll1.Size = new System.Drawing.Size(76, 13);
            this.lblRoll1.TabIndex = 26;
            this.lblRoll1.Text = "Least Random";
            // 
            // gbxSeason
            // 
            this.gbxSeason.Controls.Add(this.trbSeasonWind);
            this.gbxSeason.Controls.Add(this.trbSeasonPrec);
            this.gbxSeason.Controls.Add(this.trbSeasonTemp);
            this.gbxSeason.Location = new System.Drawing.Point(12, 7);
            this.gbxSeason.Name = "gbxSeason";
            this.gbxSeason.Size = new System.Drawing.Size(87, 133);
            this.gbxSeason.TabIndex = 27;
            this.gbxSeason.TabStop = false;
            this.gbxSeason.Text = "Season";
            // 
            // trbSeasonWind
            // 
            this.trbSeasonWind.Location = new System.Drawing.Point(4, 86);
            this.trbSeasonWind.Margin = new System.Windows.Forms.Padding(0);
            this.trbSeasonWind.Maximum = 2;
            this.trbSeasonWind.Minimum = -2;
            this.trbSeasonWind.Name = "trbSeasonWind";
            this.trbSeasonWind.Size = new System.Drawing.Size(80, 45);
            this.trbSeasonWind.TabIndex = 54;
            this.trbSeasonWind.Scroll += new System.EventHandler(this.UpdateTextBoxes);
            // 
            // trbSeasonPrec
            // 
            this.trbSeasonPrec.Location = new System.Drawing.Point(4, 50);
            this.trbSeasonPrec.Margin = new System.Windows.Forms.Padding(0);
            this.trbSeasonPrec.Maximum = 2;
            this.trbSeasonPrec.Minimum = -2;
            this.trbSeasonPrec.Name = "trbSeasonPrec";
            this.trbSeasonPrec.Size = new System.Drawing.Size(80, 45);
            this.trbSeasonPrec.TabIndex = 52;
            this.trbSeasonPrec.Scroll += new System.EventHandler(this.UpdateTextBoxes);
            // 
            // trbSeasonTemp
            // 
            this.trbSeasonTemp.Location = new System.Drawing.Point(4, 14);
            this.trbSeasonTemp.Margin = new System.Windows.Forms.Padding(0);
            this.trbSeasonTemp.Maximum = 2;
            this.trbSeasonTemp.Minimum = -2;
            this.trbSeasonTemp.Name = "trbSeasonTemp";
            this.trbSeasonTemp.Size = new System.Drawing.Size(80, 45);
            this.trbSeasonTemp.TabIndex = 50;
            this.trbSeasonTemp.Scroll += new System.EventHandler(this.UpdateTextBoxes);
            // 
            // dgvWeather
            // 
            this.dgvWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeather.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RollCount,
            this.TRoll,
            this.TMod,
            this.PRoll,
            this.PMod,
            this.WRoll,
            this.WMod,
            this.WeatherVals,
            this.WeatherConds,
            this.WHazards});
            this.dgvWeather.Location = new System.Drawing.Point(12, 209);
            this.dgvWeather.Name = "dgvWeather";
            this.dgvWeather.RowHeadersWidth = 20;
            this.dgvWeather.RowTemplate.Height = 16;
            this.dgvWeather.Size = new System.Drawing.Size(863, 340);
            this.dgvWeather.TabIndex = 46;
            // 
            // RollCount
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.RollCount.DefaultCellStyle = dataGridViewCellStyle1;
            this.RollCount.HeaderText = "#";
            this.RollCount.Name = "RollCount";
            this.RollCount.Width = 26;
            // 
            // TRoll
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TRoll.DefaultCellStyle = dataGridViewCellStyle2;
            this.TRoll.HeaderText = "Temp Roll";
            this.TRoll.Name = "TRoll";
            this.TRoll.ReadOnly = true;
            this.TRoll.Width = 35;
            // 
            // TMod
            // 
            this.TMod.HeaderText = "Temp Val";
            this.TMod.Name = "TMod";
            this.TMod.ReadOnly = true;
            this.TMod.Width = 35;
            // 
            // PRoll
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PRoll.DefaultCellStyle = dataGridViewCellStyle3;
            this.PRoll.HeaderText = "Prec Roll";
            this.PRoll.Name = "PRoll";
            this.PRoll.ReadOnly = true;
            this.PRoll.Width = 35;
            // 
            // PMod
            // 
            this.PMod.HeaderText = "Prec Val";
            this.PMod.Name = "PMod";
            this.PMod.ReadOnly = true;
            this.PMod.Width = 35;
            // 
            // WRoll
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.WRoll.DefaultCellStyle = dataGridViewCellStyle4;
            this.WRoll.HeaderText = "Wind Roll";
            this.WRoll.Name = "WRoll";
            this.WRoll.ReadOnly = true;
            this.WRoll.Width = 35;
            // 
            // WMod
            // 
            this.WMod.HeaderText = "Wind Val";
            this.WMod.Name = "WMod";
            this.WMod.ReadOnly = true;
            this.WMod.Width = 35;
            // 
            // WeatherVals
            // 
            this.WeatherVals.HeaderText = "Weather Values";
            this.WeatherVals.Name = "WeatherVals";
            this.WeatherVals.Width = 150;
            // 
            // WeatherConds
            // 
            this.WeatherConds.HeaderText = "Weather Conditions";
            this.WeatherConds.Name = "WeatherConds";
            this.WeatherConds.Width = 120;
            // 
            // WHazards
            // 
            this.WHazards.HeaderText = "Hazards";
            this.WHazards.Name = "WHazards";
            this.WHazards.Width = 330;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(27, 194);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(67, 13);
            this.lblTemp.TabIndex = 47;
            this.lblTemp.Text = "Temperature";
            // 
            // lblPrec
            // 
            this.lblPrec.AutoSize = true;
            this.lblPrec.Location = new System.Drawing.Point(95, 194);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(65, 13);
            this.lblPrec.TabIndex = 48;
            this.lblPrec.Text = "Precipitation";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(165, 194);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(32, 13);
            this.lblWind.TabIndex = 49;
            this.lblWind.Text = "Wind";
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Location = new System.Drawing.Point(422, 194);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(48, 13);
            this.lblWeather.TabIndex = 29;
            this.lblWeather.Text = "Weather";
            // 
            // lblSliderTemp
            // 
            this.lblSliderTemp.AutoSize = true;
            this.lblSliderTemp.Location = new System.Drawing.Point(98, 25);
            this.lblSliderTemp.Name = "lblSliderTemp";
            this.lblSliderTemp.Size = new System.Drawing.Size(67, 13);
            this.lblSliderTemp.TabIndex = 51;
            this.lblSliderTemp.Text = "Temperature";
            // 
            // lblSliderPrec
            // 
            this.lblSliderPrec.AutoSize = true;
            this.lblSliderPrec.Location = new System.Drawing.Point(100, 61);
            this.lblSliderPrec.Name = "lblSliderPrec";
            this.lblSliderPrec.Size = new System.Drawing.Size(65, 13);
            this.lblSliderPrec.TabIndex = 53;
            this.lblSliderPrec.Text = "Precipitation";
            // 
            // lblSliderWind
            // 
            this.lblSliderWind.AutoSize = true;
            this.lblSliderWind.Location = new System.Drawing.Point(116, 97);
            this.lblSliderWind.Name = "lblSliderWind";
            this.lblSliderWind.Size = new System.Drawing.Size(32, 13);
            this.lblSliderWind.TabIndex = 55;
            this.lblSliderWind.Text = "Wind";
            // 
            // gbxClimate
            // 
            this.gbxClimate.Controls.Add(this.trbClimateWind);
            this.gbxClimate.Controls.Add(this.trbClimatePrec);
            this.gbxClimate.Controls.Add(this.trbClimateTemp);
            this.gbxClimate.Location = new System.Drawing.Point(165, 7);
            this.gbxClimate.Name = "gbxClimate";
            this.gbxClimate.Size = new System.Drawing.Size(87, 133);
            this.gbxClimate.TabIndex = 28;
            this.gbxClimate.TabStop = false;
            this.gbxClimate.Text = "Climate";
            // 
            // trbClimateWind
            // 
            this.trbClimateWind.Location = new System.Drawing.Point(3, 86);
            this.trbClimateWind.Margin = new System.Windows.Forms.Padding(0);
            this.trbClimateWind.Maximum = 2;
            this.trbClimateWind.Minimum = -2;
            this.trbClimateWind.Name = "trbClimateWind";
            this.trbClimateWind.Size = new System.Drawing.Size(80, 45);
            this.trbClimateWind.TabIndex = 57;
            this.trbClimateWind.Scroll += new System.EventHandler(this.UpdateTextBoxes);
            // 
            // trbClimatePrec
            // 
            this.trbClimatePrec.Location = new System.Drawing.Point(3, 50);
            this.trbClimatePrec.Margin = new System.Windows.Forms.Padding(0);
            this.trbClimatePrec.Maximum = 2;
            this.trbClimatePrec.Minimum = -2;
            this.trbClimatePrec.Name = "trbClimatePrec";
            this.trbClimatePrec.Size = new System.Drawing.Size(80, 45);
            this.trbClimatePrec.TabIndex = 56;
            this.trbClimatePrec.Scroll += new System.EventHandler(this.UpdateTextBoxes);
            // 
            // trbClimateTemp
            // 
            this.trbClimateTemp.Location = new System.Drawing.Point(3, 14);
            this.trbClimateTemp.Margin = new System.Windows.Forms.Padding(0);
            this.trbClimateTemp.Maximum = 2;
            this.trbClimateTemp.Minimum = -2;
            this.trbClimateTemp.Name = "trbClimateTemp";
            this.trbClimateTemp.Size = new System.Drawing.Size(80, 45);
            this.trbClimateTemp.TabIndex = 55;
            this.trbClimateTemp.Scroll += new System.EventHandler(this.UpdateTextBoxes);
            // 
            // lblSeasonText
            // 
            this.lblSeasonText.AutoSize = true;
            this.lblSeasonText.Location = new System.Drawing.Point(318, 3);
            this.lblSeasonText.Name = "lblSeasonText";
            this.lblSeasonText.Size = new System.Drawing.Size(363, 39);
            this.lblSeasonText.TabIndex = 56;
            this.lblSeasonText.Text = "SEASON:\r\nSpring: +1 Prec.   Summer: +1 Temp.   Autumn: +1 Wind.   Winter: -1 Temp" +
    ".\r\nMidseason doubles this.";
            // 
            // lblClimateText
            // 
            this.lblClimateText.AutoSize = true;
            this.lblClimateText.Location = new System.Drawing.Point(318, 44);
            this.lblClimateText.Name = "lblClimateText";
            this.lblClimateText.Size = new System.Drawing.Size(300, 143);
            this.lblClimateText.TabIndex = 57;
            this.lblClimateText.Text = resources.GetString("lblClimateText.Text");
            // 
            // tbxWindMod
            // 
            this.tbxWindMod.Location = new System.Drawing.Point(258, 94);
            this.tbxWindMod.Name = "tbxWindMod";
            this.tbxWindMod.Size = new System.Drawing.Size(20, 20);
            this.tbxWindMod.TabIndex = 63;
            // 
            // tbxPrecMod
            // 
            this.tbxPrecMod.Location = new System.Drawing.Point(258, 58);
            this.tbxPrecMod.Name = "tbxPrecMod";
            this.tbxPrecMod.Size = new System.Drawing.Size(20, 20);
            this.tbxPrecMod.TabIndex = 62;
            // 
            // tbxTempMod
            // 
            this.tbxTempMod.Location = new System.Drawing.Point(258, 22);
            this.tbxTempMod.Name = "tbxTempMod";
            this.tbxTempMod.Size = new System.Drawing.Size(20, 20);
            this.tbxTempMod.TabIndex = 61;
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Location = new System.Drawing.Point(255, 7);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(28, 13);
            this.lblMod.TabIndex = 64;
            this.lblMod.Text = "Mod";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 561);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.tbxWindMod);
            this.Controls.Add(this.tbxPrecMod);
            this.Controls.Add(this.tbxTempMod);
            this.Controls.Add(this.lblClimateText);
            this.Controls.Add(this.lblSeasonText);
            this.Controls.Add(this.gbxClimate);
            this.Controls.Add(this.gbxSeason);
            this.Controls.Add(this.lblSliderWind);
            this.Controls.Add(this.lblSliderPrec);
            this.Controls.Add(this.lblSliderTemp);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblPrec);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.dgvWeather);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.lblRoll1);
            this.Controls.Add(this.lblRoll2);
            this.Controls.Add(this.lblRollAll);
            this.Controls.Add(this.btnRoll2);
            this.Controls.Add(this.btnRoll1);
            this.Controls.Add(this.btnRollAll);
            this.Name = "Form1";
            this.Text = "Weather Generator";
            this.gbxSeason.ResumeLayout(false);
            this.gbxSeason.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSeasonWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSeasonPrec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSeasonTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeather)).EndInit();
            this.gbxClimate.ResumeLayout(false);
            this.gbxClimate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbClimateWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbClimatePrec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbClimateTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRollAll;
        private System.Windows.Forms.Button btnRoll1;
        private System.Windows.Forms.Button btnRoll2;
        private System.Windows.Forms.Label lblRollAll;
        private System.Windows.Forms.Label lblRoll2;
        private System.Windows.Forms.Label lblRoll1;
        private System.Windows.Forms.GroupBox gbxSeason;
        private System.Windows.Forms.DataGridView dgvWeather;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblPrec;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.TrackBar trbSeasonTemp;
        private System.Windows.Forms.Label lblSliderTemp;
        private System.Windows.Forms.TrackBar trbSeasonPrec;
        private System.Windows.Forms.Label lblSliderPrec;
        private System.Windows.Forms.TrackBar trbSeasonWind;
        private System.Windows.Forms.Label lblSliderWind;
        private System.Windows.Forms.GroupBox gbxClimate;
        private System.Windows.Forms.TrackBar trbClimateWind;
        private System.Windows.Forms.TrackBar trbClimatePrec;
        private System.Windows.Forms.TrackBar trbClimateTemp;
        private System.Windows.Forms.Label lblSeasonText;
        private System.Windows.Forms.Label lblClimateText;
        private System.Windows.Forms.TextBox tbxWindMod;
        private System.Windows.Forms.TextBox tbxPrecMod;
        private System.Windows.Forms.TextBox tbxTempMod;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn TMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn WRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn WMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeatherVals;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeatherConds;
        private System.Windows.Forms.DataGridViewTextBoxColumn WHazards;
    }
}

