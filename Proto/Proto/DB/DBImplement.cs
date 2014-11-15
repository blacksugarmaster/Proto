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
                System.Console.Write(e.StackTrace);
            }

        }

        static string s = AppDomain.CurrentDomain.BaseDirectory + "/resource/sqlite/MODB.db";
        private static string connectionString = s;//"Data Source=MODB.db";

        private static SQLiteConnection con;

        public void getConnection()
        {
            try
            {
                con = new SQLiteConnection(connectionString);
            }
            catch (Exception e)
            {
                System.Console.Out.Write(e.StackTrace);
            }

        }

        public bool reset()
        {

            string drop = "TRUNCATE TABLE Movie";

            ExecuteQuery(drop);

            return false;

        }

        public bool saveMovie(BusinessObject.Movie movie)
        {
            string s = "";
            ExecuteQuery(s);
            return false;
        }

        public bool saveMovieList(BusinessObject.MovieList movieList)
        {
            return false;

        }

        public bool saveLists(BusinessObject.Lists lists)
        {
            return false;
        }

        public BusinessObject.Movie getMovieById(string id)
        {
            return new Movie();
        }

        public BusinessObject.MovieList getMovieListById(string id)
        {
            return new MovieList();
        }

        public BusinessObject.Lists getListsById(string id)
        {
            return new Lists();
        }

        public List<BusinessObject.Lists> getAllLists()
        {
            return new List<Lists>();
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
