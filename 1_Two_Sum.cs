// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// Example:
// Given nums = [2, 7, 11, 15], target = 9,
// Because nums[0] + nums[1] = 2 + 7 = 9,
// return [0, 1].

public class Solution {
    
    public int[] TwoSum(int[] nums, int target) {
        
       var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if(dict.ContainsKey(diff))
                {
                    return new int[] { dict[diff], i };
                }
                else
                {
                    if(!dict.ContainsKey(nums[i]))
                        dict.Add(nums[i], i);
                }
            }

            return null;
    }
}
