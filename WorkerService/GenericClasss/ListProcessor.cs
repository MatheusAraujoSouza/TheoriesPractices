using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService.GenericClasss
{
    public class ListProcessor<T>
    {
        private List<T> _list;
        public ListProcessor(List<T> list)
        {
            _list = list;
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Remove(T item)
        {
            _list.Remove(item);
        }

        public void DisplayItems()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
        }

        public void Sort()
        {
            _list.Sort();
        }

        public void Sort(IComparer<T> comparer)
        {
            _list.Sort(comparer);
        }

        public void FilterAndDisplay(Predicate<T> predicate)
        {
            foreach (var item in _list)
            {
                if (predicate(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
