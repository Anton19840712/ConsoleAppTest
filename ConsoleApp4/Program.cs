class Program
{
	static List<T> UniqueInOrder<T>(IEnumerable<T> sequence)
	{
		List<T> uniqueList = new List<T>();
		T prev = default(T);

		foreach (T item in sequence)
		{
			if (EqualityComparer<T>.Default.Equals(item, prev) == false)
			{
				uniqueList.Add(item);
			}
			prev = item;
		}

		return uniqueList;
	}

	static void Main()
	{
		string sequenceStr = "AAAABBBCCDAABBB";
		var result = UniqueInOrder(sequenceStr);
		foreach (var item in result)
		{
			Console.Write(item + " ");
		}
	}
}
