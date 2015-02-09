using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectViewer
{
    public class Album
    {

        
        public List<Picture> pictures;
        private String title;
        private DateTime date;
        private String subTitle;

        public Album()
        {
            pictures = new List<Picture>();
        }
        public String Title
        {
            get;
            set;

        }
        public String SubTitle
        {
            get;
            set;
        }


    }
}
