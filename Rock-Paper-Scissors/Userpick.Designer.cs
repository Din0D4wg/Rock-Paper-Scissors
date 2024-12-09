namespace Rock_Paper_Scissors
{
    partial class Userpick
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.pbbg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbbg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 32F);
            this.label1.Location = new System.Drawing.Point(62, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "How many rounds will you play?";
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Crimson;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(86, 234);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(180, 180);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Crimson;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(339, 234);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(180, 180);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.Crimson;
            this.btn10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn10.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(594, 234);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(180, 180);
            this.btn10.TabIndex = 7;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // pbbg
            // 
            this.pbbg.Image = global::Rock_Paper_Scissors.Properties.Resources.rps_bg;
            this.pbbg.Location = new System.Drawing.Point(-1, -5);
            this.pbbg.Name = "pbbg";
            this.pbbg.Size = new System.Drawing.Size(870, 550);
            this.pbbg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbg.TabIndex = 3;
            this.pbbg.TabStop = false;
            // 
            // Userpick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 541);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbbg);
            this.Name = "Userpick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Userpick";
            this.Load += new System.EventHandler(this.Userpick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbbg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbbg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn10;
    }
}