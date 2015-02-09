using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectViewer
{
    public partial class PictureDetails : UserControl
    {

        public PictureDetails()
        {
            InitializeComponent();
        }

        public String PhotoTitle
        {
            get { return photoTitle.Text; }
            set { photoTitle.Text = value; }
        }
        public String PictureBox1
        {
            get { return pictureBox1.ImageLocation; }
            set { pictureBox1.ImageLocation = value.ToString(); }
        }


    }
}
