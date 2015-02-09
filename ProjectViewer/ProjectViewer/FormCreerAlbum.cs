using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectViewer
{
    public partial class FormCreerAlbum : Form
    {
        private Album album;
        public FormCreerAlbum(Album album)
        {
            this.album = album;
            InitializeComponent();
        }

        private void FormCreerAlbum_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_addPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog addPhoto = new OpenFileDialog();
            if (addPhoto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PictureDetails details = new PictureDetails();
                details.PhotoTitle = addPhoto.FileName;
                details.PictureBox1 = addPhoto.FileName;
                flowLayoutPanel1.Controls.Add(details);

                album.pictures.Add(new Picture(addPhoto.FileName));
            }
        }


    }
}
