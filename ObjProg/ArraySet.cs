using System.Collections;
using System.Collections.Generic;

namespace ObjProg
{
	public class ArraySet<T> : ISet<T>
	{
		int count;
		T[] array; 
		T[] temparray;

		public ArraySet ()
		{
			count = 0;
			array = new T [1];
		}
			
		public int Count { get{ return count; } }

		public bool isEmpty { get{ return Count == 0;} }

		public void Add(T value)
		{
			if (count == 0) 
			{
				array [0] = value;
				count++;
			} 
			else if (!Contains(value))
			{
				temparray = new T [array.Length+1];
				for (int i = 0; i < array.Length; i++)
				{
					temparray [i] = array [i];
				}
				temparray [count] = value;
				array = temparray;
				count++;
			}
		}
		public void Clear()
		{
			array = new T [1];
			count = 0;
		}
		public bool Contains(T value)
		{
			if (isEmpty)
				return false;
			bool contains = false;
			foreach (T elem in array)
			{
				contains |= elem.Equals (value);
			}
			return contains;
		}
		public void Remove(T value)
		{
			if (!Contains (value))
				return;
			temparray = new T[array.Length - 1];
			int j = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array [i].Equals (value))
				{
					temparray [j] = array [i];
					j++;
				}
			}
			array = temparray;
			count--;
		}

		public IEnumerator<T> GetEnumerator ()
		{
			for (int i = 0; i < count; i++)
				yield return array[i];
		}

		IEnumerator IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}
	}
}

