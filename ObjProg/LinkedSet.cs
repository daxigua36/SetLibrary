using System;
using System.Collections;
using System.Collections.Generic;


namespace ObjProg
{
	public class LinkedSet<T> : ISet<T>
	{
		protected class Node<K>
		{
			public K Value { get; set; }
			public Node<K> Next { get; set; }

			public Node(K value, Node<K> next)
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
			
		public int Count { get{ return count; } }
			
		public bool isEmpty { get{ return Count == 0;} }

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
			if (isEmpty)
				return false;
			Node<T> curr = head;
			while (curr.Next != null)
			{
				if (curr.Value.Equals(value))
					return true;
					
				else 
					curr = curr.Next;
			}
			return false;
		}
		public void Remove(T value)
		{
			if (!Contains(value))
				return;
			Node<T> curr = head;
			if (head.Value.Equals (value))
			{
				head = head.Next;
				count--;
				return;
			}
			else
			{
				while (curr.Next != null)
					if (curr.Next.Value.Equals(value))
					{
						curr.Next = curr.Next.Next;
						count--;
						return;
					}
					else
						curr = curr.Next;
			}
		}
		public IEnumerator<T> GetEnumerator ()
		{
			throw new NotImplementedException ();
		}

		IEnumerator IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}
	}
}

