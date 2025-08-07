# 📚 Common Patterns for Solving LinkedList Problems in `C#`

These reusable code blocks will save your life in LeetCode and interviews — especially at Amazon, Meta, or Microsoft.

---

## 📖 1. LinkedList to List (Array Conversion)

📌 **Use this to flatten the list into a more manageable array/list. Useful for reversing, indexing, sorting, etc.**

```csharp
var list = new List<int>();
while (head != null)
{
    list.Add(head.val);
    head = head.next;
}
```

---

## 📖 2. List to LinkedList

📌 **Build a new list from an array or `List<int>` — usually when reconstructing results.**

```csharp
ListNode head = null;
ListNode current = null;
for (int i = 0; i < list.Count; i++)
{
    var newNode = new ListNode(list[i]);
    if (head == null)
    {
        head = newNode;
        current = head;
    }
    else
    {
        current.next = newNode;
        current = current.next;
    }
}
```

---

## 📖 3. Copy LinkedList

```csharp
Node newHead = null;
Node current = null;

while (oldHead != null)
{
    var newNode = new Node(oldHead.val);
    if (newHead == null)
    {
        newHead = current = newNode;
    }
    else
    {
        current.next = newNode;
        current = current.next;
    }

    oldHead = oldHead.next;
}
```

---

## 📖 4. Reverse LinkedList (Iterative)

📌 **One of the most common operations. Master this cold.**

```csharp
ListNode prev = null;
while (head != null)
{
    ListNode next = head.next;
    head.next = prev;
    prev = head;
    head = next;
}
// prev is the new head
```

---

## 📖 5. Two Pointers (Slow & Fast) — for Middle or Cycle

📌 **Classic for finding middle node or detecting a cycle.**

```csharp
ListNode slow = head, fast = head;
while (fast != null && fast.next != null)
{
    slow = slow.next;
    fast = fast.next.next;
}
```

- For **middle**: return `slow`

  ```cs
  public ListNode MiddleNode(ListNode head) {
      ListNode slow = head;
      ListNode fast = head;
      while (fast != null && fast.next != null) {
          slow = slow.next;
          fast = fast.next.next;
      }
      return slow; // slow is at the middle
  }
  ```

- For **cycle detection**: if `slow == fast`, there’s a cycle

  ```cs
  public bool HasCycle(ListNode head) {
      ListNode slow = head;
      ListNode fast = head;
      while (fast != null && fast.next != null)
      {
          slow = slow.next;
          fast = fast.next.next;
          if (slow == fast)
              return true; // They met — cycle detected
      }
      return false; // fast reached null — no cycle
  }
  ```

---

## 📖 6. Dummy Node Pattern

📌 **Best practice for building new linked lists without null checks.**

```csharp
ListNode dummy = new ListNode(0);
ListNode current = dummy;

while (someCondition)
{
    current.next = new ListNode(someValue);
    current = current.next;
}

return dummy.next;
```

---

## 📖 7. Merge Two Sorted Lists

📌 **Used in merge sort and interview problems.**

```csharp
ListNode dummy = new ListNode(0);
ListNode tail = dummy;

while (l1 != null && l2 != null)
{
    if (l1.val < l2.val)
    {
        tail.next = l1;
        l1 = l1.next;
    }
    else
    {
        tail.next = l2;
        l2 = l2.next;
    }
    tail = tail.next;
}
tail.next = l1 ?? l2;

return dummy.next;
```

---

## 📖 8. Remove N-th Node from End

📌 **Uses dummy node + two pointers**

```csharp
ListNode dummy = new ListNode(0);
dummy.next = head;
ListNode fast = dummy, slow = dummy;

// Move fast n+1 steps
for (int i = 0; i <= n; i++) fast = fast.next;

// Move both until fast reaches end
while (fast != null)
{
    fast = fast.next;
    slow = slow.next;
}

// Remove the node
slow.next = slow.next.next;
return dummy.next;
```

---

## 📖 9. Detect and Find Start of Cycle

📌 **Classic Floyd’s algorithm**

```csharp
ListNode slow = head, fast = head;
while (fast != null && fast.next != null)
{
    slow = slow.next;
    fast = fast.next.next;
    if (slow == fast) break;
}

if (fast == null || fast.next == null) return null; // No cycle

slow = head;
while (slow != fast)
{
    slow = slow.next;
    fast = fast.next;
}

return slow;
```

---

## 📖 10. Length of LinkedList

```csharp
int length = 0;
while (head != null)
{
    length++;
    head = head.next;
}
```

---

## 📖 11. Remove Node From LinkedList O(1)

```CS
// 1. Remove a node from the list
void Remove(Node node)
{
    node.prev.next = node.next;
    node.next.prev = node.prev;
}
```

## 🤔 LinkedList.Remove(node) is O(1)

Let me explain **exactly why** this is **still O(1)** when we do:

```csharp
list.Remove(node1);
```

---

### ⚙️ 🔍 C# `LinkedList<T>` Internals

When you call:

```csharp
LinkedList<T> list = new LinkedList<T>();
LinkedListNode<T> node = new LinkedListNode<T>(42);
list.AddFirst(node);
```

You're working with this structure:

```csharp
Head <--> node <--> Tail
```

---

#### ❗ The Key Insight:

```csharp
list.Remove(node);
```

is **O(1)** because:

- You're passing the **exact node object** (a reference).
- The `LinkedList<T>` does **not search for it** — it already has the reference.
- Internally, it simply updates:

```csharp
node.Previous.Next = node.Next;
node.Next.Previous = node.Previous;
```

#### ✅ You Are Not Searching — You're Directly Unlinking!

That’s why it’s **constant time**.

---

### ❌ But This Is Not O(1):

```csharp
list.Remove(42);
```

Because here, it has to:

1. Traverse the list to **find the node that contains value `42`**
2. Then unlink it

That’s **O(n)** because of the **search**.

---

### ✅ Real-World Analogy

- `list.Remove(node)` = "I give you the exact book 📘, just remove it" → **O(1)**
- `list.Remove(42)` = "Find me the book with ID 42 and remove it" → **O(n)**

---

### 📌 In Our LRU Code

We keep:

```csharp
Dictionary<int, LinkedListNode<KeyValuePair<int, int>>> map;
```

So we **never have to search the list** — we always access the node by key:

```csharp
var node = map[key];        // O(1)
list.Remove(node);          // O(1)
list.AddFirst(node);        // O(1)
```

That’s how `get()` and `put()` both stay **O(1)** 🎯

---

## 🧠 Bonus: C# Smart Tips

| Problem                   | Use This                                      |
| ------------------------- | --------------------------------------------- |
| `int.Parse(char)` slow    | Use `char - '0'` for single digit             |
| Avoid `if (head == null)` | Use dummy node                                |
| Rebuilding list           | Use `List<int>` or `Stack<int>` for reversing |

---

## ✅ Final Notes for Interviews

You can now handle:

- Copy lists
- Reverse lists
- Remove/insert/move nodes
- Detect cycles
- Two-pointer traversal
- Merge problems
- Array ↔ List conversion

🧠 **Mastering these gives you tools to solve 90%+ of LinkedList problems.**
