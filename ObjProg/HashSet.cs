using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjProg
{
	public class HashSet<T> : ISet<T>
	{
		public HashSet ()
		{
		}

		public IEnumerator<T> GetEnumerator ()
		{
			throw new NotImplementedException ();
		}


		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}

		int count;
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

	}
}

