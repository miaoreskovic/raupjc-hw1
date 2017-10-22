using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int _lastIndex;

        private int size;
        public IntegerList()
        {
            _internalStorage = new int[3];
            _lastIndex = -1;
            size = 3;
        }

        public IntegerList(int initialSize)
        {
            _internalStorage = new int[initialSize - 1];
            _lastIndex = -1;
            size = initialSize - 1;
        }

        public int Count { get => _lastIndex + 1; }


        public void Add(int item)
        {

            if (_lastIndex == size - 1)
            {

                int[] internalStorage = new int[2 * size];
                _internalStorage.CopyTo(internalStorage, 0);

                _internalStorage = internalStorage;
                size *= 2;
            }
            _internalStorage[_lastIndex + 1] = item;
            _lastIndex++;
        }

        public void Clear()
        {
            _lastIndex = -1;
        }

        public bool Contains(int item)
        {

            if (_lastIndex == -1) return false;
            for (int i = 0; i < size; i++)
            {
                if (_internalStorage[i] == item) return true;
            }
            return false;
        }

        public int GetElement(int index)
        {

            if (index <= size) return _internalStorage[index];
            else throw new IndexOutOfRangeException();
        }

        public int IndexOf(int item)
        {

            for (int i = 0; i < size; i++)
            {
                if (_internalStorage[i] == item) return i;
            }
            return -1;
        }

        public bool Remove(int item)
        {

            int indexOf;
            for (int i = 0; i < size; i++)
            {
                if (_internalStorage[i] == item)
                {
                    indexOf = IndexOf(item);
                    if (indexOf > -1) return RemoveAt(indexOf);

                }
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            int[] internalStorage = new int[size];
            if (index > size) throw new IndexOutOfRangeException();
            for (int i = index; i + 1 < size; i++)
            {

                _internalStorage[i] = _internalStorage[i + 1];
            }
            _lastIndex--;
            return true;
        }
    }
}

