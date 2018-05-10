
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bihil
{
    public class Manupulate<T>: IManupulate<T>
    {
        //Sigltone
        //Factory
        //IoC

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
            var result = 0;
            switch(obj1.GetType().Name)
            {
                case "String":
                    result = Convert.ToInt32(obj1) + Convert.ToInt32(obj2);
                    break;
                case "Int32":
                    result = Convert.ToInt32(obj1) + Convert.ToInt32(obj2);
                    break;
            }
            return result;
        }
    }
}
