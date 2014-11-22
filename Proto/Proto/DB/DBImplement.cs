using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proto.BusinessObject;
using System.Data.SqlServerCe;
using System.Data;


namespace Proto.DB
{
    class DBImplement : IDB
    {
        string movie = "CREATE TABLE Movie(id NCHAR(100) PRIMARY KEY NOT NULL,title NCHAR(100),director NCHAR(100),year int,age int,imagename NCHAR(100));";
        string movieList = "CREATE TABLE MovieList(id NCHAR(100) PRIMARY KEY NOT NULL,name NCHAR(100), mid NCHAR(100), FOREIGN KEY(mid) REFERENCES Movie(id));";
        string movieCast = "CREATE TABLE MovieCast(id NCHAR(100),actor NCHAR(100),PRIMARY KEY (id,actor),FOREIGN KEY(id) REFERENCES Movie(id));";
        string movieGenre = "CREATE TABLE MovieGenre(id NCHAR(100),genre NCHAR(100),PRIMARY KEY (id,genre),FOREIGN KEY(id) REFERENCES Movie(id));";


        string dropMovie = "DROP TABLE [Movie];";
        string dropMovieList = "DROP TABLE [MovieList];";
        string dropMovieCast = "DROP TABLE [movieCast];";
        string dropMovieGenre = "DROP TABLE [movieGenre];";

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

                ExecuteQuery(dropMovieGenre);
                ExecuteQuery(dropMovieCast);
                ExecuteQuery(dropMovieList);
                ExecuteQuery(dropMovie);

