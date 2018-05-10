using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bihil
{
    public interface IManupulate<T> where T: IComparable
    {
        int Add(T obj1, T obj2);
    }
}
