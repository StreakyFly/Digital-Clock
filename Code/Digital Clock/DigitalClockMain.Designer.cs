namespace Digital_Clock
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHoursMins = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnSilver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoursMins
            // 
            this.lblHoursMins.AutoSize = true;
            this.lblHoursMins.BackColor = System.Drawing.Color.Transparent;
            this.lblHoursMins.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHoursMins.Font = new System.Drawing.Font("DS-Digital", 99.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblHoursMins.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoursMins.Location = new System.Drawing.Point(73, 51);
            this.lblHoursMins.Name = "lblHoursMins";
            this.lblHoursMins.Size = new System.Drawing.Size(344, 132);
            this.lblHoursMins.TabIndex = 0;
            this.lblHoursMins.Text = "23:47";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lblSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSeconds.Font = new System.Drawing.Font("DS-Digital", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSeconds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeconds.Location = new System.Drawing.Point(404, 119);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(74, 52);
            this.lblSeconds.TabIndex = 1;
            this.lblSeconds.Text = "39";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDate.Font = new System.Drawing.Font("DS-Digital", 56.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(51, 230);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(248, 74);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "28. SEP";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDay.Font = new System.Drawing.Font("DS-Digital", 56.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDay.Location = new System.Drawing.Point(343, 231);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(143, 74);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "WED";
            // 
            // timer
            // 
            this.timer.Interval = 80;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRed.Location = new System.Drawing.Point(4, 4);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(13, 13);
            this.btnRed.TabIndex = 4;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlue.Location = new System.Drawing.Point(4, 38);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(13, 13);
            this.btnBlue.TabIndex = 5;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Lime;
            this.btnGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGreen.Location = new System.Drawing.Point(4, 55);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(13, 13);
            this.btnGreen.TabIndex = 6;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.BlueViolet;
            this.btnPurple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPurple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPurple.Location = new System.Drawing.Point(4, 21);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(13, 13);
            this.btnPurple.TabIndex = 7;
            this.btnPurple.UseVisualStyleBackColor = false;
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnSilver
            // 
            this.btnSilver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSilver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSilver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSilver.Location = new System.Drawing.Point(4, 72);
            this.btnSilver.Name = "btnSilver";
            this.btnSilver.Size = new System.Drawing.Size(13, 13);
            this.btnSilver.TabIndex = 8;
            this.btnSilver.UseVisualStyleBackColor = false;
            this.btnSilver.Click += new System.EventHandler(this.btnSilver_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Digital_Clock.Properties.Resources.background_red;
            this.ClientSize = new System.Drawing.Size(544, 361);
            this.Controls.Add(this.btnSilver);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblHoursMins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainWindow";
            this.Text = "Digital Clock by @StreakyFly";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHoursMins;
        private Label lblSeconds;
        private Label lblDate;
        private Label lblDay;
        private System.Windows.Forms.Timer timer;
        private Button btnRed;
        private Button btnBlue;
        private Button btnGreen;
        private Button btnPurple;
        private Button btnSilver;
    }
}