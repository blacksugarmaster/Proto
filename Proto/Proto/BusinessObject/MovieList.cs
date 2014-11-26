using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proto.BusinessObject
{
    class MovieList : List<Movie>, IBObject
    {
        public String id {get;set;}
        public String name { get; set; }
        
        public MovieList(String name)
        {
            id = Guid.NewGuid().ToString();
            this.name = name;
        }
        public MovieList(string id, String name)
        {
            this.id = id;
            this.name = name;
        }
        public MovieList()
        {
            // TODO: Complete member initialization
        }


        public bool save()
        {
            try
            {
                DB.DBImplement.proxy.saveMovieList(this);
            }
            catch(Exception e)
            {

            }
            return true ;
        }

        public bool remove(IBObject obj)
        {
            return false;
        }


        public bool update()
        {
            throw new NotImplementedException();
        }



        public IBObject clone()
        {
            throw new NotImplementedException();
        }
    }
}
