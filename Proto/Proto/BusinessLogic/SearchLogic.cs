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
        public static MovieList search(string title, string director, string cast, List<string> genre, List<string> rating, int length)
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

            if(!string.IsNullOrWhiteSpace(length.ToString()))
            {
                if(! (int.MaxValue == length))
                {
                    if (!string.IsNullOrWhiteSpace(whereString))
                    {
                        whereString += " AND ";
                    }
                    whereString += "length > 0 AND length <=" + length;
                }
            }



            string gen = string.Empty;
            int i = 0;
            foreach(string g in genre)
            {
                if(!string.IsNullOrWhiteSpace(gen))
                {
                    i++;
                    gen += " OR EXISTS ( SELECT * FROM [MovieGenre] AS mg"+i.ToString()+" WHERE mg"+i.ToString() +".id = Movie.id AND "+ "genre = '" + g + "')";
                }
                else
                {

                    gen += "genre = '" + g + "'";
                }
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
                gen = " AND " + gen;
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
            int i = 0;
            foreach (string g in genre)
            {
                if (!string.IsNullOrWhiteSpace(gen))
                {
                    i++;
                    gen += " AND EXISTS ( SELECT * FROM [MovieGenre] AS mg" + i.ToString() + " WHERE mg" + i.ToString() + ".id = Movie.id AND " + "genre = '" + g + "')";
                }
                else
                {

                    gen += "genre = '" + g + "'";
                }
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
            MovieList curr = new MovieList();
            MovieList res = new MovieList();
            curr.Add(movie);

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
                    if(!m.id.Equals(movie.id))
                    {
                        res.Add(m);
                    }
                }
            }
            curr.AddRange(res);

            res.Clear();
            if(sameGenre!=null)
            {
                foreach (Movie m in sameGenre)
                {
                    foreach(Movie inList in curr)
                    {
                        if(!m.id.Equals(inList.id))
                        {
                            res.Add(m);
                            break;
                        }
                    }
                }
            }
            curr.AddRange(res);


            res.Clear();
            if(sameCast!=null)
            {
                foreach (Movie m in sameCast)
                {
                    foreach (Movie inList in curr)
                    {
                        if (!m.id.Equals(inList.id))
                        {
                            res.Add(m);
                            break;
                        }
                    }
                }
            }
            curr.AddRange(res);

            
            foreach(Movie m in curr)
            {
                if(m.id.Equals(movie.id))
                {
                    curr.Remove(m);
                    break;
                }
            }
            foreach (Movie m in curr)
            {
                if (m.id.Equals(movie.id))
                {
                    curr.Remove(m);
                    break;
                }
            }

            return curr;
        }
    }
}
