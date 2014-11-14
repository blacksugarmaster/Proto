using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proto.BusinessObject
{
    class Movie : IBObject
    {
        String id;
        // class vars, with getter setter
        string title {get; set;}
        List<string> cast { get; set; }
        int year;
        int age;
        int genre;
        

        public Movie()
        {
            id = Guid.NewGuid().ToString();
            // constructor
        }


        public bool save()
        {
            throw new NotImplementedException();
        }

        public bool remove(IBObject obj)
        {
            throw new NotImplementedException();
        }


        public IBObject parse()
        {
            throw new NotImplementedException();
        }
    }


}
