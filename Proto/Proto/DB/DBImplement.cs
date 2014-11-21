using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proto.BusinessObject;
using System.Data.SqlServerCe;


namespace Proto.DB
{
    class DBImplement : IDB
    {
        string movie = "CREATE TABLE Movie(id NCHAR(100) PRIMARY KEY NOT NULL,title NCHAR(100),year int,age int,genre int,imagename NCHAR(100),list NCHAR(100), FOREIGN KEY(list) REFERENCES MovieList(id));";
        string movieList = "CREATE TABLE MovieList(id NCHAR(100) PRIMARY KEY NOT NULL,name NCHAR(100), list NCHAR(100), FOREIGN KEY(list) REFERENCES Lists(id));";
        
        string lists = "CREATE TABLE Lists(id NCHAR(100) PRIMARY KEY NOT NULL);";
        
        string movieCast = "CREATE TABLE MovieCast(id NCHAR(100),actor NCHAR(100),PRIMARY KEY (id,actor),FOREIGN KEY(id) REFERENCES Movie(id));";

        string dropMovie = "DROP TABLE [Movie];";
        string dropMovieList = "DROP TABLE [MovieList];";
        string dropLists = "DROP TABLE [Lists];";
        string dropMovieCast = "DROP TABLE [movieCast];";

        // set when application is loaded
        public static DBImplement proxy;

        static SqlCeConnection con=null;
        SqlCeCommand cmd;

        private void ExecuteQuery(string query)
        {
            try
            {
                con.Open();
                cmd = new SqlCeCommand(query, con);
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
                string fileName = "MODB.sdf";
                con = new SqlCeConnection(@"Data Source=|DataDirectory|\" + fileName);

            }
            catch (Exception e)
            {
                reportError(e);
            }
        }

        public bool reset()
        {
            try
            {
                ExecuteQuery(dropMovieCast);
                ExecuteQuery(dropMovie);
                ExecuteQuery(dropMovieList);
                ExecuteQuery(dropLists);
                
                ExecuteQuery(lists);
                ExecuteQuery(movieList);
                ExecuteQuery(movie);
                ExecuteQuery(movieCast);
            }
            catch(Exception e)
            {
                reportError(e);
            }
            return true;

        }

        public bool saveMovie(Movie movie)
        {
            string q = "INSERT INTO Movie(id,title,year,age,genre,imagename)" +
                        "VALUES(@id,@title,@year,@age,@genre,@imagename)";
            cmd = new SqlCeCommand(q, con);
            cmd.Parameters.AddWithValue("@id", movie.id);
            cmd.Parameters.AddWithValue("@title", movie.title);
            cmd.Parameters.AddWithValue("@year", movie.year);
            cmd.Parameters.AddWithValue("@age", movie.age);
            cmd.Parameters.AddWithValue("@genre", (int)movie.genre);
            cmd.Parameters.AddWithValue("@imagename", movie.imageName);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
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
            return new Movie("new movie!", 2014, 12, (int)EGenre.Action, "someImage.jpg");
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
