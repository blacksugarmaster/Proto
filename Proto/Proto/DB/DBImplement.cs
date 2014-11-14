using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Proto.DB
{
    class DBImplement : IDB
    {
        private static string connectionString = "Data Source=MODB.db";

        private static SQLiteConnection con = new SQLiteConnection(connectionString);

        public DBImplement()
        {
            using(System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection(connectionString))
            {
                using(System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();


                    // do stuff here


                }
            }
        }



        public bool reset()
        {
            throw new NotImplementedException();
        }

        public bool saveMovie(BusinessObject.Movie movie)
        {
            throw new NotImplementedException();
        }

        public bool saveMovieList(BusinessObject.MovieList movieList)
        {
            throw new NotImplementedException();
        }

        public bool saveLists(BusinessObject.Lists lists)
        {
            throw new NotImplementedException();
        }

        public BusinessObject.Movie getMovieById(string id)
        {
            throw new NotImplementedException();
        }

        public BusinessObject.MovieList getMovieListById(string id)
        {
            throw new NotImplementedException();
        }

        public BusinessObject.Lists getListsById(string id)
        {
            throw new NotImplementedException();
        }

        public List<BusinessObject.Lists> getAllLists()
        {
            throw new NotImplementedException();
        }

        public BusinessObject.MovieList getAllMovie()
        {
            throw new NotImplementedException();
        }

        public BusinessObject.MovieList getMovieByCast()
        {
            throw new NotImplementedException();
        }

        public bool updateMovie(BusinessObject.Movie movie)
        {
            throw new NotImplementedException();
        }

        public bool updateMovieList(BusinessObject.MovieList movieList)
        {
            throw new NotImplementedException();
        }

        public bool updateLists(BusinessObject.Lists list)
        {
            throw new NotImplementedException();
        }
    }
}
