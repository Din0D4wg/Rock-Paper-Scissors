namespace Rock_Paper_Scissors
{
    partial class Pick3
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
            this.components = new System.ComponentModel.Container();
            this.pbbg = new System.Windows.Forms.PictureBox();
            this.btnhome = new Guna.UI2.WinForms.Guna2Button();
            this.btnscissors = new Guna.UI2.WinForms.Guna2Button();
            this.btnpaper = new Guna.UI2.WinForms.Guna2Button();
            this.btnrock = new Guna.UI2.WinForms.Guna2Button();
            this.pbuser = new System.Windows.Forms.PictureBox();
            this.pbcomp = new System.Windows.Forms.PictureBox();
            this.txtuser = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txttime = new System.Windows.Forms.Label();
            this.txtround = new System.Windows.Forms.Label();
            this.CountDown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbbg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcomp)).BeginInit();
            this.SuspendLayout();
            // 
            // pbbg
            // 
            this.pbbg.Image = global::Rock_Paper_Scissors.Properties.Resources.rps_bg;
            this.pbbg.Location = new System.Drawing.Point(-3, -5);
            this.pbbg.Name = "pbbg";
            this.pbbg.Size = new System.Drawing.Size(870, 550);
            this.pbbg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbg.TabIndex = 4;
            this.pbbg.TabStop = false;
            this.pbbg.Click += new System.EventHandler(this.pbbg_Click);
            // 
            // btnhome
            // 
            this.btnhome.BorderColor = System.Drawing.Color.Brown;
            this.btnhome.BorderThickness = 3;
            this.btnhome.CheckedState.Parent = this.btnhome;
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.CustomImages.Parent = this.btnhome;
            this.btnhome.FillColor = System.Drawing.Color.White;
            this.btnhome.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.Black;
            this.btnhome.HoverState.Parent = this.btnhome;
            this.btnhome.Location = new System.Drawing.Point(657, 469);
            this.btnhome.Name = "btnhome";
            this.btnhome.ShadowDecoration.Parent = this.btnhome;
            this.btnhome.Size = new System.Drawing.Size(140, 40);
            this.btnhome.TabIndex = 5;
            this.btnhome.Text = "Home";
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnscissors
            // 
            this.btnscissors.BorderColor = System.Drawing.Color.Chocolate;
            this.btnscissors.BorderThickness = 3;
            this.btnscissors.CheckedState.Parent = this.btnscissors;
            this.btnscissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnscissors.CustomImages.Parent = this.btnscissors;
            this.btnscissors.FillColor = System.Drawing.Color.White;
            this.btnscissors.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnscissors.ForeColor = System.Drawing.Color.Black;
            this.btnscissors.HoverState.Parent = this.btnscissors;
            this.btnscissors.Location = new System.Drawing.Point(25, 309);
            this.btnscissors.Name = "btnscissors";
            this.btnscissors.ShadowDecoration.Parent = this.btnscissors;
            this.btnscissors.Size = new System.Drawing.Size(130, 40);
            this.btnscissors.TabIndex = 6;
            this.btnscissors.Text = "Scissors";
            this.btnscissors.Click += new System.EventHandler(this.btnscissors_Click);
            // 
            // btnpaper
            // 
            this.btnpaper.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnpaper.BorderThickness = 3;
            this.btnpaper.CheckedState.Parent = this.btnpaper;
            this.btnpaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpaper.CustomImages.Parent = this.btnpaper;
            this.btnpaper.FillColor = System.Drawing.Color.White;
            this.btnpaper.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaper.ForeColor = System.Drawing.Color.Black;
            this.btnpaper.HoverState.Parent = this.btnpaper;
            this.btnpaper.Location = new System.Drawing.Point(25, 248);
            this.btnpaper.Name = "btnpaper";
            this.btnpaper.ShadowDecoration.Parent = this.btnpaper;
            this.btnpaper.Size = new System.Drawing.Size(130, 40);
            this.btnpaper.TabIndex = 7;
            this.btnpaper.Text = "Paper";
            this.btnpaper.Click += new System.EventHandler(this.btnpaper_Click);
            // 
            // btnrock
            // 
            this.btnrock.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnrock.BorderThickness = 3;
            this.btnrock.CheckedState.Parent = this.btnrock;
            this.btnrock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrock.CustomImages.Parent = this.btnrock;
            this.btnrock.FillColor = System.Drawing.Color.White;
            this.btnrock.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrock.ForeColor = System.Drawing.Color.Black;
            this.btnrock.HoverState.Parent = this.btnrock;
            this.btnrock.Location = new System.Drawing.Point(25, 189);
            this.btnrock.Name = "btnrock";
            this.btnrock.ShadowDecoration.Parent = this.btnrock;
            this.btnrock.Size = new System.Drawing.Size(130, 40);
            this.btnrock.TabIndex = 8;
            this.btnrock.Text = "Rock";
            this.btnrock.Click += new System.EventHandler(this.btnrock_Click);
            // 
            // pbuser
            // 
            this.pbuser.Image = global::Rock_Paper_Scissors.Properties.Resources.question_mark;
            this.pbuser.Location = new System.Drawing.Point(233, 164);
            this.pbuser.Name = "pbuser";
            this.pbuser.Size = new System.Drawing.Size(200, 200);
            this.pbuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbuser.TabIndex = 9;
            this.pbuser.TabStop = false;
            // 
            // pbcomp
            // 
            this.pbcomp.Image = global::Rock_Paper_Scissors.Properties.Resources.question_mark;
            this.pbcomp.Location = new System.Drawing.Point(593, 164);
            this.pbcomp.Name = "pbcomp";
            this.pbcomp.Size = new System.Drawing.Size(200, 200);
            this.pbcomp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcomp.TabIndex = 10;
            this.pbcomp.TabStop = false;
            // 
            // txtuser
            // 
            this.txtuser.AutoSize = true;
            this.txtuser.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(309, 127);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(52, 25);
            this.txtuser.TabIndex = 11;
            this.txtuser.Text = "User";
            // 
            // txtComp
            // 
            this.txtComp.AutoSize = true;
            this.txtComp.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComp.Location = new System.Drawing.Point(641, 127);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(102, 25);
            this.txtComp.TabIndex = 12;
            this.txtComp.Text = "Computer";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(308, 21);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(453, 32);
            this.txtScore.TabIndex = 13;
            this.txtScore.Text = "User: 0                              Computer : 0";
            // 
            // txttime
            // 
            this.txttime.AutoSize = true;
            this.txttime.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.Location = new System.Drawing.Point(491, 224);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(33, 37);
            this.txttime.TabIndex = 14;
            this.txttime.Text = "5\r\n";
            this.txttime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtround
            // 
            this.txtround.AutoSize = true;
            this.txtround.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtround.Location = new System.Drawing.Point(445, 392);
            this.txtround.Name = "txtround";
            this.txtround.Size = new System.Drawing.Size(135, 32);
            this.txtround.TabIndex = 15;
            this.txtround.Text = "Rounds : 1";
            // 
            // CountDown
            // 
            this.CountDown.Interval = 1000;
            this.CountDown.Tick += new System.EventHandler(this.countdownevent);
            // 
            // Pick3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 541);
            this.Controls.Add(this.txtround);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.pbcomp);
            this.Controls.Add(this.pbuser);
            this.Controls.Add(this.btnrock);
            this.Controls.Add(this.btnpaper);
            this.Controls.Add(this.btnscissors);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.pbbg);
            this.Name = "Pick3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick3";
            ((System.ComponentModel.ISupportInitialize)(this.pbbg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcomp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbbg;
        private Guna.UI2.WinForms.Guna2Button btnhome;
        private Guna.UI2.WinForms.Guna2Button btnscissors;
        private Guna.UI2.WinForms.Guna2Button btnpaper;
        private Guna.UI2.WinForms.Guna2Button btnrock;
        private System.Windows.Forms.PictureBox pbuser;
        private System.Windows.Forms.PictureBox pbcomp;
        private System.Windows.Forms.Label txtuser;
        private System.Windows.Forms.Label txtComp;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txttime;
        private System.Windows.Forms.Label txtround;
        private System.Windows.Forms.Timer CountDown;
    }
}