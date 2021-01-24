using HashTabl.Model3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTabl
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHashTable<Person> superHashTable = new SuperHashTable<Person>(100);
            Person person = new Person() { Name = "Вася", Age = 25, Gender = 0 };

            superHashTable.Add(new Person() { Name = "Петя", Age = 35, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Андрей", Age = 15, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Катя", Age = 18, Gender = 1 });
            superHashTable.Add(person);

            Console.WriteLine(superHashTable.Search(new Person() { Name = "Вася", Age = 25, Gender = 0 }));
            Console.WriteLine(superHashTable.Search(person));

            /*Model2.HashTable<int, string> hashTable = new Model2.HashTable<int, string>(100);
            hashTable.Add(5, "Привет");
            hashTable.Add(18, "Мир");
            hashTable.Add(777, "Здравствуйте");
            hashTable.Add(7, "Программист");

            Console.WriteLine(hashTable.Search(6, "Вася"));
            Console.WriteLine(hashTable.Search(18, "Мир"));*/

            Console.ReadLine();
        }
    }
}
