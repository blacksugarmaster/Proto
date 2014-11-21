using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proto.BusinessObject;

namespace Proto.DB
{
    interface IDB
    {
        bool reset();

        // ------- insert--------
        bool saveMovie(Movie movie);
        bool saveMovieList(MovieList movieList);

        // ------- getter ------------
        Movie getMovieById(String id);
        MovieList getMovieListById(String id);
        MovieList getAllMovie(); // just return a MovieList that contains all movie in DB
        MovieList getMovieByCast(String cast);

        // -------- update -----------
        bool updateMovie(Movie movie);
        bool updateMovieList(MovieList movieList);

    }
}
