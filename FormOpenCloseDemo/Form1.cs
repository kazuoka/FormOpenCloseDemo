using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOpenCloseDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void openForm2Button_Click(object sender, EventArgs e)
        {

            Form2 frm = new Form2();
            frm.Show();

        }

        private void openForm3Button_Click(object sender, EventArgs e)
        {

            //Hide();
            Visible = false;

            Form3 frm = new Form3();
            frm.ShowDialog();

            //Show();
            Visible = true;

        }
    }
}
