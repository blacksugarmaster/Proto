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
                    gen += "OR";
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
                castWhere += " cast LIKE '%" + cast + "%'";
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
                gen = " AND " +gen;
            }

            
            return DB.DBImplement.proxy.searchMovie(whereString, castWhere, gen);
        }
    }
}
