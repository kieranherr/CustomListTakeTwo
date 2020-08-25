using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T[] _items;
        private int _capacity;
        private int _count;

        public int Count
        {
            get
            {
                return _count;
            }
        }
        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }
        public void Add(T item)
        {
            if(_count == _capacity)
            {
                T[] tempArray = new T[_capacity * 2];
                for(int i = 0; i < _capacity; i++)
                {
                    tempArray[i] = _items[i];
                }
                for(int i = 0; i < _count; i++)
                {
                    _items = new T[_capacity * 2];
                    _items[i] = tempArray[i];
                }
                _items[_count++] = item;
                _count++;
                _capacity = _capacity * 2;
            }
            else
            {
                _items[_count] = item;
                _count++;
            }
            
        }
    }
}
