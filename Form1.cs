using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vdomgr
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;user=root;database=vdomgr;port=3306;";

        public Form1()
        {
            InitializeComponent();
            txtbx_filePath.AllowDrop = true;
            txtbx_filePath.DragEnter += txtbx_filePath_DragEnter;
            txtbx_filePath.DragDrop += txtbx_filePath_DragDrop;

        }
        
        string outputFolder = "o:\\thumbnails\\";
        string toutputFolder = "o:\\thumbnails\\t\\";
        string filepath = string.Empty;
        int timeseek ;
        string category = string.Empty;
        string type = string.Empty;
        string thumbnailPath;
        string outputFilePatht;


        private void SaveVideo(string filePath, int timeSeek, string category, string type)
        {
           string thumbnailPath = GenerateThumbnail(filePath, timeSeek ,toutputFolder);
            
          MoveFiles(filePath, category, type, thumbnailPath);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Videos (FilePath, TimeSeek, Category, Type, ThumbnailPath) VALUES (@filePath, @timeSeek, @category, @type, @thumbnailPath)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@filePath", filePath);
                cmd.Parameters.AddWithValue("@timeSeek", timeSeek);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@thumbnailPath", thumbnailPath);
                cmd.ExecuteNonQuery();
            }
        }

        public static string GenerateThumbnail(string videoFilePath, int timeSeek, string outputFolder)
        {
            string outputFilePath = Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(videoFilePath) + ".jpg");

            // Create output folder if it doesn't exist
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            // FFmpeg command to extract thumbnail
            string ffmpegCommand = $"-i \"{videoFilePath}\" -ss {timeSeek} -vframes 1 \"{outputFilePath}\"";

            // Execute FFmpeg command
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "ffmpeg",
                Arguments = ffmpegCommand,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process())
            {
                process.StartInfo = processStartInfo;
                process.Start();
                process.WaitForExit();
            }

            Console.WriteLine($"Thumbnail saved to: {outputFilePath}");
            string oups = $"{outputFilePath}";

           
            return outputFilePath;
            

        }


        private void MoveFiles(string filePath, string category, string type, string thumbnailPath)
        {
            
            string typeDirectory = Path.Combine("Videos", type);
            string categoryDirectory = Path.Combine("Thumbnails", category);

            if (!Directory.Exists(typeDirectory))
                Directory.CreateDirectory(typeDirectory);

            if (!Directory.Exists(categoryDirectory))
                Directory.CreateDirectory(categoryDirectory);

            File.Move(filePath, Path.Combine(typeDirectory, Path.GetFileName(filePath)));
            File.Move(thumbnailPath, Path.Combine(categoryDirectory, Path.GetFileName(thumbnailPath)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filepath = txtbx_filePath.Text.ToString();
     
           txttype.ResetText();
         txttype.Items.Clear();
            loadactiontype("O:\\Data\\txt files\\type.txt");


        }
        public static int ConvertTimeSeekToSeconds(string timeSeek)
        {
            TimeSpan timeSpan = TimeSpan.Parse(timeSeek);
            return (int)timeSpan.TotalSeconds;
        }
        private void btn_process_Click(object sender, EventArgs e)
        {
            filepath = txtbx_filePath.Text;
            string timeseek = txtbx_timeSeek.Text.ToString();
            int time2thumb = ConvertTimeSeekToSeconds(timeseek);
            category = txtcat.SelectedItem.ToString().Trim();
            type = txttype.SelectedItem.ToString();
            GenerateThumbnail(filepath, time2thumb, outputFolder);
            SaveVideo(filepath, time2thumb, category, type);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Video Files (*.mp4;*.avi)|*.mp4;*.avi|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the file path
                    string filePath = openFileDialog.FileName;
                    MessageBox.Show($"Selected file: {filePath}");
                    txtbx_filePath.Text = filePath;

                    // You can now use this file path as needed
                }
            }

        }

        private void rb_actor_CheckedChanged(object sender, EventArgs e)
        {
            rb_action.Checked = false;
            txtcat.ResetText();
            txtcat.Items.Clear();
           loadactorfile("O:\\Data\\txt files\\actor.txt");
           
        }

        private void rb_action_CheckedChanged(object sender, EventArgs e)
        {
            rb_actor.Checked = false;
            txtcat.ResetText();
            txtcat.Items.Clear();
            txttype.ResetText();
            txttype.Items.Clear();
            loadactionfile("O:\\Data\\txt files\\action.txt");
            loadactiontype("O:\\Data\\txt files\\type.txt");
        }
        private void loadactorfile(string filePath)
        {
            try
            {
                // Read all lines from the text file
                string[] lines = File.ReadAllLines(filePath);

                // Add each line to the ComboBox
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {

                       txtcat.Items.Add(line.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadactionfile(string filePath)
        {
            try
            {
                // Read all lines from the text file
                string[] lines = File.ReadAllLines(filePath);

                // Add each line to the ComboBox
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        txtcat.Items.Add(line.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadactiontype(string filePath)
        {
            try
            {
                // Read all lines from the text file
                string[] lines = File.ReadAllLines(filePath);

                // Add each line to the ComboBox
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        txttype.Items.Add(line.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtbx_filePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtbx_filePath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtbx_filePath.Text = files[0]; // Display the first file path in the TextBox
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            vdocarousel vdocarousel = new vdocarousel();    
            vdocarousel.Show();

        }

        private void rb_pre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_pro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_must_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
