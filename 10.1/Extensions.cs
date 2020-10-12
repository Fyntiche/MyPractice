using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _10._1
{
    internal static class Extensions
    {
        internal static T[] GetArray<T>(this MyList<T> list)
        {
            var temp = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                temp[i] = list[i];
            }
            return temp;
        }
    }
}