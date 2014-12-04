using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proto.BusinessObject;

namespace Proto.BusinessLogic
{
    class MovieListLogic
    {
        public static bool addMovieList(string name)
        {
            MovieList newlist = new MovieList(name);
            

            return newlist.save();
        }

        public static bool renameMovieList(MovieList list, string newName)
        {
            return false;
        }

        public static bool editMovieList(MovieList list)
        {
            return false;
        }

        public static List<MovieList> getAll()
        {
            return DB.DBImplement.proxy.getAllMovieList();
        }
        
    }
}
