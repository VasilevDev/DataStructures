using LinkedList.Model;
using System;

namespace LinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			var list = new LinkedList<int>();

			list.Add(1);
			list.Add(2);
			list.Add(3);

			list.Remove(2);

			Console.ReadLine();
		}
	}
}
