using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Stack<T>
    {
        T[] arr;
        int peek;

        public Stack() {
            arr = new T[10];
        }

        public void Push(T a) {
            arr[peek++] = a;
        }
        public T Peek() {
            return arr[peek - 1];
        }
        public void Pop() {
            peek--;
        }
    }
}
