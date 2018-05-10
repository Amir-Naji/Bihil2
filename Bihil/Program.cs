
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bihil
{
    class Program
    {
        static void Main(string[] args)
        {
            IManupulate<string> mString = Manupulate<string>.Instance;
            IManupulate<int> mInteger = Manupulate<int>.Instance;

            Console.WriteLine(mString.Add("1", "3"));
            Console.WriteLine(mInteger.Add(5, 7));
              
        }
    }
}
