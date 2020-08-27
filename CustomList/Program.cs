using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> test = new List<int>();
            //test.Add(5);
            //test.Remove(0);
            //Console.WriteLine(test[2]);
            //Console.ReadLine();

            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            

            list1.Add(1);
            list1.Add(3);
            list1.Add(5);


            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            list1.Zip(list2);

            for (int i = 0; i < list1.Count; i++)
            {
                Console.Write(list1[i]);
            }
            Console.ReadLine();
            //for (int i = 0; i < list2.Count; i++)
            //{
            //    Console.Write(list2[i]);
            //}
            //Console.ReadLine();

            //result.Capacity = list1.Capacity;
            //result = list1 - list2;
            //Console.ReadLine();
            //for (int i = 0; i < result.Count; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}
            //Console.ReadLine();

        }
    }
}
