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

        public static bool renameMovieList(string oldname, string newName)
        {
            MovieList list = DB.DBImplement.proxy.getMovieListByName(oldname);
            list.name = newName;
            return DB.DBImplement.proxy.renameMovieList(list);
        }


        public static bool deleteMovieList(string name)
        {
            MovieList ml = DB.DBImplement.proxy.getMovieListByName(name);

            return ml.remove();
        }

        public static bool addMovie(string listName, string mid)
        {
            MovieList ml = DB.DBImplement.proxy.getMovieListByName(listName);
            Movie movie = DB.DBImplement.proxy.getMovieById(mid);

            return DB.DBImplement.proxy.addMovieOnMovieList(movie, ml);

        }

        public static bool deleteMovie(string listName, string mid)
        {
            MovieList ml = DB.DBImplement.proxy.getMovieListByName(listName);
            Movie movie = DB.DBImplement.proxy.getMovieById(mid);

            return DB.DBImplement.proxy.deleteMovieFromMovieList(movie, ml);

        }

        public static List<MovieList> getAll()
        {
            return DB.DBImplement.proxy.getAllMovieList();
        }
        
    }
}
