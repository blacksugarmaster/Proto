using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proto
{
    class Movie : Object
    {
        // class vars, with getter setter
        string title {get; set;}
        List<string> cast { get; set; }
        int year;
        

        public Movie()
        {
            // constructor
        }

    }


}
