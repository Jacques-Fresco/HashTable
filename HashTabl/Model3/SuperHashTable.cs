using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTabl.Model3
{
    class SuperHashTable<T>
    {
        private Item<T>[] items; // объявление массива
        public SuperHashTable(int size)
        {
            items = new Item<T>[size]; // инициализируем длину и тип массива

            for(int i = 0; i < items.Length; i++)
            {
                items[i] = new Item<T>(i);
            }
        }
        public void Add(T item)
        {
            int key = GetHash(item);
            items[key].Nodes.Add(item);
        }
        public bool Search(T item)
        {
            int key = GetHash(item);
            return items[key].Nodes.Contains(item);
        }
        private int GetHash(T item)
        {
            // return Name.Length + Age + Gender + (int)Name[0];
            return item.GetHashCode() % items.Length;
        }
    }
}