                ExecuteQuery(movie);
                ExecuteQuery(movieList);
                ExecuteQuery(movieCast);
                ExecuteQuery(movieGenre);
                
            }
            catch(Exception e)
            {
                reportError(e);
            }
            return true;

        }

        public bool saveMovie(Movie movie)
        {
            string q = "INSERT INTO Movie(id,title,director,year,age,imagename)" +
                            "VALUES(@id,@title,@director,@year,@age,@imagename)";
            cmd = new SqlCeCommand(q, con);
            cmd.Parameters.AddWithValue("@id", movie.id);
            cmd.Parameters.AddWithValue("@title", movie.title);
            cmd.Parameters.AddWithValue("@director", movie.director);
            cmd.Parameters.AddWithValue("@year", movie.year);
            cmd.Parameters.AddWithValue("@age", movie.age);
            cmd.Parameters.AddWithValue("@imagename", movie.imageName);
            con.Open();
            cmd.ExecuteNonQuery();

            foreach(string cast in movie.cast)
            {
                string q2 = "INSERT INTO MovieCast(id,actor)" +
                            "VALUES(@id,@actor)";
                cmd = new SqlCeCommand(q2, con);
                cmd.Parameters.AddWithValue("@id", movie.id);
                cmd.Parameters.AddWithValue("@actor", cast);
                cmd.ExecuteNonQuery();
            }


            foreach (string g in movie.genre)
            {
                string q3 = "INSERT INTO MovieGenre(id,genre)" +
                            "VALUES(@id,@genre)";
                cmd = new SqlCeCommand(q3, con);
                cmd.Parameters.AddWithValue("@id", movie.id);
                cmd.Parameters.AddWithValue("@genre", g);
                cmd.ExecuteNonQuery();
            }

            con.Close();

            return true;
        }

        public bool saveMovieList(MovieList movieList)
        {
            con.Open();
            foreach(Movie movie in movieList)
            {
                string q = "INSERT INTO MovieList(id,name,mid)" +
                            "VALUES(@id,@name,@mid)";
                cmd = new SqlCeCommand(q, con);
                cmd.Parameters.AddWithValue("@id", movieList.id);
                cmd.Parameters.AddWithValue("@name", movieList.name);
                cmd.Parameters.AddWithValue("@mid", movie.id);
                cmd.ExecuteNonQuery();
            }
            con.Close();

            return false;

        }

        public Movie getMovieById(string id)
        {
            con.Open();


            string q = "SELECT *" +
                        "FROM Movie" +
                        "WHERE id = @id";
            cmd = new SqlCeCommand(q, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlCeDataAdapter sqldata = new SqlCeDataAdapter(cmd);
            DataSet data = new DataSet();
            sqldata.Fill(data,"movie");

            DataTable table = new DataTable();
            table = data.Tables["movie"];

            string mid = table.Rows[0][0].ToString();
            string title = table.Rows[0][1].ToString();
            string director = table.Rows[0][2].ToString();
            int year = System.Int32.Parse( table.Rows[0][3].ToString() );
            int age = System.Int32.Parse(table.Rows[0][4].ToString() );
            string imagename = table.Rows[0][5].ToString();


            // -------- cast -----------
            List<string> cast = new List<string>();
            string q2 = "SELECT actor" +
                        "FROM MovieCast" +
                        "WHERE id = @id";
            cmd = new SqlCeCommand(q2, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlCeDataAdapter sqldata2 = new SqlCeDataAdapter(cmd);
            DataSet data2 = new DataSet();
            sqldata.Fill(data2, "movieCast");

            DataTable table2 = new DataTable();
            table2 = data.Tables["movieCast"];

            foreach(string actor in table2.Rows)
            {
                cast.Add(actor);
            }

            // ---------- genre ------------
            List<string> genre = new List<string>();
            string q3 = "SELECT genre" +
                        "FROM MovieGenre" +
                        "WHERE id = @id";
            cmd = new SqlCeCommand(q3, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlCeDataAdapter sqldata3 = new SqlCeDataAdapter(cmd);
            DataSet data3 = new DataSet();
            sqldata.Fill(data3, "movieGenre");

            DataTable table3 = new DataTable();
            table3 = data.Tables["movieGenre"];

            foreach (string g in table3.Rows)
            {
                cast.Add(g);
            }

            Movie res = new Movie(title,director,year,age,genre,imagename,cast);


            con.Close();
            return res;
        }

        public MovieList getMovieListById(string id)
        {
            con.Open();

            string q = "SELECT mid" +
                        "FROM MovieList" +
                        "WHERE id = @id";
            cmd = new SqlCeCommand(q, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlCeDataAdapter sqldata = new SqlCeDataAdapter(cmd);
            DataSet data = new DataSet();
            sqldata.Fill(data, "list");

            DataTable table = new DataTable();
            table = data.Tables["list"];

            MovieList list = new MovieList();
            foreach(string r in table.Rows)
            {
                list.Add(getMovieById(r[0].ToString()));
            }

            con.Close();
            return list;
        }



        public MovieList getAllMovie()
        {
            con.Open();

            string q = "SELECT *" +
                        "FROM Movie";
            cmd = new SqlCeCommand(q, con);
            SqlCeDataAdapter sqldata = new SqlCeDataAdapter(cmd);
            DataSet data = new DataSet();
            sqldata.Fill(data, "movies");

            DataTable table = new DataTable();
            table = data.Tables["movie"];

            MovieList list = new MovieList();

            foreach(DataRow r in table.Rows)
            {
                string mid = r[0].ToString();
                string title = r[1].ToString();
                string director = r[2].ToString();
                int year = System.Int32.Parse(r[3].ToString());
                int age = System.Int32.Parse(r[4].ToString());
                string imagename = r[5].ToString();


                List<string> cast = new List<string>();
                string q2 = "SELECT actor" +
                            "FROM MovieCast" +
                            "WHERE id = @id";
                cmd = new SqlCeCommand(q2, con);
                cmd.Parameters.AddWithValue("@id", mid);
                SqlCeDataAdapter sqldata2 = new SqlCeDataAdapter(cmd);
                DataSet data2 = new DataSet();
                sqldata.Fill(data2, "movieCast");

                DataTable table2 = new DataTable();
                table2 = data.Tables["movieCast"];

                foreach (string actor in table2.Rows)
                {
                    cast.Add(actor);
                }



                List<string> genre = new List<string>();
                string q3 = "SELECT genre" +
                            "FROM MovieGenre" +
                            "WHERE id = @id";
                cmd = new SqlCeCommand(q3, con);
                cmd.Parameters.AddWithValue("@id", mid);
                SqlCeDataAdapter sqldata3 = new SqlCeDataAdapter(cmd);
                DataSet data3 = new DataSet();
                sqldata.Fill(data3, "movieGenre");

                DataTable table3 = new DataTable();
                table3 = data.Tables["movieGenre"];

                foreach (string g in table3.Rows)
                {
                    cast.Add(g);
                }

                Movie res = new Movie(title,director, year, age, genre, imagename, cast);
                list.Add(res);
            }
            con.Close();

            return list;
        }


        public DataTable getAllMovieDT()
        {
            con.Open();

            string q = "SELECT *" +
                        "FROM Movie";
            cmd = new SqlCeCommand(q, con);
            SqlCeDataAdapter sqldata = new SqlCeDataAdapter(cmd);
            DataSet data = new DataSet();
            sqldata.Fill(data, "movies");

            DataTable table = new DataTable();
            table = data.Tables["movie"];

            con.Close();
            return table;
        }


        public bool updateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public bool updateMovieList(MovieList movieList)
        {
            throw new NotImplementedException();
        }

        /*
        public MovieList searchMovie(string title, string year, string age, string genre, string cast)
        {

            string q = "SELECT *" +
                        "FROM Movie" +
                        "WHERE title = @title" +
                                "year <= @year" +
                                "age <= @age" +
                                "genre <= @genre" +
                        "EXISTS IN(" +
                            "SELECT cast" +
                            "FROM MovieCast" +
                            "WHERE cast LIKE '%@cast%')";
            cmd = new SqlCeCommand();
            throw new NotImplementedException();
        }
         */

    }
}
