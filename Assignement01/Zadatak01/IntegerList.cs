using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class IntegerList : IIntegerList
    {
        private int?[] _internalStorage = new int?[4];
        private int count = 0;
        public int Count => count;
        public IntegerList()
        {
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                _internalStorage[i] = null;
            }
        }

        public IntegerList(int initialSize)
        {
            int?[] helperList = new int?[initialSize];
            for (int i = 0; i < initialSize; i++)
            {
                helperList[i] = null;
            }

            _internalStorage = helperList;
        }
        public void Add(int item)
        {
            count++;
            int currentElementNumber = _internalStorage.Length;
            //Ako dođe do prekoračenja defaultne vrijednosti veličine spremnika//
            if (count > currentElementNumber)
            {
                int index = 0;
                int?[] helperArray = new int?[2 * currentElementNumber];
                for (int i = 0; i < helperArray.Length; i++)
                {
                    helperArray[i] = null;
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
                if (_internalStorage[i] == null)
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
        public bool Remove(int item)
        {
            int index = 0;
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                if (_internalStorage[i] == item)
                {
                    index = i;
                    break;
                }

                index = -1;

            }
            if (index > 0)
            {
                for (int i = index; i < _internalStorage.Length-1; i++)
                {
                    _internalStorage[i] = _internalStorage[i + 1];
                }
                count--;
                return true;
            }
            return false;

            }

        public bool RemoveAt (int index)
        {
            if(_internalStorage[index] == null)
            {
                return false;
            }
            for (int i = index; i < _internalStorage.Length-1; i++)
            {
               
                
                    _internalStorage[i] = _internalStorage[i + 1];
                

            }
            count--;
            return true;

        }

        public int GetElement(int index)
        {
            return (int)_internalStorage[index];
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i <_internalStorage.Length; i++)
            {
                if (item == _internalStorage[i])
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
                    _internalStorage[i] = null;
                    count--;
                }
            }
        }

        public bool Contains(int item)
        {
            foreach(int i in _internalStorage)
            {
                if (i == item)
                    return true;
            }
            return false;
        }

    }
}
