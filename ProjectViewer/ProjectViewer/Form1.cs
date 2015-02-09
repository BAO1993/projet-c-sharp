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
    public partial class Form1 : Form
    {
        private List<Album> album;
        FormCreerAlbum formCreerAlbum;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_creerAlbum_Click(object sender, EventArgs e)
        {
            formCreerAlbum = new FormCreerAlbum();
            if (formCreerAlbum.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }

        }

    }
}
