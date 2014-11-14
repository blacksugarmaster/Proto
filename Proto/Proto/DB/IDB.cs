using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using Proto.BusinessObject;

namespace Proto.DB
{
    interface IDB
    {
        bool reset();

        // ------- insert--------
        bool saveMovie(Movie movie);
        bool saveMovieList(MovieList movieList);
        bool saveLists(Lists lists);

        // ------- getter ------------
        Movie getMovieById(String id);
        MovieList getMovieListById(String id);
        Lists getListsById(String id); // getting all movie list in the Lists

        List<Lists> getAllLists(); // getting all Lists
        MovieList getAllMovie(); // just return a MovieList that contains all movie in DB

        MovieList getMovieByCast();


        // -------- update -----------
        bool updateMovie(Movie movie);
        bool updateMovieList(MovieList movieList);
        bool updateLists(Lists list);


    }
}
