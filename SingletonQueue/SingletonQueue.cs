using System;
using GenericLinkedList;

namespace SingletonQueue {
    public class SingletonQueue<T> {
        private static SingletonQueue<T> queue;

        private SingletonQueue() {
        }

        private static GenericLinkedList<T> list;

        public static SingletonQueue<T> Instance {
            get {
                if (queue == null) {
                    queue = new SingletonQueue<T>();
                    list = new GenericLinkedList<T>(); 
                }
                return queue;
            }
        }

        public int Count {
            get {
                return list.Count;
            }
        }

        public override string ToString() {
            return list.ToString();
        }

        public void Push(T item) {
            list.AddToEnd(item);
        }

        public T Pop() {
            T item = list.ReadAt(1);
            list.RemoveAt(1);
            return item;
        }

        public void ClearQueue() {
            queue = null;
            list = null;
        }
    }
}
