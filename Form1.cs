using System.Net;
using System.IO.Compression;
using System.Diagnostics;
using System.ComponentModel;

namespace JevilSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(".\\JevilSim\\"))
            {
                button2.Enabled = true;
            }
            if (Directory.Exists(".\\SpamtonSim\\"))
            {
                button4.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged1;
                wc.DownloadFileAsync(new Uri("https://www.dropbox.com/s/9fo502w8usgp7ll/JevilSim.zip?dl=1"), "JevilSim.zip");
                wc.DownloadFileCompleted += wc_DownloadFileCompleted1;
                
            }
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged2;
                wc.DownloadFileAsync(new Uri("https://www.dropbox.com/s/wxup87njhpvq0re/DELTARUNE.zip?dl=1"), "DELTARUNE.zip");
                wc.DownloadFileCompleted += wc_DownloadFileCompleted2;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(Directory.GetCurrentDirectory() + @"\JevilSim\DELTARUNE.exe"));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged3;
                wc.DownloadFileAsync(new Uri("https://www.dropbox.com/s/0ypz388ji96opk8/SpamtonSim.zip?dl=1"), "SpamtonSim.zip");
                wc.DownloadFileCompleted += wc_DownloadFileCompleted3;
            }
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged4;
                wc.DownloadFileAsync(new Uri("https://www.dropbox.com/s/os8p9o2tblykhd4/SpamtonSexSimulator.zip?dl=1"), "SpamtonSexSimulator.zip");
                wc.DownloadFileCompleted += wc_DownloadFileCompleted4;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(Directory.GetCurrentDirectory() + @"\SpamtonSim\SpamtonSexSimulator.exe"));
        }

        private void wc_DownloadFileCompleted1(object? sender, AsyncCompletedEventArgs e)
        {
            ZipFile.ExtractToDirectory("JevilSim.zip", Directory.GetCurrentDirectory(), true);
            button2.Enabled = true;
        }
        private void wc_DownloadFileCompleted2(object? sender, AsyncCompletedEventArgs e)
        {
            ZipFile.ExtractToDirectory("DELTARUNE.zip", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), true);
        }
        private void wc_DownloadFileCompleted3(object? sender, AsyncCompletedEventArgs e)
        {
            ZipFile.ExtractToDirectory("SpamtonSim.zip", Directory.GetCurrentDirectory(), true);
            button4.Enabled = true;
        }
        private void wc_DownloadFileCompleted4(object? sender, AsyncCompletedEventArgs e)
        {
            ZipFile.ExtractToDirectory("SpamtonSexSimulator.zip", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), true);
        }

        void wc_DownloadProgressChanged1(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            dlpercentage1.Text = e.ProgressPercentage.ToString() + "%"; 
        }
        void wc_DownloadProgressChanged2(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
            dlpercentage2.Text = e.ProgressPercentage.ToString() + "%";
        }
        void wc_DownloadProgressChanged3(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar3.Value = e.ProgressPercentage;
            dlpercentage3.Text = e.ProgressPercentage.ToString() + "%";
        }
        void wc_DownloadProgressChanged4(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar4.Value = e.ProgressPercentage;
            dlpercentage4.Text = e.ProgressPercentage.ToString() + "%";
        }
    }
}