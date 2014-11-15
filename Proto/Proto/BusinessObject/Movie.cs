using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proto.BusinessObject
{
    class Movie : IBObject
    {
        String id;
        // class vars, with getter setter
        string title;
        List<string> cast;
        int year;
        int age;
        int genre;
        Image poster;

        // image path = imageBasepath + imageFileName.ext
        private string imageBasePath = AppDomain.CurrentDomain.BaseDirectory+"resource/image/";

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
