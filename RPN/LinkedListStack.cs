using System;


namespace RPN
{
    /// <summary>
    /// Represents a LinkedList implmentation of a stack
    /// </summary>
    public class LinkedListStack<T> : IStack<T>
    {
        /// <summary>
        /// Represents a Node within a LinkedList
        /// </summary>
        public class Node
        {
            public T Data;
            public Node Next;
            public Node(T data)
            {

                Data = data;
                Next = null;
            }

        }

        // Stack top 
        private Node _pointer;
        private T _data;

        // Constructor
        public LinkedListStack()
        {
            _pointer = null;
        }



        /// <summary>
        /// Method to determine if the linked list is empty
        /// </summary>
        /// <returns>true or false</returns>
        public bool IsEmpty()
        {
            return _pointer == null;
        }


        /// <summary>
        /// Method to return the top of the stack
        /// </summary>
        /// <returns>node data value</returns>
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Unable to Pop as the stack is empty");
            return _pointer.Data;
        }



        /// <summary>
        /// Method access node by _pointer - update _pointer to node's pointer
        /// </summary>
        /// <returns>node data value</returns>
        public T Pop()
        {

            if (IsEmpty())
                throw new InvalidOperationException("Unable to Pop as the stack is empty");
            _data = _pointer.Data;
            _pointer = _pointer.Next;
            return _data;


        }

        /// <summary>
        /// Method to create new node - with node pointer = _pointer
        /// updates _pointer with new node
        /// </summary>
        /// <param name="item">item to add to stack</param>
        public void Push(T item)
        {
            Node newNode = new Node(item);
            if(_pointer == null)
            {
                newNode.Next = null;
                
            }
            else
            {
                newNode.Next = _pointer;
                
            }
            newNode.Data = item;
            _pointer = newNode;
        }
    }
}
