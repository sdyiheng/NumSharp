﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumSharp.Extensions
{
    public static partial class NDArrayExtensions
    {
        public static NDArray<T> Delete<T>(this NDArray<T> np,  IEnumerable<T> delete)
        {            
            var np1 = np.array(np.Data.Where(x => !delete.Contains(x)));
            np1.Shape = new Shape(new int[] { np.Data.Length });

            return np1;
        }
    }
}
