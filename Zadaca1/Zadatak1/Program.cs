using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{

    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;

        //private int[] internalStorage;
        int lastIndex;

        public IntegerList()
        {
            _internalStorage = new int [3];
            lastIndex = 0;
        }

        public IntegerList(int initialSize)
        {
            if (initialSize >= 0) _internalStorage = new int [initialSize];
            else Console.WriteLine("Error occured, input must be greater than -1");
            lastIndex = 0;
        }




        public void Add(int item)
        {
            Console.WriteLine(lastIndex);

        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public int GetElement(int index)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }
    }

    public interface IIntegerList
    {
        /// <summary >
        /// Adds an item to the collection .
        /// </ summary>
        void Add(int item);

        /// <summary >
        /// Removes the first occurrence of an item from the collection .
        /// If the item was not found , method does nothing and returns false .
        /// </ summary >
        bool Remove(int item);

        /// <summary >
        /// Removes the item at the given index in the collection .
        /// Throws IndexOutOfRange exception if index out of range .
        /// </ summary >
        bool RemoveAt(int index);

        /// <summary >
        /// Returns the item at the given index in the collection .
        /// Throws IndexOutOfRange exception if index out of range .
        /// </ summary >
        int GetElement(int index);

        /// <summary >
        /// Returns the index of the item in the collection .
        /// If item is not found in the collection , method returns -1.
        /// </ summary >
        int IndexOf(int item);

        /// <summary >
        /// Readonly property . Gets the number of items contained in the
        ///collection.
        /// </ summary >
        int Count { get; }

        /// <summary >
        /// Removes all items from the collection .
        /// </ summary >
        void Clear();

        /// <summary >
        /// Determines whether the collection contains a specific value .
        /// </ summary >
        bool Contains(int item);
    }
    
}