using System;
using System.Collections.ObjectModel;
using Module3HW1.Helpers;

namespace Module3HW1
{
    public class Starter
    {
        public void Run()
        {
            var arrayInit = new[]
            {
                4,
                5,
                6,
                1,
                2,
            };
            var myList = new MyList<int>(arrayInit);
            var itemToRemove = 1;
            myList.Remove(itemToRemove);
            myList.RemoveAtIndex(3);
            myList.Add(10);
            myList.Add(10);
            myList.Add(10);
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            myList.Sort(new MyListComparer<int>());
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"capacity {myList.Capacity}");
        }
    }
}
