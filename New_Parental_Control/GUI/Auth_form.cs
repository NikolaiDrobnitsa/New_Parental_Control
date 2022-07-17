using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using New_Parental_Control.Controller;
namespace New_Parental_Control.GUI
{
    public partial class Auth_form : Form
    {
        public Auth_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthController authController = new AuthController();
            
            if (authController.Authorization(textBox1.Text))
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
                
            }
            else
            {
                label2.Visible = false;
                Thread.Sleep(100);
                label2.Visible = true;
            }
        }

        private void Auth_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
