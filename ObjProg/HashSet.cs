using System;
using System.Collections;
using System.Collections.Generic;


namespace ObjProg
{
	public class HashSet<T> : ISet<T>
	{
		int count;

		public HashSet ()
		{
			count = 0;
		}
			
		public int Count {
			get {
				return count;
			}
		}


		public bool isEmpty {
			get {
				throw new NotImplementedException ();
			}
		}

		public void Add(T value)
		{

		}
		public void Clear()
		{
		
		}
		public bool Contains(T value)
		{
			return false;
		}
		public void Remove(T value)
		{

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

