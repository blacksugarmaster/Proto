using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Proto.BusinessObject;

namespace Proto.DB
{
    class DBImplement : IDB
    {
        // this is meant to be used under Relaese mode, since relative path problem with debug mode
        private static string s = AppDomain.CurrentDomain.BaseDirectory + "/resource/sqlite/MODB.db";
        private static string connectionString = s;//"Data Source=MODB.db";

        private static SQLiteConnection con;


        private void ExecuteQuery(string query)
        {
            try
            {
                con.Open();
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                reportError(e);
            }

        }

        private void reportError(Exception e)
        {
            System.Console.WriteLine(e.StackTrace);
        }


        public void getConnection()
        {
            try
            {
                con = new SQLiteConnection(connectionString);
            }
            catch (Exception e)
            {
                reportError(e);
            }

        }

        public bool reset()
        {

            string drop = "TRUNCATE TABLE Movie";

            ExecuteQuery(drop);

            return false;

        }

        public bool saveMovie(Movie movie)
        {
            string s = "";
            ExecuteQuery(s);
            return false;
        }

        public bool saveMovieList(MovieList movieList)
        {
            return false;

        }

        public bool saveLists(Lists lists)
        {
            return false;
        }

        public Movie getMovieById(string id)
        {
            return new Movie();
        }

        public MovieList getMovieListById(string id)
        {
            return new MovieList();
        }

        public Lists getListsById(string id)
        {
            return new Lists();
        }

        public List<Lists> getAllLists()
        {
            return new List<Lists>();
        }

        public MovieList getAllMovie()
        {
            throw new NotImplementedException();
        }

        public MovieList getMovieByCast()
        {
            throw new NotImplementedException();
        }

        public bool updateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public bool updateMovieList(MovieList movieList)
        {
            throw new NotImplementedException();
        }

        public bool updateLists(Lists list)
        {
            throw new NotImplementedException();
        }

    }
}
