namespace Rock_Paper_Scissors
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
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.pbbg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BorderColor = System.Drawing.Color.Crimson;
            this.btnStart.BorderThickness = 5;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Crimson;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(282, 296);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(327, 132);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pblogo
            // 
            this.pblogo.Image = global::Rock_Paper_Scissors.Properties.Resources.rps_logo;
            this.pblogo.Location = new System.Drawing.Point(226, -16);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(451, 268);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 1;
            this.pblogo.TabStop = false;
            // 
            // pbbg
            // 
            this.pbbg.Image = global::Rock_Paper_Scissors.Properties.Resources.rps_bg;
            this.pbbg.Location = new System.Drawing.Point(-3, -5);
            this.pbbg.Name = "pbbg";
            this.pbbg.Size = new System.Drawing.Size(870, 550);
            this.pbbg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbg.TabIndex = 2;
            this.pbbg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 541);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.pbbg);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPS Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.PictureBox pbbg;
        private Guna.UI2.WinForms.Guna2Button btnStart;
    }
}

