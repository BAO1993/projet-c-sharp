using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectViewer
{
    public class Picture
    {

        public List<String> comments;
        private String category;
        private String path;
        private float rating;

        public Picture(String path)
        {
            this.path = path;
        }

        public String Path
        {
            get;
            set;
        }
        public String Category
        {
            get;
            set;
        }
        public float Rating
        {
            get;
            set;
        }
        private DateTime pictureDate;
        public DateTime PictureDate
        {
            get;
            set;
        }

    }
}
