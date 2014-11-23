using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proto.BusinessObject;
using Proto.BusinessLogic;

namespace Proto.DB
{
    class DBtest
    {

        public static void testAddMovie()
        {
            List<string> cast = new List<string>();
            cast.Add("cast1");
            cast.Add("cast2");

            List<string> genre = new List<string>();
            genre.Add(Genre.getString(0));
            genre.Add(Genre.getString(3));

            // full object
            Movie dummy = new Movie("new movie!", "GOOD", 2014, "12", genre, "someImage.jpg", cast);
            dummy.save();

            // partial object
            Movie dummy2 = new Movie();
            dummy2.title = "WhatIS";
            dummy2.save();

            // logic test
            AddMovie.addMovie("BusinessLogic", "GOOD", "2015", "12", genre, "someImage.jpg", cast);
        }
    }



}
