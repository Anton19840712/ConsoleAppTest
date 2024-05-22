class Program
{
	static List<string> UniquePermutations(string inputStr)
	{
		var perms = new HashSet<string>(GetPermutations(inputStr));
		return perms.ToList();
	}

	static IEnumerable<string> GetPermutations(string inputStr)
	{
		if (inputStr.Length == 1)
		{
			yield return inputStr;
		}
		else
		{
			foreach (var perm in GetPermutations(inputStr.Substring(1)))
			{
				for (int i = 0; i <= perm.Length; i++)
				{
					yield return perm.Insert(i, inputStr[0].ToString());
				}
			}
		}
	}

	static void Main()
	{
		string inputStr = "aabb";
		var result = UniquePermutations(inputStr);
		foreach (var perm in result)
		{
			Console.WriteLine(perm);
		}

		Console.ReadLine();
	}
}
