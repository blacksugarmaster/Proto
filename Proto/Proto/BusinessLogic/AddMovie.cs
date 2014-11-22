using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proto.BusinessObject;

namespace Proto.BusinessLogic
{
    class AddMovie
    {
        public static bool addMovie(string title, string director, string year,string age,List<string> genre,string imagename,List<string> cast)
        {
            Movie movie = new Movie();

            if(title.Trim().Length > 0)
            {
                movie.title = title;
            }
            if (director.Trim().Length > 0)
            {
                movie.director = director;
            }
            if (imagename.Trim().Length > 0)
            {
                movie.imageName = imagename;
            }
            if (year.Trim().Length > 0)
            {
                movie.year = Int32.Parse(year);
            }
            if (age.Trim().Length > 0)
            {
                movie.age = Int32.Parse(age);
            }

            movie.genre = genre;
            movie.cast = cast;

            return movie.save(); ;
        }
    }
}
