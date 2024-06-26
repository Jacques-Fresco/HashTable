﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTabl.Model1
{
    class BadHashTable<T>
    {
        private T[] items;
        public BadHashTable(int size) { items = new T[size]; }
        public void Add(T item)
        {
            int key = GetHash(item);
            items[key] = item;
        }
        public bool Search(T item)
        {
            int key = GetHash(item);
            return items[key].Equals(item);
        }
        private int GetHash(T item)
        {
            return item.ToString().Length % items.Length;
        }
    }
}
