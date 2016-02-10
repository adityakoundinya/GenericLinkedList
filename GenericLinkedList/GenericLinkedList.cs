using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    public class GenericLinkedList<T>
    {
        private class Node {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        public override string ToString() {
            if (this.Head == null) {
                return string.Empty;
            }
            string data = string.Empty;
            Node curr = this.Head;
            data = curr.Data.ToString();
            while (curr.Next != null) {
                curr = curr.Next;
                data += ", " + curr.Data.ToString();
            }
            return data;
        }

        private Node Head { get; set; }
        private int Size = 0;

        public void AddToEnd(T item) {
            Node newNode = new Node();
            newNode.Data = item;

            if (this.Head == null) {
                this.Head = newNode;
            } else {
                Node curr = GetLastNode();
                curr.Next = newNode;
            }
            this.Size++;
        }

        public void AddToTop(T item) {
            Node newNode = new Node();
            newNode.Data = item;

            if (this.Head == null) {
                this.Head = newNode;
            } else {
                newNode.Next = this.Head;
                this.Head = newNode;
            }
            this.Size++;
        }

        public void AddAt(T item, int position) {
            Node newNode = new Node();
            newNode.Data = item;

            if ((this.Head == null && position > 1) || position < 0 || position > this.Size + 1) {
                throw new ArgumentOutOfRangeException("The supplied position is invalid.");
            }

            if (position == 1) {
                AddToTop(item);
                return;
            }
            if (position == this.Size + 1) {
                AddToEnd(item);
                return;
            }

            Node prev = null;
            Node curr = this.Head;
            int count = 1;
            while (count < position) {
                prev = curr;
                curr = curr.Next;
                count++;
            }
            prev.Next = newNode;
            newNode.Next = curr;
            this.Size++;
        }

        public bool Remove(T item) {
            if (this.Head == null) {
                return false;
            }
            Node prev = null;
            Node curr = this.Head;
            Node next = this.Head.Next == null ? null : this.Head.Next;

            if (this.Head.Data.Equals(item)) {
                if (next != null) {
                    this.Head = next;
                    this.Size--;
                    return true;
                }
            } else {
                while (curr.Next != null) {
                    prev = curr;
                    curr = curr.Next;
                    next = curr.Next == null ? null : curr.Next;

                    if (curr.Data.Equals(item)) {
                        prev.Next = next;
                        this.Size--;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool RemoveAt(int position) {
            if (this.Head == null) {
                return false;
            }
            if (position < 1) {
                return false;
            }
            if (position > this.Size) {
                return false;
            }

            int count = 1;
            Node prev = null;
            Node curr = this.Head;
            Node next = this.Head.Next == null ? null : this.Head.Next;

            if (position == 1) {
                this.Head = next;
                this.Size--;
                return true;
            }

            while (count <= position) {

                if (count == position) {
                    prev.Next = next;
                    this.Size--;
                    return true;
                }

                prev = curr;
                curr = curr.Next;
                next = curr.Next == null ? null : curr.Next;

                count++;
            }

            return false;
        }

        public T ReadAt(int position) {
            if (this.Head == null) {
                throw new NullReferenceException("There are no items in the list.");
            }
            if (position < 1) {
                throw new IndexOutOfRangeException("The position has to be greater than 1.");
            }
            if (position > this.Size) {
                throw new IndexOutOfRangeException("The supplied position is greater than the elements in the list.");
            }

            int count = 1;
            Node curr = this.Head;
            while (count <= position) {
                if (count == position) {
                    break;
                }
                count++;
                curr = curr.Next;
            }
            return curr.Data;
        }

        private Node GetLastNode() {
            if (this.Head == null) {
                return null;
            }
            Node curr = this.Head;
            while (curr.Next != null) {
                curr = curr.Next;
            }
            return curr;
        }
    }
}
