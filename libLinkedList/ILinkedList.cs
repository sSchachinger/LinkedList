using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libLinkedList
{
    public interface ILinkedList<T> : IEnumerable
    {

        /// <summary>
        /// Adds Value into list
        /// </summary>
        /// <param name="item"></param>
        void Add(T item);
        /// <summary>
        /// Search for explicit value
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Contains(T item);
        /// <summary>
        /// Removes single value from List  
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Remove(T item);
        /// <summary>
        /// Is T at an explicit position
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool IsObjectAtIndex(T item, int index);
        /// <summary>
        /// Iterates trough list
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T FindbyIndex(int index);
        /// <summary>
        /// get length of the linked list
        /// </summary>
        /// <returns></returns>
        int Count();
        int length { get; set; }
    }
}
