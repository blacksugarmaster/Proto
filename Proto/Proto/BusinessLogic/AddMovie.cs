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
        public static bool addMovie(string title, string director, List<string> cast, string imagename, string year, List<string> genre, string age)
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
            if (title.Trim().Length > 0)
            {
                movie.title = title;
            }
            if (title.Trim().Length > 0)
            {
                movie.title = title;
            }
            if (title.Trim().Length > 0)
            {
                movie.title = title;
            }
            if (title.Trim().Length > 0)
            {
                movie.title = title;
            }

            return false;
        }
    }
}
