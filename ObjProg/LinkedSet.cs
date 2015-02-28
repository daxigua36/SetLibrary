using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjProg
{
	public class LinkedSet<T> : ISet<T>
	{
		protected class Node<T>
		{
			public T Value { get; set; }
			public Node<T> Next { get; set; }

			public Node(T value, Node<T> next)
			{
				Value=value;
				Next=next;
			}
		}

		Node<T> head;
		int count;

		public LinkedSet()
		{
			head=null;
			count = 0;
		}
			
		public int Count {
			get {
				return count;
			}
		}
			
		public bool isEmpty {
			get {
				return Count == 0;
			}
		}

		public void Add(T value)
		{
			if (head == null)
			{
				head = new Node<T> (value, null);
				count++;
			} 
			else if (!Contains(value))
			{
				Node<T> curr = head;
				while (curr.Next != null)
				{
					curr = curr.Next;
				}
				curr.Next = new Node<T> (value, null);
				count++;
			}
		}
		public void Clear()
		{
			head = null;
			count = 0;
		}
		public bool Contains(T value)
		{
			bool contains = false;
			Node<T> curr = head;
			while (curr.Next != null)
			{
				if (curr.Value.Equals(value))
					contains = true;
				curr = curr.Next;
			}
			return contains;
		}
		public void Remove(T value)
		{
			Node<T> curr = head;
			if (head.Value.Equals(value))
				head = head.Next;
			else
			{
				while (curr.Next != null)
					if (curr.Next.Value.Equals(value))
					{
						curr.Next = curr.Next.Next;
						return;
					}
					else curr = curr.Next;
			}
			count--;
		}
		public IEnumerator<T> GetEnumerator ()
		{
			throw new NotImplementedException ();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}
	}
}

