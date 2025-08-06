# 🧠 Arrays & Hashing: Common Patterns Cheat Sheet for LeetCode

> Use this as your **mental toolbox** when solving **Easy to Hard** LeetCode problems involving Arrays, HashSets, Dictionaries, and more.

---

## 🔁 1. **Frequency Counter / HashMap Pattern**

### ✅ When to Use:

- Count occurrences
- Track duplicates
- Character frequency in strings or arrays

### 🔧 Template:

```csharp
var map = new Dictionary<T, int>();

foreach (var item in items)
{
    if (!map.ContainsKey(item))
        map[item] = 1;
    else
        map[item]++;
}
```

### 🧠 Common Problems:

- Valid Anagram
- Top K Frequent Elements
- Majority Element
- Group Anagrams

---

## 🔁 2. **Set Lookup (Uniqueness / Fast Search)**

### ✅ When to Use:

- Check for existence in O(1)
- Remove duplicates
- Track visited elements

### 🔧 Template:

```csharp
var set = new HashSet<T>();

foreach (var item in items)
{
    if (set.Contains(item))
        // duplicate or match found
    else
        set.Add(item);
}
```

### 🧠 Common Problems:

- Contains Duplicate
- Longest Consecutive Sequence
- Happy Number
- Intersection of Two Arrays

---

## 🔁 3. **Sliding Window**

### ✅ When to Use:

- Find subarrays (fixed or dynamic size)
- Optimize space/time
- Continuous range problems

### 🔧 Fixed-size Window:

```csharp
int sum = 0, k = 3;

for (int i = 0; i < k; i++)
    sum += nums[i];

for (int i = k; i < nums.Length; i++)
{
    sum += nums[i] - nums[i - k];
}
```

### 🔧 Variable-size Window:

```csharp
int left = 0;

for (int right = 0; right < nums.Length; right++)
{
    // Expand right, shrink left when needed
    while (/* condition */)
    {
        // shrink from left
        left++;
    }
}
```

### 🧠 Common Problems:

- Maximum Average Subarray
- Longest Substring Without Repeating Characters
- Minimum Window Substring
- Subarray Sum Equals K

---

## 🔁 4. **Two Pointers**

### ✅ When to Use:

- Sorted arrays
- Search for pairs or triplets
- Avoid nested loops

### 🔧 Template:

```csharp
int left = 0;
int right = nums.Length - 1;

while (left < right)
{
    int sum = nums[left] + nums[right];
    if (sum == target) { ... }
    else if (sum < target) left++;
    else right--;
}
```

### 🧠 Common Problems:

- Two Sum II (sorted)
- 3Sum
- Container With Most Water
- Move Zeros

---

## 🔁 5. **Prefix Sum**

### ✅ When to Use:

- Range sums
- Detect subarrays with certain properties
- Optimize nested loops

### 🔧 Template:

```csharp
int[] prefix = new int[nums.Length + 1];
for (int i = 0; i < nums.Length; i++)
    prefix[i + 1] = prefix[i] + nums[i];
```

### 🧠 Common Problems:

- Subarray Sum Equals K
- Range Sum Query
- Minimum Size Subarray Sum

---

## 🔁 6. **Sort & Scan / Greedy Scan**

### ✅ When to Use:

- Grouping or pairing
- Detect ranges, clusters, overlaps
- Anagram detection (sort characters)

### 🔧 Template:

```csharp
Array.Sort(nums);
for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] == nums[i - 1]) continue;
    // compare nums[i] with nums[i-1]
}
```

### 🧠 Common Problems:

- Merge Intervals
- Longest Consecutive Sequence
- Group Anagrams (sorted key)
- Non-overlapping Intervals

---

## 🔁 7. **Bucket Sort / Count Sort**

### ✅ When to Use:

- When input has a known range
- Frequency-based sorting (Top K)
- Avoid built-in sorting for O(n log n)

### 🔧 Template:

```csharp
var buckets = new List<int>[nums.Length + 1];

foreach (var pair in freqMap)
{
    int freq = pair.Value;
    if (buckets[freq] == null)
        buckets[freq] = new List<int>();

    buckets[freq].Add(pair.Key);
}
```

### 🧠 Common Problems:

- Top K Frequent Elements
- Sort Characters by Frequency
- Maximum Frequency Stack

---

## 🔁 8. **Two-Pass Map (for complex problems)**

### ✅ When to Use:

- Build a map in first pass
- Use relationships in second pass

### 🔧 Template:

```csharp
// First pass: copy values
var map = new Dictionary<Node, Node>();
var curr = head;
while (curr != null) {
    map[curr] = new Node(curr.val);
    curr = curr.next;
}

// Second pass: copy relations
curr = head;
while (curr != null) {
    map[curr].next = map.GetValueOrDefault(curr.next);
    map[curr].random = map.GetValueOrDefault(curr.random);
    curr = curr.next;
}
```

### 🧠 Common Problems:

- Copy List with Random Pointer
- Deep Copy Graph

---

## 🧠 Summary Table

| Pattern           | Data Structure    | Used For                   |
| ----------------- | ----------------- | -------------------------- |
| Frequency Counter | `Dictionary<K,V>` | Counting, Duplicates       |
| Set Lookup        | `HashSet<T>`      | Fast Search, Uniqueness    |
| Sliding Window    | Arrays/Strings    | Substrings/Subarrays       |
| Two Pointers      | Arrays            | Pairs, Optimization        |
| Prefix Sum        | Arrays            | Range Queries              |
| Sort + Scan       | Arrays            | Clustering, Deduplication  |
| Bucket Sort       | Lists/Arrays      | Frequency-based Sorting    |
| Two-Pass Map      | Dictionary<Node>  | Clone/Transform Structures |

---

## 🧩 Bonus Tip: Leetcode Tags to Practice

🔹 [Arrays Tag](https://leetcode.com/tag/array/)  
🔹 [Hash Table Tag](https://leetcode.com/tag/hash-table/)  
🔹 [Two Pointers](https://leetcode.com/tag/two-pointers/)  
🔹 [Sliding Window](https://leetcode.com/tag/sliding-window/)  
🔹 [Prefix Sum](https://leetcode.com/tag/prefix-sum/)
