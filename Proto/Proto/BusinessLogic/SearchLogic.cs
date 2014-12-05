using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proto.BusinessObject;

namespace Proto.BusinessLogic
{
    class SearchLogic
    {
        public static MovieList search(string title, string director, string cast, List<string> genre, List<string> rating)
        {
            string whereString = string.Empty;

            if (!string.IsNullOrWhiteSpace(title))
            {
                whereString += "title LIKE '%"+title+"%'";
            }

            if(!string.IsNullOrWhiteSpace(director))
            {
                if(!string.IsNullOrWhiteSpace(whereString))
                {
                    whereString += " AND ";
                }
                whereString += "director LIKE '%" + director + "%'";
            }


            string gen = string.Empty;
            foreach(string g in genre)
            {
                if(!string.IsNullOrWhiteSpace(gen))
                {
                    gen += " OR ";
                }
                gen += "genre = '" + g + "'";
            }


            string rat = string.Empty;
            foreach(string r in rating)
            {
                if (!string.IsNullOrWhiteSpace(rat))
                {
                    rat+= " OR ";
                }
                rat += "age = '" + r + "'";
            }
            if(!string.IsNullOrWhiteSpace(rat))
            {
                if(!string.IsNullOrWhiteSpace(whereString))
                {
                    whereString+=" AND ";
                }
                whereString += rat;
            }

            string castWhere = string.Empty;
            if (!string.IsNullOrWhiteSpace(cast))
            {
                castWhere += " actor LIKE '%" + cast + "%'";
            }

            if(string.IsNullOrWhiteSpace(whereString))
            {
                whereString = " EXISTS ";
            }
            else
            {
                whereString = whereString + " AND EXISTS ";

            }
            if(string.IsNullOrWhiteSpace(castWhere))
            {
                castWhere = " EXISTS ";
            }
            else
            {
                castWhere = castWhere + " AND EXISTS ";

            }
            if(!string.IsNullOrWhiteSpace(gen))
            {
                gen = " AND " +gen + " AND genre <>" + "'" + "'";
            }

            
            return DB.DBImplement.proxy.searchMovie(whereString, castWhere, gen);
        }

        public static MovieList searchExact(string title, string director, string cast, List<string> genre, List<string> rating)
        {
            string whereString = string.Empty;

            if (!string.IsNullOrWhiteSpace(title))
            {
                whereString += "title ='" + title + "' ";
            }

            if (!string.IsNullOrWhiteSpace(director))
            {
                if (!string.IsNullOrWhiteSpace(whereString))
                {
                    whereString += " AND ";
                }
                whereString += "director ='" + director + "' ";
            }


            string gen = string.Empty;
            foreach (string g in genre)
            {
                if (!string.IsNullOrWhiteSpace(gen))
                {
                    gen += " OR ";
                }
                gen += "genre ='" + g + "'";
            }


            string rat = string.Empty;
            foreach (string r in rating)
            {
                if (!string.IsNullOrWhiteSpace(rat))
                {
                    rat += " OR ";
                }
                rat += "age = '" + r + "'";
            }
            if (!string.IsNullOrWhiteSpace(rat))
            {
                if (!string.IsNullOrWhiteSpace(whereString))
                {
                    whereString += " AND ";
                }
                whereString += rat;
            }

            string castWhere = string.Empty;
            if (!string.IsNullOrWhiteSpace(cast))
            {
                castWhere += " actor ='" + cast + "' ";
            }

            if (string.IsNullOrWhiteSpace(whereString))
            {
                whereString = " EXISTS ";
            }
            else
            {
                whereString = whereString + " AND EXISTS ";

            }
            if (string.IsNullOrWhiteSpace(castWhere))
            {
                castWhere = " EXISTS ";
            }
            else
            {
                castWhere = castWhere + " AND EXISTS ";

            }
            if (!string.IsNullOrWhiteSpace(gen))
            {
                gen = " AND " + gen;
            }


            return DB.DBImplement.proxy.searchMovie(whereString, castWhere, gen);
        }
        public static MovieList searchSimilarMovies(Movie movie)
        {
            MovieList list = new MovieList();

            MovieList sameDirector = null;
            MovieList sameGenre=null;
            MovieList sameCast=null;

            List<string> gen = new List<string>();
            List<string> rat = new List<string>();

            if(!string.IsNullOrWhiteSpace(movie.director))
            {
                sameDirector = searchExact("", movie.director, "",gen, rat);
            }
            if(!string.IsNullOrWhiteSpace(movie.genre[0]))
            {
                sameGenre = searchExact("", "", "", movie.genre, rat);
            }
            
            if(!string.IsNullOrWhiteSpace(movie.cast[0]))
            {
                sameCast = searchExact("","",movie.cast[0],gen,rat);
            }

            if(sameDirector!=null)
            {
                foreach(Movie m in sameDirector)
                {
                    list.Add(m);
                }
            }
            if(sameGenre!=null)
            {
                foreach (Movie m in sameGenre)
                {
                    if(!list.Contains(m))
                    {
                        list.Add(m);
                    }
                    
                }
            }
            if(sameCast!=null)
            {
                foreach (Movie m in sameCast)
                {
                    if(!list.Contains(m))
                    {
                        list.Add(m);
                    }
                }
            }

            
            foreach(Movie m in list)
            {
                if(m.id.Equals(movie.id))
                {
                    list.Remove(m);
                    break;
                }
            }

            return list;
        }
    }
}
