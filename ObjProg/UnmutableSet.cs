using System;
using System.Collections.Generic;
using System.Collections;

namespace ObjProg
{
	public class UnmutableSet<T> : ISet<T>
	{
		ISet<T> BaseSet;

		public UnmutableSet (ISet<T> baseSet)
		{
			if (baseSet is UnmutableSet<T>)
				throw new SetException("UnmutableList can not be base for UnmutableList");
			BaseSet = baseSet;
		}
			
		public int Count { get{ return BaseSet.Count; } }
			
		public bool isEmpty { get{ return Count == 0;} }

		public void Add(T value)
		{
			throw new SetException("New elements can not be added to UnmutableSet");
		}
		public void Clear()
		{
			throw new SetException("UnmutableSet can not be cleared");
		}
		public bool Contains(T value)
		{
			return BaseSet.Contains (value);
		}
		public void Remove(T value)
		{
			throw new SetException("Elements can not be removed from UnmutableSet");
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

