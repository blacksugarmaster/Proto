using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proto.BusinessObject
{
    class Movie : IBObject
    {
        public String id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public int age { get; set; }
        public int genre { get; set; }
        public string imageName { get; set; }

        public List<string> cast {get;set;}

        Image poster;

        // image path = imageBasepath + imageFileName.ext
        private string imageBasePath = AppDomain.CurrentDomain.BaseDirectory+"resource/image/";

        public Movie(string title, int year, int age, int genre, string imageName, List<string> cast)
        {
            id = Guid.NewGuid().ToString();
            // constructor
            this.title = title;
            this.year = year;
            this.age = age;
            this.genre = genre;
            this.imageName = imageName;
            this.cast = cast;
        }


        public bool save()
        {
            try
            {
                DB.DBImplement.proxy.saveMovie(this);
            }
            catch (Exception e)
            {

            }

            return true;
        }

        public bool remove(IBObject obj)
        {
            throw new NotImplementedException();
        }


        public IBObject parse()
        {
            throw new NotImplementedException();
        }
    }


}
