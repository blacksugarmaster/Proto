using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proto.BusinessObject
{
    class Lists : List<MovieList>, IBObject
    {
        // wrapper class, Lists contains list of MovieList class

        public List<MovieList> list = new List<MovieList>();

        public Lists()
        {
            // constructor

            // any initialization

        }




        public bool save()
        {
            return false;
        }

        bool IBObject.remove(IBObject obj)
        {
            return false;
        }


        public IBObject parse()
        {
            throw new NotImplementedException();
        }
    }
}
