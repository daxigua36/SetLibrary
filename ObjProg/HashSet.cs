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
			
		public int Count { get{ return count; } }
			
		public bool isEmpty { get{ return Count == 0;} }

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
						Node<T> temp = curr;
						while (temp.Neighbor != null)
						{
							temp = temp.Neighbor;
						}
						temp.Neighbor = new Node<T> (value, null, null);
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
					Node<T> temp = curr;
					if (temp.Value.Equals (value))
						return true;
					while (temp.Neighbor != null)
					{
						if (temp.Value.Equals(value))
							return true;
						else 
							temp = temp.Neighbor;
					}
				}
				else 
					curr = curr.Next;
			}
			return false;
		}
		public void Remove(T value)
		{
			if (!Contains (value))
				return;
			int valuehash = value.GetHashCode ();
			Node<T> curr = head;
			if (head.Hash.Equals (valuehash))
			{
				if (head.Value.Equals (value))
				{
					if (head.Neighbor != null)
					{
						head.Neighbor.Next = head.Next;
						head = head.Neighbor;
						count--;
						return;
					}
					else
					{
						head = head.Next;
						count--;
						return;
					}
				}
				else
				{
					Node<T> temp = head;
					while (temp.Neighbor != null)
						if (temp.Neighbor.Value.Equals (value))
						{
							temp.Neighbor = temp.Neighbor.Neighbor;
							count--;
							return;
						}
						else
							temp = temp.Neighbor;
				}
			} 
			else
			{
				while (curr.Next != null)
				{
					if (curr.Next.Hash.Equals (valuehash))
					{
						if (curr.Next.Value.Equals (value))
						{
							if (curr.Next.Neighbor != null)
							{
								curr.Next.Neighbor.Next = curr.Next.Next;
								curr.Next = curr.Next.Neighbor;
								count--;
								return;
							}
							else
							{
								curr.Next = curr.Next.Next;
								count--;
								return;
							}
						}
						else
						{
							Node<T> temp = curr.Next;
							while (temp.Neighbor != null)
								if (temp.Neighbor.Value.Equals (value))
								{
									temp.Neighbor = temp.Neighbor.Neighbor;
									count--;
									return;
								}
								else
									temp = temp.Neighbor;
						}
					}
					else
					{
						curr = curr.Next;
					}
				}
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

