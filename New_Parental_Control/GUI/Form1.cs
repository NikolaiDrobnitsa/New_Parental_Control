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
        private List<String> processes_name = new List<String>();
        //private List<string> processes_name = null;
        string[] strings = null;
        int DisplayNameCount = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private async void GetAppName()
        {


            string SoftwareKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            await Task.Run(async () =>
            {
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
                                            //listView1.Items.Add(sk.GetValue("DisplayName").ToString());
                                            processes_name.Add(sk.GetValue("DisplayName").ToString());
                                            //processes_name = sk.GetValue("DisplayName");
                                            

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
                await Task.Delay(1);
            });

        }
        private void RefreshProcessesList()
        {
            //listView1.Items.Clear();
            //foreach (string p in processes_name)
            //{

            //    //listView1.Items.Add(    p);


            //}
            //for (int i = 0; i < DisplayNameCount; i++)
            //{
            //    listView1.Items.Add(new ListViewItem(strings)); 
            //}
            //Text = "Запущено приложений: " + processes.Count.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAppName();
            //RefreshProcessesList();
            listView1.Items.Add("FPS Monitor");

        }

        private void LockToolStripButton_Click(object sender, EventArgs e)
        {
            foreach (var item in processes_name)
            {
                textBox1.Text += item;
            }
            try
            {
                if (listView1.SelectedItems[0] != null)
                {
                    //MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);

                    listView1.SelectedItems[0].SubItems.Add("Заблокировано");
                    //addInBlockList(listView1.SelectedItems[0].ToString());
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
                    //listView1.SelectedItems[0].SubItems.Text = "Разблокировано";

                    listView1.SelectedItems[0].SubItems.Add("Разблокировано");
                    //listView1.SelectedItems[0].SubItems.RemoveAt();
                    //listView1.SelectedItems[0].SubItems.Clear();
                }
                else
                {
                    MessageBox.Show("Выберите приложения для разблокировать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception) { }
        }

        private void TImeLockToolStripButton_Click(object sender, EventArgs e)
        {
            if (ExapleTImetoolStripComboBox1.SelectedIndex != -1)
            {
                try
                {
                    if (listView1.SelectedItems[0] != null)
                    {
                        //MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
                        //listView1.SelectedItems[0].SubItems.Text = "Разблокировано";

                        listView1.SelectedItems[0].SubItems.Add("Разблокировано на : " + ExapleTImetoolStripComboBox1.SelectedItem);
                        //listView1.SelectedItems[0].SubItems.RemoveAt();
                        //listView1.SelectedItems[0].SubItems.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Выберите приложения для разблокировать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception) { }
            }
            else
            {
                MessageBox.Show("Выберите время для разблокировать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        List<string> block_name = new List<string>();
        private void addInBlockList(string blocks) {
            //string[] blocklList = blocks.Items.OfType<string>().ToArray();
            //MessageBox.Show(blocklList.ToString());

            //foreach (var s in block_name)
            //{
            //    if (!block_name.Contains(blocks))
            //    {
            //        block_name.Add(blocks);
            //    }
            //}
            

        }
        private async void CheckBlock()
        {

            

            await Task.Run(async () =>
            {
                
                    if (block_name != null)
                    {
                        foreach (var item in block_name)
                        {
                            foreach (var process in Process.GetProcessesByName(item))
                            {
                                try
                                {

                                    Thread.Sleep(1000);
                                    process.Kill();
                                }
                                catch (Exception ex)
                                {
                                }

                            }
                        }
                    }
                
                await Task.Delay(1000);
            });

            //}

        }

        private void Check_timer_Tick(object sender, EventArgs e)
        {
            CheckBlock();
        }
    }
}
