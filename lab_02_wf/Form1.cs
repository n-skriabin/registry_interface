using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_02_wf
{
    public partial class Form1 : Form
    {
        RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }
       

        private void button1_Click(object sender, EventArgs e)
        {
            var newKey = key.OpenSubKey(textBox1.Text, true);

            newKey.SetValue(textBox19.Text, Convert.ToInt32(textBox2.Text), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newKey = key.OpenSubKey(textBox4.Text, true);

            newKey.SetValue(textBox30.Text, Convert.ToInt32(textBox3.Text), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newKey = key.OpenSubKey(textBox6.Text, true);

            newKey.SetValue(textBox29.Text, Convert.ToInt32(textBox5.Text), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newKey = key.OpenSubKey(textBox8.Text, true);

            newKey.SetValue(textBox28.Text, Convert.ToInt32(textBox7.Text), RegistryValueKind.String);

            newKey.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newKey = key.OpenSubKey(textBox10.Text, true);

            newKey.SetValue(textBox27.Text, Convert.ToInt32(textBox9.Text), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newKey = key.OpenSubKey(textBox18.Text, true);

            newKey.SetValue(textBox26.Text, Convert.ToInt32(textBox17.Text), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var newKey = key.OpenSubKey(textBox16.Text, true);

            newKey.SetValue(textBox25.Text, Convert.ToInt32(textBox15.Text), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newKey = key.OpenSubKey(textBox14.Text, true);

            newKey.SetValue(textBox24.Text, Convert.ToInt32(textBox13.Text), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var newKey = key.OpenSubKey(textBox12.Text, true);

            newKey.SetValue(textBox23.Text, Convert.ToInt32(textBox11.Text), RegistryValueKind.DWord);

            newKey.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var newKey = key.OpenSubKey(textBox22.Text, true);

            newKey.SetValue(textBox20.Text, Convert.ToInt32(textBox21.Text), RegistryValueKind.DWord);

            newKey.Close();
        }
    }
}
