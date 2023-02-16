using System.Net;
using System.IO.Compression;
using System.Diagnostics;

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
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                
            }
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged2;
                wc.DownloadFileAsync(new Uri("https://www.dropbox.com/s/l5fwdua88ynwnhw/filech1_jevilsim?dl=1"), "filech1_jevilsim");
            }
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged3;
                wc.DownloadFileAsync(new Uri("https://www.dropbox.com/s/8c78sgl9ufgp9sn/drjs.ini?dl=1"), "drjs.ini");
            }
        }

        private void wc_DownloadFileCompleted(object? sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            ZipFile.ExtractToDirectory("JevilSim.zip", Directory.GetCurrentDirectory(), true);
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            if (Directory.Exists(localAppData + "\\DELTARUNE\\"))
            {
                File.Move("filech1_jevilsim", localAppData + "\\DELTARUNE\\filech1_jevilsim", true);
                File.Move("drjs.ini", localAppData + "\\DELTARUNE\\drjs.ini", true);
            }
            else
            {
                Directory.CreateDirectory(localAppData + "\\DELTARUNE\\");
                File.Move("filech1_jevilsim", localAppData + "\\DELTARUNE\\filech1_jevilsim", true);
                File.Move("drjs.ini", localAppData + "\\DELTARUNE\\drjs.ini", true);
            }
            button2.Enabled = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(Directory.GetCurrentDirectory() + @"\JevilSim\DELTARUNE.exe"));
        }
    }
}