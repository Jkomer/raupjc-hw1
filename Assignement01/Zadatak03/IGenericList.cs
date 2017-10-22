using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak03
{
    interface IGenericList <T> : IEnumerable <T>
    {
        void Add(T item);
        /// <summary >
        /// Adds an item to the collection .
        /// </ summary >
        /// <summary >
        /// Removes the first occurrence of an item from the collection .
        /// If the item was not found , method does nothing and returns false .
        /// </ summary >
        bool Remove(T item);
        /// <summary >
        /// Removes the item at the given index in the collection .
        /// Throws IndexOutOfRange exception if index out of range .
        /// </ summary >
        bool RemoveAt(int index);
        /// <summary >
        /// Returns the item at the given index in the collection .
        /// Throws IndexOutOfRange exception if index out of range .
        /// </ summary >
        T GetElement(int index);
        /// <summary >
        /// Returns the index of the item in the collection .
        /// If item is not found in the collection , method returns -1.
        /// </ summary >
        int IndexOf(T item);
        /// <summary >
        /// Readonly property . Gets the number of items contained in the
        /// </ summary >
        int Count { get; }
        /// <summary >
        /// Removes all items from the collection .
        /// </ summary >
        void Clear();
        /// <summary >
        /// Determines whether the collection contains a specific value .
        /// </ summary >
        bool Contains(T item);
    }
}
