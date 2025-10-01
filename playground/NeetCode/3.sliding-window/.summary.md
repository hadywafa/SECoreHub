# 🔍 Sliding Window Pattern

## 🧊 What Is Sliding Window?

> A **sliding window** is a technique for problems that require examining **contiguous subarrays or substrings** — usually to find a sum, max/min, or count — without using nested loops.

Instead of recalculating from scratch, you **slide a window** and **reuse** part of the previous calculation.

---

## 🧠 When to Use It?

Use Sliding Window when:

- Problem involves **contiguous elements** (subarrays/substrings).
- You're asked to find **max/min/sum/length/count** of a subarray.
- Naive solution is **O(n²)** — can you do better?
- You can solve the problem by **adding/removing** from a running window.

---

## 🧰 Types of Sliding Window

### 1. 🔒 **Fixed-size Window**

→ Use when window size `k` is given.

#### ✅ C# Example: Max sum of subarray of size `k`

```csharp
public int MaxSum(int[] nums, int k)
{
    int maxSum = 0, windowSum = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        windowSum += nums[i];

        if (i >= k - 1)
        {
            maxSum = Math.Max(maxSum, windowSum);
            windowSum -= nums[i - k + 1]; // Slide the window
        }
    }

    return maxSum;
}
```

🧠 **Trick**: Slide window by removing `nums[i - k + 1]` and adding `nums[i]`.

---

### 2. 📏 **Variable-size Window (Dynamic)**

→ When you're **not given** a fixed size — instead, a condition decides window growth/shrink.

#### ✅ C# Example: Longest substring with at most 2 distinct characters

```csharp
public int LengthOfLongestSubstringTwoDistinct(string s)
{
    var map = new Dictionary<char, int>();
    int left = 0, maxLen = 0;

    for (int right = 0; right < s.Length; right++)
    {
        char c = s[right];
        if (!map.ContainsKey(c))
            map[c] = 0;
        map[c]++;

        while (map.Count > 2)
        {
            char leftChar = s[left];
            map[leftChar]--;
            if (map[leftChar] == 0)
                map.Remove(leftChar);
            left++;
        }

        maxLen = Math.Max(maxLen, right - left + 1);
    }

    return maxLen;
}
```

🧠 **Trick**:

- Expand `right`
- If condition breaks (too many distinct chars), shrink `left` until valid

---

## 🧠 How to Identify Sliding Window Problems

Ask yourself:

| Clue                             | Meaning                                       |
| -------------------------------- | --------------------------------------------- |
| ❓ "Contiguous"                  | Subarray/substring — window needed            |
| 🎯 “Max/min/avg/count of window” | Usually fixed or dynamic window               |
| 🔁 Naive solution = O(n²)?       | Try converting to O(n) using a sliding window |
| ⏱ Time-efficient required?       | Sliding window = optimal                      |

---

## 🧠 C# Sliding Window Template

### 🔒 Fixed-size:

```csharp
int left = 0;
for (int right = 0; right < arr.Length; right++)
{
    // Expand window
    ...

    if (right - left + 1 == k)
    {
        // Update result
        ...
        // Shrink window
        ...
        left++;
    }
}
```

### 📏 Dynamic-size:

```csharp
int left = 0;
for (int right = 0; right < arr.Length; right++)
{
    // Expand window (add arr[right])
    ...

    while (/* window invalid */)
    {
        // Shrink window (remove arr[left])
        ...
        left++;
    }

    // Update result if needed
    ...
}
```

---

## 🧪 C# Practice Problems

| Problem                                   | Type          | LeetCode |
| ----------------------------------------- | ------------- | -------- |
| Max Sum of Subarray of Size K             | Fixed         | 643      |
| Longest Substring Without Repeating Chars | Dynamic       | 3        |
| Longest Substring with At Most K Distinct | Dynamic       | 340      |
| Minimum Window Substring                  | Shrinking     | 76       |
| Permutation in String                     | Fixed/Dynamic | 567      |

---

## 💥 Quick Mnemonic: **WiNdOW**

| Letter | What to Remember                    |
| ------ | ----------------------------------- |
| **W**  | Window — subarrays/substrings       |
| **i**  | Indices `left` and `right`          |
| **N**  | No nested loops                     |
| **d**  | Dynamic window when condition-based |
| **O**  | Reduce to O(n)                      |
| **W**  | Watch when to slide!                |

---

## 🧠 Final Advice

- **Always ask**: Can I solve this by reusing the last result + subtracting what left the window?
- **Start with two pointers**: `left` and `right`.
- **Track what’s inside**: sum, count, chars, frequency, etc.
- **Shrink when needed**: especially for dynamic windows.
