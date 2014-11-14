using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proto.BusinessObject
{
    class MovieList : List<Movie>, IBObject
    {
        String id;
        String listName;
        public MovieList(String listName)
        {
            id = Guid.NewGuid().ToString();
            this.listName = listName;
        }

        public MovieList()
        {

        }


        public bool save()
        {
            return false;
        }

        public bool remove(IBObject obj)
        {
            return false;
        }


        public IBObject parse()
        {
            throw new NotImplementedException();
        }
    }
}
