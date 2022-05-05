using System;
using System.Collections.Generic;

namespace library_for_test
{
	public class library_for_test1
	{
		public static int[] PrimeFactors(int value)
		{
			int[] llist = new int[15];
			List<int> result = Get_nums(value);
			int length = result.Count;
			for (int i = 0; i < length + 1; i++)
			{
				llist[i] = result[0];

			}
			return llist;
		}

		static List<int> Get_nums(int a)
		{
			List<int> nums = new List<int>();
			for (int i = 1; i < 1001; i++)
			{
				if (a % i == 0)
					nums.Add(i);
			}
			return nums;
		}



	}
}