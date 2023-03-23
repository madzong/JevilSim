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
                wc.DownloadFileAsync(new Uri("https://www.dropbox.com/s/oy2ioucaz0apowp/JevilSimulator.zip?dl=1"), "JevilSimulator.zip");
                wc.DownloadFileCompleted += wc_DownloadFileCompleted2;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(Directory.GetCurrentDirectory() + @"\JevilSim\JevilSimulator.exe"));
        }
        private void wc_DownloadFileCompleted1(object? sender, AsyncCompletedEventArgs e)
        {
            ZipFile.ExtractToDirectory("JevilSim.zip", Directory.GetCurrentDirectory(), true);
            button2.Enabled = true;
        }
        private void wc_DownloadFileCompleted2(object? sender, AsyncCompletedEventArgs e)
        {
            ZipFile.ExtractToDirectory("JevilSimulator.zip", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), true);
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
    }
}