using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using New_Parental_Control.GUI;
namespace New_Parental_Control
{
    public partial class Form1 : Form
    {
        private List<Process> processes = null;
        private List<string> processes_name = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void GetAppName()
        {
            int DisplayNameCount = 0;
            string SoftwareKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(SoftwareKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                            if (!(sk.GetValue("DisplayName") == null))
                            {
                                if (sk.GetValue("InstallLocation") != null)
                                {
                                    if (DisplayNameCount != 17)
                                    {
                                        listView1.Items.Add(sk.GetValue("DisplayName").ToString());
                                        DisplayNameCount++;
                                    }
                                    Thread.Sleep(100);
                                    Text = "Запущено приложений: " + DisplayNameCount.ToString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            }

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAppName();
        }

        private void LockToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems[0] != null)
                {
                    //MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
                    listView1.SelectedItems[0].SubItems.Clear();
                    listView1.SelectedItems[0].SubItems.Add("Заблокировано");
                }
                else
                {
                    MessageBox.Show("Выберите приложения для блокировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception) { }
        }

        private void UnlockToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems[0] != null)
                {
                    //MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
                    listView1.SelectedItems[0].SubItems.Clear();
                    listView1.SelectedItems[0].SubItems.Add("Разблокировано");
                }
                else
                {
                    MessageBox.Show("Выберите приложения для разблокировать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception) { }
        }
    }
}
