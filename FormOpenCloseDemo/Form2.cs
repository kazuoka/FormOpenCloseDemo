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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string closeOrExit = "";

        private void closeForm2Button_Click(object sender, EventArgs e)
        {

            closeOrExit = "Close the form?";
            this.Close();

        }

        private void exitapplicationButton_Click(object sender, EventArgs e)
        {

            closeOrExit = "Exit the Application?";
            Application.Exit();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            string message = "Are you sure that you want to " + closeOrExit;
            string caption = "C# : Form Closing Event : GeneralKazuoka Tutorial.";

            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            MessageBoxIcon ico = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(message, caption, btn, ico,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
