using System;
using System.Collections.Generic;
using System.Collections;

namespace ObjProg
{
	public class UnmutableSet<T> : ISet<T>
	{
		public UnmutableSet ()
		{
		}
			
		public int Count{ get; set;}
			
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

