using System;
using System.Linq;

namespace DataStructures {
    public class Stack<T> {
        private T[] stackArray;
        private int index;

        public Stack(int stackSize = 1024) {
            if (stackSize < 0) {
                throw new Exception("Stack size can not be less then 0.");
            }
            stackArray = new T[stackSize];
        }

        public void Push(T item) {
            if (IsFull()) {
                Resize();
            }
            stackArray[index++] = item;
        }

        public T Pop() {
            if (IsEmpty()) {
                throw new Exception("Stack is empty");
            }
            return stackArray[--index];
        }

        public T Peek() {
            return stackArray[index];
        }

        public bool Contains(T item) {
            return stackArray.Contains(item);
        }

        public T[] ToArray() {
            return stackArray.ToArray();
        }

        public void Clear() {
            index = 0;
        }

        public bool IsEmpty() {
            return Size() == 0;
        }

        public int Size() {
            return index;
        }

        private bool IsFull() {
            return stackArray.Length >= index;
        }

        private void Resize() {
            Array.Resize(ref stackArray, stackArray.Length * 2);
        }
    }
}
