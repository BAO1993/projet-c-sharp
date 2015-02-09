using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjectViewer
{
    class Photo
    { 
         #region Properties
        public String cat { get;set; }
        public String rating{get;set;}
        public String commentaires{get;set;}
        public DateTime dateprise { get; set; }
       
        #endregion Properties

        #region Constructeur

        public Photo()
        {
        }

        #endregion Constructeur



        public class XmlPhoto
        {
            String Filename;
            public static XmlSerializer xs = new XmlSerializer(typeof(Photo[]));

            public static bool Save(String Filename, Photo[] photos)
            {
                try
                {
                    using (StreamWriter wr = new StreamWriter(Filename))
                    {
                        xs.Serialize(wr, photos); // Serialize the array
                    }
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }

            public static Photo[] Load(String Filename)
            {
                try
                {
                    using (StreamReader rd = new StreamReader(Filename))
                    {
                        return xs.Deserialize(rd) as Photo[]; //deserialize
                    }
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }




    
    }
}
