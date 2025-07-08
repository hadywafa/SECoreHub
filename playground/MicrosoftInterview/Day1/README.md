# Day 1

## 📌 Two SUM

### ⁉️ Problem

Given an array of integers `nums` and an integer `target`, return _indices of the two numbers such that they add up to `target`_.

You may assume that each input would have **exactly one solution**, and you may not use the _same_ element twice.

You can return the answer in any order.

**Example 1:**

**Input:** `nums = [2,7,11,15], target = 9`  
**Output:** `[0,1]`  
**Explanation:** Because `nums[0] + nums[1] == 9`, we return `[0, 1]`.

**Example 2:**

**Input:** `nums = [3,2,4], target = 6`  
**Output:** `[1,2]`

**Example 3:**

**Input:** `nums = [3,3], target = 6`  
**Output:** `[0,1]`

**Constraints:**

- `2 <= nums.length <= 10⁴`
- `-10⁹ <= nums[i] <= 10⁹`
- `-10⁹ <= target <= 10⁹`
- **Only one valid answer exists.**

### ✅ Solution 1

```cs
    public static int[] TwoSum(int[] nums, int target)
    {
        // foreach item in array
        // foreach item in array
        // if item[i] + item+1 = target

        for (int i = 0; i < nums.Length; i++)
        {
            for (int y = 0; y < nums.Length; y++)
            {
                if (i == y)
                    continue;
                if (nums[i] + nums[y] == target)
                    return [i, y];
            }
        }

        return [];
    }
```
