using System;
using System.Collections;
using System.Collections.Generic;


namespace ObjProg
{
	public class HashSet<T> : ISet<T>
	{
		protected class Node<K>
		{
			public K Value { get; set; }
			public int Hash;
			public Node<K> Next { get; set; }
			public Node<K> Neighbor { get; set; }

			public Node(K value, Node<K> next, Node<K> neighbor)
			{
				Value=value;
				Next=next;
				Neighbor=neighbor;
				Hash=value.GetHashCode();
			}
		}

		Node<T> head;
		int count;

		public HashSet ()
		{
			head = null;
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
			int valuehash = value.GetHashCode();
			if (head == null)
			{
				head = new Node<T> (value, null, null);
				count++;
			} 
			else if (!Contains (value))
			{
				Node<T> curr = head;
				while (curr.Next != null)
				{
					if (curr.Hash.Equals(valuehash))
					{
						Node<T> curr1 = curr;
						while (curr1.Neighbor != null)
						{
							curr1 = curr1.Neighbor;
						}
						curr1.Neighbor = new Node<T> (value, null, null);
						count++;
						return;
					}
					curr = curr.Next;
				}
				curr.Next = new Node<T> (value, null, null);
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
			int valuehash = value.GetHashCode();
			Node<T> curr = head;
			while (curr.Next != null)
			{
				if (curr.Hash.Equals (valuehash))
				{
					Node<T> curr1 = curr;
					while (curr1.Neighbor != null)
					{
						if (curr.Value.Equals(value))
							return true;
						else 
							curr1 = curr1.Neighbor;
					}
				}
				else 
					curr = curr.Next;
			}
			return false;
		}
		//unfinished
		public void Remove(T value)
		{
			if (!Contains(value))
				return;
			int valuehash = value.GetHashCode ();
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
			
		IEnumerator IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}
	}
}

