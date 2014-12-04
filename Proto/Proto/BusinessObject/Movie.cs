using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proto.BusinessObject
{
    public class Movie : IBObject
    {
        public string id { get; set; }
        public string title { get; set; }
        public string director { get; set; }
        public int year { get; set; }
        public string age { get; set; }
        public List<string> genre { get; set; }
        public string imageName { get; set; }
        public int length { get; set; }

        public List<string> cast {get;set;}


        // image path = imageBasepath + imageFileName.ext
        private string imageBasePath = AppDomain.CurrentDomain.BaseDirectory+"resource/image/";
        public Movie(string id, string title, string director, int year, string age, List<string> genre, string imageName, List<string> cast, int length)
        {
            this.id = id;
            this.title = title;
            this.director = director;
            this.year = year;
            this.age = age;
            this.genre = genre;
            this.imageName = imageName;
            this.cast = cast;
            this.length = length;
        }

        public Movie(string title, string director, int year, string age, List<string> genre, string imageName, List<string> cast, int length)
        {
            id = Guid.NewGuid().ToString();
            // constructor
            this.title = title;
            this.director = director;
            this.year = year;
            this.age = age;
            this.genre = genre;
            this.imageName = imageName;
            this.cast = cast;
            this.length = length;
        }

        public Movie(string id)
        {
            List<string> dum = new List<string>();
            dum.Add(" ");

            // base constructor, set any value as needed
            this.id = id;
            this.title = "";
            this.director = "";
            this.year = -1;
            this.age = "";
            this.genre = dum;
            this.imageName = "";
            this.cast = dum;
            this.length = -1;
        }

        public Movie()
        {
            List<string> dum = new List<string>();
            dum.Add(" ");

            // base constructor, set any value as needed
            id = Guid.NewGuid().ToString();
            this.title = "";
            this.director = "";
            this.year = -1;
            this.age = "";
            this.genre = dum;
            this.imageName = "";
            this.cast = dum;
            this.length = -1;
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

        public bool remove()
        {
            return DB.DBImplement.proxy.deleteMovie(this);
        }


        public bool update()
        {
            try
            {
                DB.DBImplement.proxy.updateMovie(this);
            }
            catch (Exception e)
            {

            }

            return true;
        }


    }


}
