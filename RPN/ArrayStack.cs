using System;


namespace RPN
{
    public class ArrayStack<T> : IStack<T>
    {


        private  T[] _stack;
        private int _pointer = -1;





        public ArrayStack(int capacity)
        {
            _stack = new T[capacity];
        }


        public bool IsEmpty()
        {
            // using -1 as array numbers in C# start at 0
            return _pointer == -1;
        }




        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Unable to Peek as the stack is empty");
            return _stack[_pointer];
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Unable to Pop as the stack is empty");
            // decrement pointer after returning top item
            return _stack[_pointer--];
        }

        public void Push(T item)
        {
            if(_pointer == _stack.Length - 1)
                throw new InvalidOperationException("Unable to Push as the stack is full");
            // increment pointer before insertion
            _stack[++_pointer] = item;

        }
    }
}
