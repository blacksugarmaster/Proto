using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proto.BusinessObject
{
    interface IBObject
    {
        Boolean save();

        Boolean remove(IBObject obj);
    }
}
