using System;
using ObjProg;


namespace SetApplication
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ArraySet<int> set1 = new ArraySet<int> ();
			set1.Add (5);
			set1.Add (2);
			set1.Add (3);
			set1.Add (7);
			set1.Add (2);
			Console.WriteLine (set1.Contains (5)+" "+ set1.Count);
			LinkedSet<int> set2 = new LinkedSet<int> ();
			set2.Add (5);
			set2.Add (2);
			set2.Add (3);
			set2.Add (7);
			set2.Add (2);
			Console.WriteLine (set2.Contains (5)+" "+ set2.Count);
		}
	}
}
