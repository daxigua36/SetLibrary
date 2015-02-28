using System;
using ObjProg;


namespace SetApplication
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ArraySet<int> set = new ArraySet<int> ();
			set.Add (5);
			set.Add (2);
			set.Add (3);
			set.Add (7);
			set.Add (2);
			Console.WriteLine (set.Contains (5)+" "+ set.Count);
			Console.WriteLine ("Hello World!");
		}
	}
}
