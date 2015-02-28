using System;
using System.Collections.Generic;

namespace ObjProg
{
	public class ArraySet<T> : ISet<T>
	{
		int count;
		T[] array; 
		T[] temparray;

		bool arrayContains(T[] a, T val)
		{
			bool contains = false;
			foreach (T elem in a)
			{
				if (elem.Equals(val))
					contains = true;
			}
			return contains;
		}
		public ArraySet ()
		{
			count = 0;
			array = new T [1];
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
			bool contains = false;
			foreach (T elem in array)
			{
				if (elem.Equals(value))
					contains = true;
			}
			return contains;
		}
		public void Remove(T value)
		{
			if (!Contains (value) || isEmpty)
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
			throw new NotImplementedException ();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}
	}
}

