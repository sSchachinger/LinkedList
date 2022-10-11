using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libLinkedList
{
    public interface ILinkedList
    {

        /// <summary>
        /// Adds Value into list
        /// </summary>
        /// <param name="item"></param>
        void Add(object item);
        /// <summary>
        /// Search for explicit value
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Contains(object item);
        /// <summary>
        /// Removes single value from List  
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Remove(object item);
        /// <summary>
        /// Is Object at an explicit position
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool IsObjectAtIndex(object item);
        /// <summary>
        /// Iterates trough list
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        object FindbyIndex(int index);
        /// <summary>
        /// get length of the linked list
        /// </summary>
        /// <returns></returns>
        int Count();
    }
}
