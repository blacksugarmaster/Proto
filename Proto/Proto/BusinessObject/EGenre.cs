using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proto.BusinessObject
{
    enum EGenre
    {
        SciFi,
        Drama,
        Action,
        Thriller
    }

    public class Genre
    {
        public static string getString(int type)
        {
            string res = "Unknown";
            switch( type )
            {
                case 0:
                    res = "Sci-Fi";
                    break;
                case 1:
                    res = "Drama";
                    break;
                case 2:
                    res = "Action";
                    break;
                case 3:
                    res = "Thriller";
                    break;

            }

            return res;
        }
    }
}
