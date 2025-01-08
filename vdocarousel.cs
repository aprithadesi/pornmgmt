using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vdomgr
{
    public partial class vdocarousel : Form
    {
        private string connectionString = "server=localhost;user=root;database=vdomgr;port=3306;";
        public vdocarousel()
        {
            InitializeComponent();
        }
        public static string CleanPath(string filePath)
        {
            // Replace occurrences of \t\ with an empty string
            return filePath.Replace("\\t\\", "");
        }

        private void LoadVideoCarousel()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FilePath, ThumbnailPath FROM Videos";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable videoTable = new DataTable();
                adapter.Fill(videoTable);

                foreach (DataRow row in videoTable.Rows)
                {
                    string filePath = row["FilePath"].ToString();
                 //   string rawpath =  row["ThumbnailPath"].ToString();
                    
                    string thumbnailPath = row["ThumbnailPath"].ToString(); 

                    // Create a panel to hold each video item
                    Panel videoPanel = new Panel
                    {
                        Width = 200,
                        Height = 150,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Add thumbnail
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(thumbnailPath),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 300,
                        Height = 200,
                        Location = new Point(10, 10)
                    };
                    videoPanel.Controls.Add(pictureBox);

                    // Add play button
                    Button playButton = new Button
                    {
                        Text = "Play",
                        Tag = filePath,
                        Width = 60,
                        Height = 30,
                        Location = new Point(70, 120)
                    };
                    playButton.Click += PlayButton_Click;
                    videoPanel.Controls.Add(playButton);

                    // Add the panel to the FlowLayoutPanel
                    flowLayoutPanelCarousel.Controls.Add(videoPanel);
                }
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Button playButton = sender as Button;
            string filePath = playButton.Tag.ToString();
            System.Diagnostics.Process.Start(filePath);
        }

        private void vdocarousel_Load(object sender, EventArgs e)
        {
            LoadVideoCarousel();
        }
    }
}
