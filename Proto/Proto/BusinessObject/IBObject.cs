using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proto.BusinessObject
{
    public interface IBObject
    {
        bool save();
        bool update();

        bool remove(IBObject obj);
    }
}
