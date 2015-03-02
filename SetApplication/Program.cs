using System;
using ObjProg;


namespace SetApplication
{
	class MainClass
	{
		public static void Main ()
		{
			ArraySet<int> set1 = new ArraySet<int> ();
			set1.Add (5);
			set1.Add (2);
			set1.Add (3);
			set1.Remove (3);
			set1.Add (7);
			set1.Add (2);
			SetUtils.ForEach<int>(set1, value => Console.Write ("{0} ", value));
			Console.WriteLine ();
			Console.WriteLine (set1.Contains (5)+" "+ set1.Count);
			LinkedSet<int> set2 = new LinkedSet<int> ();
			set2.Add (5);
			set2.Add (2);
			set2.Add (3);
			set2.Add (7);
			set2.Add (2);
			set2.Remove (3);
			SetUtils.ForEach<int>(set2, value => Console.Write ("{0} ", value));
			Console.WriteLine ();
			Console.WriteLine (set2.Contains (5)+" "+ set2.Count);
			HashSet<int> set3 = new HashSet<int> ();
			set3.Add (5);
			set3.Add (2);
			set3.Add (3);
			set3.Add (7);
			set3.Remove (3);
			set3.Add (2);
			SetUtils.ForEach<int>(set3, value => Console.Write ("{0} ", value));
			Console.WriteLine ();
			Console.WriteLine (set3.Contains (5)+" "+ set3.Count);
			UnmutableSet<int> set4 = new UnmutableSet<int> (set2);
			Console.WriteLine(set4.Contains (5)+" "+ set4.Count);
			//throws an exception set4.Clear ();
		}
	}
}
