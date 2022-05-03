//"Two Sum" - EASY
    
using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] nums = {4,7,15,2, 33, 22};
        int target = 9;
        int[] results = TwoSum(nums, target);
        Console.Write("Index sums are: [");
        foreach(var item in results){
            Console.Write($"{item}, ");
        }
        Console.Write("]");
    }
    
    //result: indices (int), in any order
    //result: should add up to the <target(given)>
    //given: sorted array
    //restrictions: do not use the same number / index.value twice
    
    //Input: nums = [2,7,11,15], target = 9
    //Output: [0,1] (int)
    //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

    public static int[] TwoSum(int[] nums, int target) {
        int numsLength = nums.Length-1;
        int[] result = new int[]{};
        var runner = 0;
    // validate if there is an entry that is equals to the target, if so return index
 		for (var j = 0; j <= numsLength; j++)
        {
            if (nums[j] == target)
            {
                result[runner] = j; 
                return result;
            }
            runner++;
        }
    // loop through each element to validate if nums[i] == target - nums[j]
        
        for (var i = 0; i <= numsLength; i++)
        {
            for (var j = i + 1; j <= numsLength; j++)
            {
                if (nums[j] == target - nums[i])
                {
                    result = result.Concat(new int[] { j }).ToArray();
                    result = result.Concat(new int[] { i }).ToArray();

                    return result;
                }
                runner++;
            }
        }
        return result;
        //If all else fails returns null
    }
}
