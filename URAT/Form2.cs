using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace URAT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 register = new Form1();

            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Fill in all fields.");
            }
            else if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Fill in all fields.");
            }
            else
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));

                MessageBox.Show("Successfully logged in!");

                Thread.Sleep(TimeSpan.FromSeconds(2));

                MessageBox.Show("You can now launch warzone and injection will be processed automatically! Press DEL key when ingame to open menu.");
                this.Close();
                register.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string winPath = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
            Process.Start(winPath + "CollosalLoader.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
