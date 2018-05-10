
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bihil
{
    public class Manupulate<T>: IManupulate<T> where T: IComparable
    {
        private static Manupulate<T> instance = null;
        private static readonly object padlock = new object();

        Manupulate()
        {
        }

        public static Manupulate<T> Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Manupulate<T>();
                    }
                    return instance;
                }
            }
        }

        public int Add(T obj1, T obj2)
        {
         
            return obj2.CompareTo(obj2);
        }
    }
}
