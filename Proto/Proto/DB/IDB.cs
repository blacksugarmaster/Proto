using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proto.BusinessObject;
using System.Data;

namespace Proto.DB
{
    interface IDB
    {
        bool reset();

        // ------- insert--------
        bool saveMovie(Movie movie);
        bool saveMovieList(MovieList movieList);
        bool setDefPath(string path);
        bool addMovieOnMovieList(Movie movie, MovieList list);

        // ------- getter ------------
        Movie getMovieById(String id);
        MovieList getMovieListById(String id);
        MovieList getAllMovie(); // just return a MovieList that contains all movie in DB
        DataTable getAllMovieDT();
        List<MovieList> getAllMovieList();
        MovieList getMovieListByName(string name);
        string getDefPath();


        // -------- update -----------
        bool updateMovie(Movie movie);
        bool renameMovieList(MovieList movieList);

        // --------- delete -----------
        bool deleteMovie(Movie movie);
        bool deleteMovieList(MovieList movieList);
        bool deleteMovieFromMovieList(Movie movie, MovieList list);

    }
}
