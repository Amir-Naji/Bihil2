﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bihil
{
    public interface IManupulate<T>
    {
        int Add(T obj1, T obj2);
    }
}
