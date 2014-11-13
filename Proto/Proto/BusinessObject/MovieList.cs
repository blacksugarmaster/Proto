using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proto.BusinessObject
{
    class MovieList : List<Movie>, IBObject
    {



        public bool save()
        {
            return false;
        }

        public bool remove(IBObject obj)
        {
            return false;
        }
    }
}
