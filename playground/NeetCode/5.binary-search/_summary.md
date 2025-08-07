# 🔍 Binary Search Pattern in `C#`

## 🧠 What Is Binary Search?

> Binary Search is a **divide-and-conquer** algorithm that efficiently finds a target value in a **sorted array** (or search space) in **O(log n)** time by halving the search range each step.

---

## ✨ Core Template (Classic Binary Search)

```csharp
public int BinarySearch(int[] nums, int target)
{
    int left = 0, right = nums.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (nums[mid] == target)
            return mid;
        else if (nums[mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }

    return -1; // Not found
}
```

---

## 🧠 When to Use the Binary Search Pattern

If you see:

- Sorted array, matrix, or input
- Need to **minimize or maximize a value**
- “Find the first/last occurrence”
- You’re asked for **upper/lower bounds**
- The brute force solution is **O(n)** but can be improved to **O(log n)**

Then you probably need a **binary search**!

---

## 🧭 Binary Search Variants (Very Important!)

### 1. 🔁 Find Exact Value

Classic binary search

```csharp
if (nums[mid] == target) return mid;
```

---

### 2. 🧱 Lower Bound (First occurrence ≥ target)

> Useful when values may repeat and you need the **first valid value**

```csharp
int left = 0, right = nums.Length;
while (left < right)
{
    int mid = left + (right - left) / 2;
    if (nums[mid] < target)
        left = mid + 1;
    else
        right = mid;
}
return left; // or check if valid
```

🧠 This is your “Go-To” for:

- First bad version
- First index >= target
- Smallest satisfying condition

---

### 3. 🚪 Upper Bound (First value > target)

```csharp
if (nums[mid] <= target)
    left = mid + 1;
else
    right = mid;
```

---

## 🧲 Binary Search in Answer Space (Advanced Pattern)

> Instead of searching the input array, you're **searching possible answers**

### 💡 When to use?

If:

- You can **evaluate if a condition is valid** using a helper function
- You want to **minimize/maximize** a result

### 🔧 Framework

```csharp
int left = 1, right = MAX_POSSIBLE;

while (left < right)
{
    int mid = left + (right - left) / 2;

    if (IsValid(mid))  // Can you solve with this value?
        right = mid;
    else
        left = mid + 1;
}
return left;
```

---

### ✅ C# Example: Minimized Largest Sum (LC 410 - Hard)

Split array into `k` parts minimizing the max sum

```csharp
public int SplitArray(int[] nums, int k)
{
    int left = nums.Max(); // can't go below max element
    int right = nums.Sum(); // can't go above total sum

    while (left < right)
    {
        int mid = left + (right - left) / 2;
        if (CanSplit(nums, k, mid))
            right = mid;
        else
            left = mid + 1;
    }

    return left;
}

private bool CanSplit(int[] nums, int k, int maxSum)
{
    int count = 1, sum = 0;
    foreach (int num in nums)
    {
        sum += num;
        if (sum > maxSum)
        {
            count++;
            sum = num;
        }
    }
    return count <= k;
}
```

---

## 🔥 Binary Search Tricks to Memorize

### 💡 Trick 1: Use `left + (right - left) / 2` to avoid overflow

### 💡 Trick 2: Infinite loop? Check:

- Are you moving `left` and `right` in **all branches**?
- Are you using `left <= right` vs `left < right` correctly?

### 💡 Trick 3: **Guess the answer** — use binary search to test if the guess is valid

### 💡 Trick 4: When in doubt, try using a helper function: `IsValid(mid)`

---

## 🧠 How to Recognize Binary Search Problems

| Clue                                       | Meaning                           |
| ------------------------------------------ | --------------------------------- |
| 📐 “Sorted input” or “monotonic condition” | Classic binary search             |
| 🔢 "Find first/last occurrence"            | Lower/Upper bound                 |
| 🧪 "Is it possible to..."                  | Search answer space               |
| ⚖️ "Minimize/maximize" value               | Binary search over solution space |

---

## 🧪 Practice Problems (C# on LeetCode)

| Problem                               | Pattern             |
| ------------------------------------- | ------------------- |
| Binary Search (704)                   | Classic             |
| Search Insert Position (35)           | Lower Bound         |
| First Bad Version (278)               | Lower Bound         |
| Find Peak Element (162)               | Binary on property  |
| Min Eating Speed (875 - Koko Bananas) | Search answer space |
| Split Array Largest Sum (410)         | Binary on answer    |

---

## 🧠 Mnemonic: **“BINA-RY”**

| Letter | Reminder                         |
| ------ | -------------------------------- |
| **B**  | Binary search always halves      |
| **I**  | Input must be sorted/monotonic   |
| **N**  | Narrow down on a condition       |
| **A**  | Answer space can be searched     |
| **R**  | Right logic avoids infinite loop |
| **Y**  | You can always check mid!        |
