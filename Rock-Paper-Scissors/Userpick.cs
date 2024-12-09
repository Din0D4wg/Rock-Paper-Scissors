using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Userpick : Form
    {
        public Userpick()
        {
            InitializeComponent();

            pbbg.Controls.Add(label1);
            label1.BackColor = Color.Transparent;
        }

        private void Userpick_Load(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            new Pick3().Show();
            this.Hide();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            new Pick5().Show();
            this.Hide();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            new Pick10().Show();
            this.Hide();
        }
    }
}
