# 🧠 Sliding Window Pattern — Full Guide

## ✅ What is Sliding Window?

> A technique to **reduce the time complexity** of problems involving **contiguous sequences (subarrays, substrings)** by using a **"window" that slides across the input**.

Instead of checking all possible subarrays (which is O(n²)), you maintain a fixed-size or variable-size "window" and move it efficiently across the input.

---

## 🧩 When to Use Sliding Window?

Look for these clues:

| Clue in Problem                                                   | Use Sliding Window            |
| ----------------------------------------------------------------- | ----------------------------- |
| Substring or Subarray                                             | ✅ Yes                        |
| "Longest", "Shortest", "Maximum", "Minimum" in substring/subarray | ✅ Yes                        |
| Fixed or dynamic window size                                      | ✅ Yes                        |
| Only positive numbers / characters                                | ✅ Easier with Sliding Window |
| You need to check or maintain a condition in a range              | ✅ Yes                        |

---

## 🚪 Sliding Window Patterns (with LeetCode examples)

## 🪟 1. Fixed-Size Sliding Window

🧩 Use when the window size is constant (e.g., "find max sum of subarray of size K").

### Pattern

```csharp
int sum = 0, maxSum = 0;
for (int i = 0; i < nums.Length; i++) {
    sum += nums[i];

    if (i >= k - 1) {
        maxSum = Math.Max(maxSum, sum);
        sum -= nums[i - k + 1];  // shrink window
    }
}
```

### 🔗 Problems:

- [Max Sum Subarray of Size K](https://leetcode.com/problems/maximum-average-subarray-i/)
- [Maximum Sum of Subarray of Size K - Sliding Window](https://leetcode.com/problems/maximum-average-subarray-i/)

---

## 🪟 2. Variable-Size Sliding Window

🧩 Use when the window size grows or shrinks based on a condition (e.g., "longest subarray with sum ≤ K")

### Pattern

```csharp
int l = 0;
for (int r = 0; r < nums.Length; r++) {
    // expand window
    while (condition not met) {
        // shrink from left
        l++;
    }

    // check/update result here
}
```

### 🔗 Problems:

- [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/)
- [Minimum Size Subarray Sum](https://leetcode.com/problems/minimum-size-subarray-sum/)

---

## 🪟 3. Sliding Window with HashMap/Counter

🧩 Use when you need to **track frequencies** inside the window.

### Pattern

```csharp
var map = new Dictionary<char, int>();
int l = 0;

for (int r = 0; r < s.Length; r++) {
    // expand window
    map[s[r]]++;

    while (invalid window condition) {
        map[s[l]]--;
        l++;
    }

    if (valid window) {
        // update result
    }
}
```

### 🔗 Problems:

- [Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement/)
- [Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/)

---

## 🪟 4. Sliding Window with Two Pointers (When Sorting Not Allowed)

🧩 Good for problems like 2Sum in a sorted array, or when the range must be found without sorting.

### Pattern

```csharp
int l = 0, r = 0;
while (r < nums.Length) {
    // expand
    if (valid window) {
        // update result
        r++;
    } else {
        // shrink
        l++;
    }
}
```

### 🔗 Problems:

- [Longest Substring with At Most K Distinct Characters](https://leetcode.com/problems/longest-substring-with-at-most-k-distinct-characters/)
- [Fruit Into Baskets](https://leetcode.com/problems/fruit-into-baskets/)

---

## 🪟 5. Permutation/Anagram Checking (Your Case)

🧩 Use when checking whether a **window contains the same characters** as a target.

### Pattern

```csharp
var countS1 = new int[26];
// fill s1 count

for (int i = 0; i < s2.Length; i++) {
    // add to window
    // remove if window size > s1

    // if counts match -> valid
}
```

### 🔗 Problems:

- [Check Inclusion](https://leetcode.com/problems/permutation-in-string/)
- [Find All Anagrams in a String](https://leetcode.com/problems/find-all-anagrams-in-a-string/)

---

## 🪟 6. Sliding Window with Deque (For Maximum/Minimum in Window)

🧩 Used when you want max/min in current window (monotonic queue).

### Pattern

```csharp
var deque = new LinkedList<int>();

for (int i = 0; i < nums.Length; i++) {
    // remove elements out of range
    // remove smaller elements
    // add current index

    // get max from front of deque
}
```

### 🔗 Problems:

- [Sliding Window Maximum](https://leetcode.com/problems/sliding-window-maximum/)
- [Shortest Subarray with Sum at Least K](https://leetcode.com/problems/shortest-subarray-with-sum-at-least-k/)

---

## 🧠 Sliding Window Summary Table

| Pattern Type            | When to Use                       | Key Structure   |
| ----------------------- | --------------------------------- | --------------- |
| Fixed-size window       | Exact-size range (e.g., length K) | Simple loop     |
| Variable-size window    | Grow/shrink based on condition    | While loop + if |
| Frequency check         | Permutations / anagrams / chars   | Array/Map       |
| Max/Min in window       | Find max/min in window            | Deque           |
| Longest/Shortest subX   | Optimize size under condition     | While loop      |
| Count substrings/window | Count all valid windows           | Counter logic   |

---

## 🧠 Pro Tip

💡 **If you’re looping with `for r = 0 to n` and adjusting `l` inside — it’s a sliding window.**
