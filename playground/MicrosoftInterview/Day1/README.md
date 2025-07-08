# Day 1

## 📌 1. Two SUM

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

---

## 📌 2. [Contains Duplicate](https://leetcode.com/problems/contains-duplicate/)

### ⁉️ Problem

**Example 1:**

**Input:** `nums = [1,2,3,4]`  
**Output:** `false`  
**Explanation:** All elements are distinct.

**Example 2:**

**Input:** `nums = [1,2,3,1]`  
**Output:** `true`  
**Explanation:** The element 1 occurs at the indices 0 and 3.

### ✅ Solution 1

```cs
    public static bool ContainsDuplicate(int[] nums)
    {
        // x = loop1 foreach number and store temo each item value
        // y = loop2 foreach again over numbers and any item equal to temp value then return true <Note skip current item index for second loop>
        //[1,2,3,1]

        var uniqueList = new List<int> { nums[0] };

        for (int x = 1; x < nums.Length; x++)
        {
            if (uniqueList.Contains(nums[x]))
                return true;
            uniqueList.Add(nums[x]);
        }
        return false;
    }
```

```cs
    public static bool ContainsDuplicate(bool theBest, int[] nums)
    {
        var map = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!map.TryAdd(num, 1))
                return true;
        }

        return false;
    }
```

```cs
        var numbers = new HashSet<int>();

        foreach (int number in nums)
        {
            if (numbers.Contains(number))
                return true;
            numbers.Add(number);
        }

        return false;
```

---

## 📌 3. [Valid Palindrome](https://leetcode.com/problems/valid-palindrome/)

### ⁉️ Problem

**Example 1:**

**Input:** `s = "Yamal"`  
**Output:** `true`  
**Explanation:** "yamal" is a palindrome.

**Example 2:**

**Input:** `s = "A man, a plan, a canal: Panama"`  
**Output:** `true`  
**Explanation:** "amanaplanacanalpanama" is a palindrome.

**Example 3:**

**Input:** `s = "race a car"`  
**Output:** `false`  
**Explanation:** "raceacar" is not a palindrome.

### ✅ Solution 1

```cs
    public static bool IsPalindrome(string s)
    {
        //lamal
        string cleanInput = Regex.Replace(s.ToLower(), "[^a-zA-Z0-9]", "");

        var index = cleanInput.Length / 2;

        for (int i = 0; i < index; i++)
        {
            if (cleanInput[i] != cleanInput[cleanInput.Length - (i + 1)])
                return false;
        }

        return true;
    }
```
