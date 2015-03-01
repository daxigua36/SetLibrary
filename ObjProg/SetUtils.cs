using System;

namespace ObjProg
{
	public class SetUtils
	{
		public delegate bool CheckDelegate<T>(T value);
		public delegate ISet<T> SetConstructorDelegate<T>();
		public delegate TO ConvertDelegate<TI, TO>(TI input);
		public delegate void ActionDelegate<T>(T value);

		public static bool Exists<T>(ISet<T> MySet, CheckDelegate<T> checkd)
		{
			if (checkd == null)
				throw new SetException("Delegate check is null");
			foreach (T element in MySet)
				if (checkd(element)) return true;
			return false;
		}

		public static ISet<T> FindAll<T>(ISet<T> MySet, CheckDelegate<T> checkd, SetConstructorDelegate<T> setconstd)
		{
			if (checkd == null)
				throw new SetException("Delegate check is null.");
			if (setconstd == null)
				throw new SetException ("Delegate constructor is null");
			ISet<T> output = setconstd ();
			foreach (T element in MySet)
				if (checkd(element))
					output.Add(element);
			return output;
		}

		public static ISet<TO> ConvertAll<TI, TO>(ISet<TI> MySet, ConvertDelegate<TI, TO> converterd, SetConstructorDelegate<TO> setconstd)
		{
			if (setconstd == null)
				throw new SetException ("Delegate constructor is null");
			ISet<TO> output = setconstd();
			foreach (TI element in MySet)
				output.Add(converterd(element));
			return output;
		}

		public static void ForEach<T>(ISet<T> MySet, ActionDelegate<T> actiond)
		{
			if (actiond == null)
				throw new SetException("Delegate action is null.");
			foreach (T element in MySet)
				actiond(element);
		}

		public static bool CheckForAll<T>(ISet<T> MySet, CheckDelegate<T> checkd)
		{
			if (checkd == null)
				throw new SetException("Delegate check is null.");
			foreach (T element in MySet)
				if (!checkd(element)) return false;
			return true;
		}
	}
}