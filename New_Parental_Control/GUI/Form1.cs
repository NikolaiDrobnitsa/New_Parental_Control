using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using New_Parental_Control.GUI;
namespace New_Parental_Control
{
    public partial class Form1 : Form
    {
        private List<Process> processes = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void GetProcesses()
        {
            processes.Clear();
            processes = Process.GetProcesses().ToList<Process>();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
