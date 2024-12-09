namespace Rock_Paper_Scissors
{
    partial class Pick5
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
            this.txtround5 = new System.Windows.Forms.Label();
            this.txttime5 = new System.Windows.Forms.Label();
            this.txtScore5 = new System.Windows.Forms.Label();
            this.txtComp5 = new System.Windows.Forms.Label();
            this.txtuser5 = new System.Windows.Forms.Label();
            this.btnrock5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnpaper5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnscissors5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnhome5 = new Guna.UI2.WinForms.Guna2Button();
            this.CountDown5 = new System.Windows.Forms.Timer(this.components);
            this.pbcomp5 = new System.Windows.Forms.PictureBox();
            this.pbuser5 = new System.Windows.Forms.PictureBox();
            this.pbbg5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbcomp5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbg5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtround5
            // 
            this.txtround5.AutoSize = true;
            this.txtround5.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtround5.Location = new System.Drawing.Point(445, 392);
            this.txtround5.Name = "txtround5";
            this.txtround5.Size = new System.Drawing.Size(135, 32);
            this.txtround5.TabIndex = 27;
            this.txtround5.Text = "Rounds : 1";
            // 
            // txttime5
            // 
            this.txttime5.AutoSize = true;
            this.txttime5.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime5.Location = new System.Drawing.Point(491, 224);
            this.txttime5.Name = "txttime5";
            this.txttime5.Size = new System.Drawing.Size(33, 37);
            this.txttime5.TabIndex = 26;
            this.txttime5.Text = "5\r\n";
            this.txttime5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScore5
            // 
            this.txtScore5.AutoSize = true;
            this.txtScore5.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore5.Location = new System.Drawing.Point(308, 21);
            this.txtScore5.Name = "txtScore5";
            this.txtScore5.Size = new System.Drawing.Size(453, 32);
            this.txtScore5.TabIndex = 25;
            this.txtScore5.Text = "User: 0                              Computer : 0";
            // 
            // txtComp5
            // 
            this.txtComp5.AutoSize = true;
            this.txtComp5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComp5.Location = new System.Drawing.Point(641, 127);
            this.txtComp5.Name = "txtComp5";
            this.txtComp5.Size = new System.Drawing.Size(102, 25);
            this.txtComp5.TabIndex = 24;
            this.txtComp5.Text = "Computer";
            // 
            // txtuser5
            // 
            this.txtuser5.AutoSize = true;
            this.txtuser5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser5.Location = new System.Drawing.Point(309, 127);
            this.txtuser5.Name = "txtuser5";
            this.txtuser5.Size = new System.Drawing.Size(52, 25);
            this.txtuser5.TabIndex = 23;
            this.txtuser5.Text = "User";
            // 
            // btnrock5
            // 
            this.btnrock5.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnrock5.BorderThickness = 3;
            this.btnrock5.CheckedState.Parent = this.btnrock5;
            this.btnrock5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrock5.CustomImages.Parent = this.btnrock5;
            this.btnrock5.FillColor = System.Drawing.Color.White;
            this.btnrock5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrock5.ForeColor = System.Drawing.Color.Black;
            this.btnrock5.HoverState.Parent = this.btnrock5;
            this.btnrock5.Location = new System.Drawing.Point(25, 189);
            this.btnrock5.Name = "btnrock5";
            this.btnrock5.ShadowDecoration.Parent = this.btnrock5;
            this.btnrock5.Size = new System.Drawing.Size(130, 40);
            this.btnrock5.TabIndex = 20;
            this.btnrock5.Text = "Rock";
            this.btnrock5.Click += new System.EventHandler(this.btnrock5_Click);
            // 
            // btnpaper5
            // 
            this.btnpaper5.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnpaper5.BorderThickness = 3;
            this.btnpaper5.CheckedState.Parent = this.btnpaper5;
            this.btnpaper5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpaper5.CustomImages.Parent = this.btnpaper5;
            this.btnpaper5.FillColor = System.Drawing.Color.White;
            this.btnpaper5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaper5.ForeColor = System.Drawing.Color.Black;
            this.btnpaper5.HoverState.Parent = this.btnpaper5;
            this.btnpaper5.Location = new System.Drawing.Point(25, 248);
            this.btnpaper5.Name = "btnpaper5";
            this.btnpaper5.ShadowDecoration.Parent = this.btnpaper5;
            this.btnpaper5.Size = new System.Drawing.Size(130, 40);
            this.btnpaper5.TabIndex = 19;
            this.btnpaper5.Text = "Paper";
            this.btnpaper5.Click += new System.EventHandler(this.btnpaper5_Click);
            // 
            // btnscissors5
            // 
            this.btnscissors5.BorderColor = System.Drawing.Color.Chocolate;
            this.btnscissors5.BorderThickness = 3;
            this.btnscissors5.CheckedState.Parent = this.btnscissors5;
            this.btnscissors5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnscissors5.CustomImages.Parent = this.btnscissors5;
            this.btnscissors5.FillColor = System.Drawing.Color.White;
            this.btnscissors5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnscissors5.ForeColor = System.Drawing.Color.Black;
            this.btnscissors5.HoverState.Parent = this.btnscissors5;
            this.btnscissors5.Location = new System.Drawing.Point(25, 309);
            this.btnscissors5.Name = "btnscissors5";
            this.btnscissors5.ShadowDecoration.Parent = this.btnscissors5;
            this.btnscissors5.Size = new System.Drawing.Size(130, 40);
            this.btnscissors5.TabIndex = 18;
            this.btnscissors5.Text = "Scissors";
            this.btnscissors5.Click += new System.EventHandler(this.btnscissors5_Click);
            // 
            // btnhome5
            // 
            this.btnhome5.BorderColor = System.Drawing.Color.Brown;
            this.btnhome5.BorderThickness = 3;
            this.btnhome5.CheckedState.Parent = this.btnhome5;
            this.btnhome5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome5.CustomImages.Parent = this.btnhome5;
            this.btnhome5.FillColor = System.Drawing.Color.White;
            this.btnhome5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome5.ForeColor = System.Drawing.Color.Black;
            this.btnhome5.HoverState.Parent = this.btnhome5;
            this.btnhome5.Location = new System.Drawing.Point(657, 469);
            this.btnhome5.Name = "btnhome5";
            this.btnhome5.ShadowDecoration.Parent = this.btnhome5;
            this.btnhome5.Size = new System.Drawing.Size(140, 40);
            this.btnhome5.TabIndex = 17;
            this.btnhome5.Text = "Home";
            this.btnhome5.Click += new System.EventHandler(this.btnhome5_Click);
            // 
            // CountDown5
            // 
            this.CountDown5.Interval = 1000;
            this.CountDown5.Tick += new System.EventHandler(this.countdownevent5);
            // 
            // pbcomp5
            // 
            this.pbcomp5.Image = global::Rock_Paper_Scissors.Properties.Resources.question_mark;
            this.pbcomp5.Location = new System.Drawing.Point(593, 164);
            this.pbcomp5.Name = "pbcomp5";
            this.pbcomp5.Size = new System.Drawing.Size(200, 200);
            this.pbcomp5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcomp5.TabIndex = 22;
            this.pbcomp5.TabStop = false;
            // 
            // pbuser5
            // 
            this.pbuser5.Image = global::Rock_Paper_Scissors.Properties.Resources.question_mark;
            this.pbuser5.Location = new System.Drawing.Point(233, 164);
            this.pbuser5.Name = "pbuser5";
            this.pbuser5.Size = new System.Drawing.Size(200, 200);
            this.pbuser5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbuser5.TabIndex = 21;
            this.pbuser5.TabStop = false;
            // 
            // pbbg5
            // 
            this.pbbg5.Image = global::Rock_Paper_Scissors.Properties.Resources.rps_bg;
            this.pbbg5.Location = new System.Drawing.Point(-3, -5);
            this.pbbg5.Name = "pbbg5";
            this.pbbg5.Size = new System.Drawing.Size(870, 550);
            this.pbbg5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbg5.TabIndex = 16;
            this.pbbg5.TabStop = false;
            // 
            // Pick5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 541);
            this.Controls.Add(this.txtround5);
            this.Controls.Add(this.txttime5);
            this.Controls.Add(this.txtScore5);
            this.Controls.Add(this.txtComp5);
            this.Controls.Add(this.txtuser5);
            this.Controls.Add(this.btnrock5);
            this.Controls.Add(this.btnpaper5);
            this.Controls.Add(this.btnscissors5);
            this.Controls.Add(this.btnhome5);
            this.Controls.Add(this.pbcomp5);
            this.Controls.Add(this.pbuser5);
            this.Controls.Add(this.pbbg5);
            this.Name = "Pick5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick5";
            this.Load += new System.EventHandler(this.Pick5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbcomp5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbg5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtround5;
        private System.Windows.Forms.Label txttime5;
        private System.Windows.Forms.Label txtScore5;
        private System.Windows.Forms.Label txtComp5;
        private System.Windows.Forms.Label txtuser5;
        private Guna.UI2.WinForms.Guna2Button btnrock5;
        private Guna.UI2.WinForms.Guna2Button btnpaper5;
        private Guna.UI2.WinForms.Guna2Button btnscissors5;
        private Guna.UI2.WinForms.Guna2Button btnhome5;
        private System.Windows.Forms.Timer CountDown5;
        private System.Windows.Forms.PictureBox pbcomp5;
        private System.Windows.Forms.PictureBox pbuser5;
        private System.Windows.Forms.PictureBox pbbg5;
    }
}