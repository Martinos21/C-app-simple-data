using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;



namespace Teploměr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:/Users/Martin/PycharmProjects/pythonProject1/venv/Scripts/python.exe";
            string cmd = "C:/Users/Martin/PycharmProjects/pythonProject1/outdoor.pyw";
            object args = null;
            start.Arguments = string.Format("{0} {1}", cmd, args);
            start.CreateNoWindow = true;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    textBox1.Text = result;
                }

            }



            ProcessStartInfo idk = new ProcessStartInfo();
            idk.FileName = "C:/Users/Martin/PycharmProjects/pythonProject1/venv/Scripts/python.exe";
            string cmdd = "C:/Users/Martin/PycharmProjects/pythonProject1/room1_air.py";
            object argss = null;
            idk.Arguments = string.Format("{0} {1}", cmdd, argss);
            idk.CreateNoWindow = true;
            idk.UseShellExecute = false;
            idk.RedirectStandardOutput = true;
            using (Process process = Process.Start(idk))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    textBox2.Text = result;
                }

            }

            ProcessStartInfo idkk = new ProcessStartInfo();
            idkk.FileName = "C:/Users/Martin/PycharmProjects/pythonProject1/venv/Scripts/python.exe";
            string cmddd = "C:/Users/Martin/PycharmProjects/pythonProject1/humidity.py";
            object argsss = null;
            idkk.Arguments = string.Format("{0} {1}", cmddd, argsss);
            idkk.CreateNoWindow = true;
            idkk.UseShellExecute = false;
            idkk.RedirectStandardOutput = true;
            using (Process process = Process.Start(idkk))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    textBox3.Text = result;
                }

            }

            ProcessStartInfo idkkk = new ProcessStartInfo();
            idkkk.FileName = "C:/Users/Martin/PycharmProjects/pythonProject1/venv/Scripts/python.exe";
            string cmdddd = "C:/Users/Martin/PycharmProjects/pythonProject1/floor.py";
            object argssss = null;
            idkkk.Arguments = string.Format("{0} {1}", cmdddd, argssss);
            idkkk.CreateNoWindow = true;
            idkkk.UseShellExecute = false;
            idkkk.RedirectStandardOutput = true;
            using (Process process = Process.Start(idkkk))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    textBox4.Text = result;
                }

            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:/Users/Martin/PycharmProjects/pythonProject1/venv/Scripts/python.exe";
            string cmd = "C:/Users/Martin/PycharmProjects/pythonProject1/outdoor.pyw";
            object args = null;
            start.Arguments = string.Format("{0} {1}", cmd, args);
            start.CreateNoWindow = true;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    textBox1.Text = result;
                }

            }



            ProcessStartInfo idk = new ProcessStartInfo();
            idk.FileName = "C:/Users/Martin/PycharmProjects/pythonProject1/venv/Scripts/python.exe";
            string cmdd = "C:/Users/Martin/PycharmProjects/pythonProject1/room1_air.py";
            object argss = null;
            idk.Arguments = string.Format("{0} {1}", cmdd, argss);
            idk.CreateNoWindow = true;
            idk.UseShellExecute = false;
            idk.RedirectStandardOutput = true;
            using (Process process = Process.Start(idk))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    textBox2.Text = result;
                }

            }

            ProcessStartInfo idkk = new ProcessStartInfo();
            idkk.FileName = "C:/Users/Martin/PycharmProjects/pythonProject1/venv/Scripts/python.exe";
            string cmddd = "C:/Users/Martin/PycharmProjects/pythonProject1/humidity.py";
            object argsss = null;
            idkk.Arguments = string.Format("{0} {1}", cmddd, argsss);
            idkk.CreateNoWindow = true;
            idkk.UseShellExecute = false;
            idkk.RedirectStandardOutput = true;
            using (Process process = Process.Start(idkk))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    textBox3.Text = result;
                }

            }

            ProcessStartInfo idkkk = new ProcessStartInfo();
            idkkk.FileName = "C:/Users/Martin/PycharmProjects/pythonProject1/venv/Scripts/python.exe";
            string cmdddd = "C:/Users/Martin/PycharmProjects/pythonProject1/floor.py";
            object argssss = null;
            idkkk.Arguments = string.Format("{0} {1}", cmdddd, argssss);
            idkkk.CreateNoWindow = true;
            idkkk.UseShellExecute = false;
            idkkk.RedirectStandardOutput = true;
            using (Process process = Process.Start(idkkk))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    textBox4.Text = result;
                }

            }

        }


    }
}
