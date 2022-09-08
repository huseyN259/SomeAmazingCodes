static class ExtensionMethods
{
	public static void MyMethod(this IEnumerable<int> collections)
	{
		collections
			.Where(hn => hn % 2 == 0)
			.ToList()
			.ForEach(hn => Console.WriteLine(hn));
	}

	public static void MyMethod(this IEnumerable<int> collections, bool isEven = true)
	{
		collections
			.Where(hn => Convert.ToBoolean(hn % 2) != isEven)
			.ToList()
			.ForEach(hn => Console.WriteLine(hn));
	}

	public static void WithAnotherExtension(this IEnumerable<int> collections, bool isEven = true)
	{
		collections
			.Where(hn => (hn % 2).ToBoolean() != isEven)
			.ToList()
			.ForEach(hn => Console.WriteLine(hn));
	}

	public static bool ToBoolean(this int nh) => Convert.ToBoolean(nh);
}

class Program
{
	static void Main()
	{
		IEnumerable<int> numbers = Enumerable.Range(1, 100);

		//foreach (int i in numbers)
		//	Console.WriteLine(i); 

		//numbers = numbers.ToList().Where(x => x % 2 == 0);
		//numbers.ToList().ForEach(x => Console.WriteLine(x));

		//numbers
		//	.Where(nh => nh % 2 == 0)
		//	.ToList()
		//	.ForEach(nh => Console.WriteLine(nh));

		numbers.MyMethod(false);

		int hn = 5, nh = 0;
		Console.WriteLine(hn.ToBoolean()); // True
		Console.WriteLine(nh.ToBoolean()); // False
	}
}