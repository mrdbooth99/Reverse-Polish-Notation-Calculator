using System;


namespace RPN
{
    /// <summary>
    /// Represents a Array implementation of a stack
    /// </summary>
    public class ArrayStack<T> : IStack<T>
    {


        // Stack Array
        private  T[] _stack;
        // Stack top pointer
        private int _pointer = -1;




        // Constructor
        public ArrayStack(int capacity)
        {
            _stack = new T[capacity];
        }


        /// <summary>
        /// Method to determine if the stack is empty
        /// </summary>
        /// <returns>true or false</returns>
        public bool IsEmpty()
        {
            // using -1 as array numbers in C# start at 0
            return _pointer == -1;
        }


        /// <summary>
        /// Method to return the top of the stack
        /// </summary>
        /// <returns>current array value at the top</returns>
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Unable to Peek as the stack is empty");
            return _stack[_pointer];
        }

        /// <summary>
        /// Method to pop the top of the stack
        /// </summary>
        /// <returns>current top of stack value</returns>
        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Unable to Pop as the stack is empty");
            // decrement pointer after returning top item
            return _stack[_pointer--];
        }

        /// <summary>
        /// Method to add a value to the stack
        /// Increments the pointer
        /// </summary>
        /// <param name="item">item to add to stack</param>
        public void Push(T item)
        {
            if(_pointer == _stack.Length - 1)
                throw new InvalidOperationException("Unable to Push as the stack is full");
            // increment pointer before insertion
            _stack[++_pointer] = item;

        }
    }
}
