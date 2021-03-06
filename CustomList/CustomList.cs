﻿using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        T[] _items;
        private int _capacity;
        private int _count;

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i<_count; i++)
            {
                yield return _items[i];
            }
        }



        public void Zip(CustomList<T> list1)
        {
            // tempArray[0] = _items[0]
            // temparray[1] = list1[0]
            //tempArray[2] = _items[1]
            //tempArray[3] =  list1[1]\
            int j = 0;
            T[] tempArray = new T[_capacity + list1.Capacity];
            for(int i =0; i<_count; i++)
            {
                tempArray[j] = _items[i];
                j++;
               
                tempArray[j] = list1[i];
                j++;
                
            }
            _items = tempArray;
            _count = _count + list1.Count;
            _capacity = _capacity + list1.Capacity;
        }
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
        public T this[int i]
        {
            get
            {
                if (i <= _count && i >= 0)
                {
                    return _items[i];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                    
                }
            }
            set
            {
                if (i <= _count && i >= 0)
                {
                    _items[i] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();

                }
                
            }
        }
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> tempArray = new CustomList<T>();
            for(int i = 0; i<list1.Count; i++)
            {
                tempArray.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                tempArray.Add(list2[i]);
            }
            return tempArray;

        }
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            for (int i = 0; i < list2.Count; i++)
            {
                for (int j = 0; j < list1.Count; j++)
                {
                    if(list1[j].Equals(list2[i]))
                    {
                        list1.Remove(list2[i]);
                    }
                }
            }
            return list1;
        }
        public override string ToString()
        {
            return String.Concat(_items);
        }
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _items = new T[_capacity];
        }
        public void Add(T item)
        {
            if (_count == _capacity)
            {
                T[] tempArray = new T[_capacity * 2];
                for (int i = 0; i < _capacity; i++)
                {
                    tempArray[i] = _items[i];
                }
                _items = tempArray;
                _capacity = _capacity * 2;
            }
                _items[_count] = item;
                _count++;
                
        }
        public void Remove(T item)
        {
            bool valueFound = false;
            int j = 0;
            //1. Take in value ^
            //2. Iterate thru current collection to find any values that equal the value passed in
            //3a. If we find that value, Figure out what to do with it(without calling a remove method)
            //3b. How to access and move the other values into their new correct spots
            T[] tempArray = new T[_capacity];
            for(int i = 0; i<_count; i++)
            {
                if (!valueFound)
                {
                    if (_items[i].Equals(item))
                    {
                        valueFound = true;
                        j++;
                        continue;
                    }
                    else if(_items[i].Equals(item) && i == 0)
                    {
                        valueFound = true;
                        j++;
                        continue;
                    }
                    tempArray[j] = _items[i];
                    j++;
                    continue;
                }
                tempArray[j - 1] = _items[i];
                j++;
            }
            _items = tempArray;
            _count--;
        }

       
    }
}
