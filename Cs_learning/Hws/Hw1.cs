using System;
using 
namespace Hws;

public class Hw1
{
	public static void Main() {
        // Hw1 sols = new Hw1();
        // test codes here
	}
    // 1, 9, 217, 412
    // leetcode 1
    public int[] TwoSum(int[] nums, int target)
    {
        // O(n) using hashset
        HashSet<int> numSet = new HashSet<int>(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (numSet.Contains(target - nums[i])) {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i && nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
        }

        return new int[2];
    }

    // leetcode 9
    public bool IsPalindrome(int x)
    {
        String stringX = x.ToString();

        int left = 0;
        int right = stringX.Length - 1;

        while(left < right)
        {
            if (stringX[left] != stringX[right]) return false;

            left++;
            right--;
        }

        return true;
    }

    // leetcode 217
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> visited = new HashSet<int>();

        foreach(int num in nums)
        {
            if (visited.Contains(num)) return true;
            else visited.Add(num);
        }

        return false;
    }

    // leetcode 412
    public IList<string> FizzBuzz(int n)
    {
        IList<String> answer = new List<String>();

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) answer.Add("FizzBuzz");
            else if (i % 3 == 0) answer.Add("Fizz");
            else if (i % 5 == 0) answer.Add("Buzz");
            else answer.Add(i.ToString());
        }

        return answer;
    }
}

