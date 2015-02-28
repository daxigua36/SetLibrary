using System;
using System.Collections.Generic;


namespace ObjProg
{
	public interface ISet<T> : IEnumerable<T>
	{
		void Add (T value);
		void Clear();
		bool Contains(T value);
		void Remove(T value);

		//properties
		int Count{ get; }
		bool isEmpty{ get; }
	}
}

