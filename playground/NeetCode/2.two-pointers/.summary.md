# 🧠 Two Pointers Pattern — Master Cheat Sheet for LeetCode

## 💡 What is the Two Pointers Pattern?

> Two pointers is a pattern where you use **two indices** (or pointers) to iterate over a data structure, often from **both ends** or with **a moving window**, to optimize time complexity (usually from O(n²) → O(n)).

---

## ✅ When Should I Use Two Pointers?

Use **Two Pointers** when:

| Scenario                                                        | Example Problem                                                      |
| --------------------------------------------------------------- | -------------------------------------------------------------------- |
| Array is **sorted** or can be sorted                            | `Two Sum II`, `3Sum`, `4Sum`                                         |
| You want to **find pairs or triplets** that satisfy a condition | `Two Sum`, `Container With Most Water`                               |
| You want to **move elements**                                   | `Move Zeroes`, `Remove Duplicates`, `Sort Colors`                    |
| You're **shrinking/expanding** a window range                   | `Valid Palindrome`, `Longest Substring Without Repeating Characters` |
| You're solving **string comparisons** from both ends            | `Valid Palindrome`, `Backspace String Compare`                       |

---

## 🧠 1. Template: Two Pointers on a Sorted Array (Outside-In)

### 🧪 Use when:

- The array is sorted
- You're searching for pairs that **add up to a target**

### 🔧 Code Template:

```csharp
int left = 0, right = nums.Length - 1;
while (left < right)
{
    int sum = nums[left] + nums[right];
    if (sum == target)
        return new int[] { left, right }; // or do something
    else if (sum < target)
        left++;
    else
        right--;
}
```

### ✅ Common Problems:

- Two Sum II (sorted)
- 3Sum
- 4Sum
- Pair with Target Sum

---

## 🧠 2. Template: Two Pointers (Slow/Fast or Read/Write Pointers)

### 🧪 Use when:

- You're filtering/modifying elements
- You want to **move values around**

### 🔧 Code Template:

```csharp
int write = 0;
for (int read = 0; read < nums.Length; read++)
{
    if (/* keep nums[read] */)
    {
        nums[write] = nums[read];
        write++;
    }
}
// return write or modified array
```

### ✅ Common Problems:

- Remove Duplicates from Sorted Array
- Move Zeroes
- Remove Element

---

## 🧠 3. Template: Center Expansion (Palindrome)

### 🧪 Use when:

- You're checking from the center out (not just strings!)
- Palindromes, symmetry checks

### 🔧 Code Template:

```csharp
int left = center, right = center;
while (left >= 0 && right < s.Length && s[left] == s[right])
{
    // expand
    left--;
    right++;
}
```

### ✅ Common Problems:

- Longest Palindromic Substring
- Valid Palindrome

---

## 🧠 4. Template: Shrinking Window (Dynamic Two Pointers)

### 🧪 Use when:

- You're maintaining a **window of valid values**
- You need to **shrink** the window from the left when invalid

### 🔧 Code Template:

```csharp
int left = 0;
for (int right = 0; right < nums.Length; right++)
{
    // Expand window with nums[right]

    while (/* window is invalid */)
    {
        // Shrink from left
        left++;
    }

    // Update max window or result
}
```

### ✅ Common Problems:

- Longest Substring Without Repeating Characters
- Minimum Size Subarray Sum
- Sliding Window Maximum

---

## 🧠 5. Template: 3Sum & 4Sum Pattern

### 🧪 Use when:

- You're searching for triplets or quadruplets in **sorted** arrays

### 🔧 Code Template (3Sum):

```csharp
Array.Sort(nums);

for (int i = 0; i < nums.Length - 2; i++)
{
    if (i > 0 && nums[i] == nums[i - 1]) continue; // skip duplicates

    int left = i + 1, right = nums.Length - 1;
    while (left < right)
    {
        int sum = nums[i] + nums[left] + nums[right];

        if (sum == 0)
        {
            result.Add(new List<int>{nums[i], nums[left], nums[right]});
            left++;
            right--;

            // skip duplicates
            while (left < right && nums[left] == nums[left - 1]) left++;
            while (left < right && nums[right] == nums[right + 1]) right--;
        }
        else if (sum < 0) left++;
        else right--;
    }
}
```

---

## 💬 Summary Table of Two Pointer Patterns

| Use Case                     | Left              | Right         | Problem Example    |
| ---------------------------- | ----------------- | ------------- | ------------------ |
| Search pairs in sorted array | Start             | End           | Two Sum II         |
| Move non-zero elements       | Write             | Read          | Move Zeroes        |
| Remove duplicates            | Slow              | Fast          | Remove Duplicates  |
| Shrink/Expand window         | Shrink on invalid | Grow on valid | Longest Substring  |
| Palindromes / Center expand  | Center - 1        | Center + 1    | Longest Palindrome |
| 3Sum / 4Sum                  | `i + 1`           | End           | 3Sum               |

---

## 💥 Quick Pattern Recognizers

| Problem Clue                       | Pattern                   |
| ---------------------------------- | ------------------------- |
| “Find pair/triplet” + sorted array | Two Pointers (outside-in) |
| “Move elements”                    | Read/Write                |
| “Max length of window”             | Shrinking Window          |
| “Check Palindrome”                 | Expand from center        |
| “Remove Duplicates”                | Slow/Fast Pointer         |
