using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class GenericList<T> : IGenericList<T>
    {
        private T[] _internalStorage = new T[4];
        private int count = 0;
        public int Count => count;
        public GenericList()
        {
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                _internalStorage[i] = default(T);
            }
        }

        public GenericList(int initialSize)
        {
            T[] helperList = new T[initialSize];
            for (int i = 0; i < initialSize; i++)
            {
                helperList[i] = default(T);
            }

            _internalStorage = helperList;
        }
        public void Add(T item)
        {
            count++;
            int currentElementNumber = _internalStorage.Length;
            //Ako dođe do prekoračenja defaultne vrijednosti veličine spremnika//
            if (count > currentElementNumber)
            {
                int index = 0;
                T[] helperArray = new T[2 * currentElementNumber];
                for (int i = 0; i < helperArray.Length; i++)
                {
                    helperArray[i] = default(T);
                }
                for (int i = 0; i < currentElementNumber; i++)
                {
                    helperArray[i] = _internalStorage[i];
                    index++;

                }
                helperArray[index] = item;
                _internalStorage = helperArray;
                return;
            }
            //U suprotnom//
            for (int i = 0; i < currentElementNumber; i++)
            {
                if (_internalStorage[i].Equals(default(T)))
                {
                    _internalStorage[i] = item;
                    return;
                }
                else
                {
                    continue;
                }
            }
        }
        public bool Remove(T item)
        {
            int index = 0;
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    index = i;
                    break;
                }

                index = -1;

            }
            if (index > 0)
            {
                for (int i = index; i < _internalStorage.Length - 1; i++)
                {
                    _internalStorage[i] = _internalStorage[i + 1];
                }
                count--;
                return true;
            }
            return false;

        }

        public bool RemoveAt(int index)
        {
            if (_internalStorage[index].Equals(default(T)))
            {
                return false;
            }
            for (int i = index; i < _internalStorage.Length - 1; i++)
            {


                _internalStorage[i] = _internalStorage[i + 1];


            }
            count--;
            return true;

        }

        public T GetElement(int index)
        {
            return (T)_internalStorage[index];
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                if (_internalStorage[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public void Clear()
        {
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                if (_internalStorage[i] != null)
                {
                    _internalStorage[i] = default(T);
                    count--;
                }
            }
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
