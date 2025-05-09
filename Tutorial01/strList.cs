using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial01
{
    public class StrList
    {
        string[] arr;
        public StrList()
        {
            arr = new string[0];
        }

        public void Add(string s)
        {
            arr = arr.Concat(new string[] { s }).ToArray();
        }

        public void RemoveLast()
        {
            arr = arr.Take(arr.Length - 1).ToArray();
        }

    }

    public class IntList
    {
        int[] arr;
        public IntList()
        {
            arr = new int[0];
        }

        public void Add(int s)
        {
            arr = arr.Concat(new int[] { s }).ToArray();
        }

        public void RemoveLast()
        {
            arr = arr.Take(arr.Length - 1).ToArray();
        }

    }


    public class GenericList<T,H>
    {
        T[] arr;
        public GenericList()
        {
            arr = new T[0];
        }

        public void Add(T s)
        {
            arr = arr.Concat(new T[] { s }).ToArray();
        }

        public T RemoveLast()
        {
            T value = arr[arr.Length - 1];
            arr = arr.Take(arr.Length - 1).ToArray();
            return value;
        }

    }



}
