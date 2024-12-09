namespace Rock_Paper_Scissors
{
    partial class Pick10
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
            this.txtround10 = new System.Windows.Forms.Label();
            this.txttime10 = new System.Windows.Forms.Label();
            this.txtScore10 = new System.Windows.Forms.Label();
            this.txtComp10 = new System.Windows.Forms.Label();
            this.txtuser10 = new System.Windows.Forms.Label();
            this.btnrock10 = new Guna.UI2.WinForms.Guna2Button();
            this.btnpaper10 = new Guna.UI2.WinForms.Guna2Button();
            this.btnscissors10 = new Guna.UI2.WinForms.Guna2Button();
            this.btnhome10 = new Guna.UI2.WinForms.Guna2Button();
            this.CountDown10 = new System.Windows.Forms.Timer(this.components);
            this.pbcomp10 = new System.Windows.Forms.PictureBox();
            this.pbuser10 = new System.Windows.Forms.PictureBox();
            this.pbbg10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbcomp10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbg10)).BeginInit();
            this.SuspendLayout();
            // 
            // txtround10
            // 
            this.txtround10.AutoSize = true;
            this.txtround10.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtround10.Location = new System.Drawing.Point(445, 392);
            this.txtround10.Name = "txtround10";
            this.txtround10.Size = new System.Drawing.Size(135, 32);
            this.txtround10.TabIndex = 27;
            this.txtround10.Text = "Rounds : 1";
            // 
            // txttime10
            // 
            this.txttime10.AutoSize = true;
            this.txttime10.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime10.Location = new System.Drawing.Point(491, 224);
            this.txttime10.Name = "txttime10";
            this.txttime10.Size = new System.Drawing.Size(33, 37);
            this.txttime10.TabIndex = 26;
            this.txttime10.Text = "5\r\n";
            this.txttime10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScore10
            // 
            this.txtScore10.AutoSize = true;
            this.txtScore10.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore10.Location = new System.Drawing.Point(308, 21);
            this.txtScore10.Name = "txtScore10";
            this.txtScore10.Size = new System.Drawing.Size(453, 32);
            this.txtScore10.TabIndex = 25;
            this.txtScore10.Text = "User: 0                              Computer : 0";
            // 
            // txtComp10
            // 
            this.txtComp10.AutoSize = true;
            this.txtComp10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComp10.Location = new System.Drawing.Point(641, 127);
            this.txtComp10.Name = "txtComp10";
            this.txtComp10.Size = new System.Drawing.Size(102, 25);
            this.txtComp10.TabIndex = 24;
            this.txtComp10.Text = "Computer";
            // 
            // txtuser10
            // 
            this.txtuser10.AutoSize = true;
            this.txtuser10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser10.Location = new System.Drawing.Point(309, 127);
            this.txtuser10.Name = "txtuser10";
            this.txtuser10.Size = new System.Drawing.Size(52, 25);
            this.txtuser10.TabIndex = 23;
            this.txtuser10.Text = "User";
            // 
            // btnrock10
            // 
            this.btnrock10.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnrock10.BorderThickness = 3;
            this.btnrock10.CheckedState.Parent = this.btnrock10;
            this.btnrock10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrock10.CustomImages.Parent = this.btnrock10;
            this.btnrock10.FillColor = System.Drawing.Color.White;
            this.btnrock10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrock10.ForeColor = System.Drawing.Color.Black;
            this.btnrock10.HoverState.Parent = this.btnrock10;
            this.btnrock10.Location = new System.Drawing.Point(25, 189);
            this.btnrock10.Name = "btnrock10";
            this.btnrock10.ShadowDecoration.Parent = this.btnrock10;
            this.btnrock10.Size = new System.Drawing.Size(130, 40);
            this.btnrock10.TabIndex = 20;
            this.btnrock10.Text = "Rock";
            // 
            // btnpaper10
            // 
            this.btnpaper10.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnpaper10.BorderThickness = 3;
            this.btnpaper10.CheckedState.Parent = this.btnpaper10;
            this.btnpaper10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpaper10.CustomImages.Parent = this.btnpaper10;
            this.btnpaper10.FillColor = System.Drawing.Color.White;
            this.btnpaper10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaper10.ForeColor = System.Drawing.Color.Black;
            this.btnpaper10.HoverState.Parent = this.btnpaper10;
            this.btnpaper10.Location = new System.Drawing.Point(25, 248);
            this.btnpaper10.Name = "btnpaper10";
            this.btnpaper10.ShadowDecoration.Parent = this.btnpaper10;
            this.btnpaper10.Size = new System.Drawing.Size(130, 40);
            this.btnpaper10.TabIndex = 19;
            this.btnpaper10.Text = "Paper";
            // 
            // btnscissors10
            // 
            this.btnscissors10.BorderColor = System.Drawing.Color.Chocolate;
            this.btnscissors10.BorderThickness = 3;
            this.btnscissors10.CheckedState.Parent = this.btnscissors10;
            this.btnscissors10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnscissors10.CustomImages.Parent = this.btnscissors10;
            this.btnscissors10.FillColor = System.Drawing.Color.White;
            this.btnscissors10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnscissors10.ForeColor = System.Drawing.Color.Black;
            this.btnscissors10.HoverState.Parent = this.btnscissors10;
            this.btnscissors10.Location = new System.Drawing.Point(25, 309);
            this.btnscissors10.Name = "btnscissors10";
            this.btnscissors10.ShadowDecoration.Parent = this.btnscissors10;
            this.btnscissors10.Size = new System.Drawing.Size(130, 40);
            this.btnscissors10.TabIndex = 18;
            this.btnscissors10.Text = "Scissors";
            // 
            // btnhome10
            // 
            this.btnhome10.BorderColor = System.Drawing.Color.Brown;
            this.btnhome10.BorderThickness = 3;
            this.btnhome10.CheckedState.Parent = this.btnhome10;
            this.btnhome10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome10.CustomImages.Parent = this.btnhome10;
            this.btnhome10.FillColor = System.Drawing.Color.White;
            this.btnhome10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome10.ForeColor = System.Drawing.Color.Black;
            this.btnhome10.HoverState.Parent = this.btnhome10;
            this.btnhome10.Location = new System.Drawing.Point(657, 469);
            this.btnhome10.Name = "btnhome10";
            this.btnhome10.ShadowDecoration.Parent = this.btnhome10;
            this.btnhome10.Size = new System.Drawing.Size(140, 40);
            this.btnhome10.TabIndex = 17;
            this.btnhome10.Text = "Home";
            // 
            // CountDown10
            // 
            this.CountDown10.Interval = 1000;
            this.CountDown10.Tick += new System.EventHandler(this.countdownevent10);
            // 
            // pbcomp10
            // 
            this.pbcomp10.Image = global::Rock_Paper_Scissors.Properties.Resources.question_mark;
            this.pbcomp10.Location = new System.Drawing.Point(593, 164);
            this.pbcomp10.Name = "pbcomp10";
            this.pbcomp10.Size = new System.Drawing.Size(200, 200);
            this.pbcomp10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcomp10.TabIndex = 22;
            this.pbcomp10.TabStop = false;
            // 
            // pbuser10
            // 
            this.pbuser10.Image = global::Rock_Paper_Scissors.Properties.Resources.question_mark;
            this.pbuser10.Location = new System.Drawing.Point(233, 164);
            this.pbuser10.Name = "pbuser10";
            this.pbuser10.Size = new System.Drawing.Size(200, 200);
            this.pbuser10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbuser10.TabIndex = 21;
            this.pbuser10.TabStop = false;
            // 
            // pbbg10
            // 
            this.pbbg10.Image = global::Rock_Paper_Scissors.Properties.Resources.rps_bg;
            this.pbbg10.Location = new System.Drawing.Point(-3, -5);
            this.pbbg10.Name = "pbbg10";
            this.pbbg10.Size = new System.Drawing.Size(870, 550);
            this.pbbg10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbg10.TabIndex = 16;
            this.pbbg10.TabStop = false;
            // 
            // Pick10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 541);
            this.Controls.Add(this.txtround10);
            this.Controls.Add(this.txttime10);
            this.Controls.Add(this.txtScore10);
            this.Controls.Add(this.txtComp10);
            this.Controls.Add(this.txtuser10);
            this.Controls.Add(this.btnrock10);
            this.Controls.Add(this.btnpaper10);
            this.Controls.Add(this.btnscissors10);
            this.Controls.Add(this.btnhome10);
            this.Controls.Add(this.pbcomp10);
            this.Controls.Add(this.pbuser10);
            this.Controls.Add(this.pbbg10);
            this.Name = "Pick10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick10";
            this.Load += new System.EventHandler(this.Pick10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbcomp10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbg10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtround10;
        private System.Windows.Forms.Label txttime10;
        private System.Windows.Forms.Label txtScore10;
        private System.Windows.Forms.Label txtComp10;
        private System.Windows.Forms.Label txtuser10;
        private Guna.UI2.WinForms.Guna2Button btnrock10;
        private Guna.UI2.WinForms.Guna2Button btnpaper10;
        private Guna.UI2.WinForms.Guna2Button btnscissors10;
        private Guna.UI2.WinForms.Guna2Button btnhome10;
        private System.Windows.Forms.Timer CountDown10;
        private System.Windows.Forms.PictureBox pbcomp10;
        private System.Windows.Forms.PictureBox pbuser10;
        private System.Windows.Forms.PictureBox pbbg10;
    }
}