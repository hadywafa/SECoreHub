namespace NeetCode.Stack;

public class P853
{
    public static void Run()
    {
        int target = 12;
        int[] position = [10, 8, 0, 5, 3];
        int[] speed = [2, 4, 1, 1, 3];
        var result = CarFleet(target, position, speed);
        System.Console.WriteLine(result);
    }

    /*
    ## Summary — How to Know If Cars Form a Fleet?

    * Sort cars from closest to target to farthest.
    * Calculate time to reach destination for each.
    * **Use a stack**:

    * If a car takes **longer** than the fleet in front of it → it **can’t catch up**, so it’s a **new fleet**.
    * If it takes **less or equal time**, it **catches up** and **joins** the previous fleet.

    */

    public static int CarFleet(int target, int[] position, int[] speed)
    {
        int n = position.Length;

        // Step 1: Pair each car's position with its speed
        var cars = new List<(int pos, int speed)>();
        for (int i = 0; i < n; i++)
        {
            cars.Add((position[i], speed[i]));
        }

        // Step 2: Sort cars by position descending (starting from the closest to target)
        cars.Sort((a, b) => b.pos.CompareTo(a.pos));

        // Step 3: Use stack to track fleets based on time to reach target
        Stack<double> stack = new Stack<double>();

        foreach (var (pos, spd) in cars)
        {
            double time = (double)(target - pos) / spd;

            // Only add to stack if this car creates a new fleet
            if (stack.Count == 0 || time > stack.Peek())
            {
                stack.Push(time); // new fleet
            }
            // else, it joins a fleet ahead of it (do nothing)
        }

        return stack.Count; // number of fleets
    }
}
/*

## 🎯 What Are We Doing?

You're calculating **time = (target - position) / speed** for each car.

### 🧠 Why?

Because:

* You want to know **how long each car will take to reach the destination**.
* A **faster car starting behind a slower car** may **catch up and form a fleet**.

But remember: **no car can pass another**. So if it catches up, it must **slow down and stay with it** — forming a fleet.

---

## 🏁 The Core Idea (Fleet Formation from Time):

We go from **right (near target)** to **left (far from target)** and track:

> 🔁 If a car behind takes **less time**, it will **catch up** and join the car ahead (→ **no new fleet**).

> ➕ If a car takes **more time**, it means it’s **slower and can't catch** any fleet ahead of it → it's a **new fleet**.

---

## 🔍 Real Example

```csharp
target = 12;
position = [10,8,0,5,3];
speed    = [2, 4,1,1,3];
```

Let’s pair position with speed:

```
(10, 2) → time = (12-10)/2 = 1.0
(8, 4)  → time = (12-8)/4 = 1.0
(5, 1)  → time = (12-5)/1 = 7.0
(3, 3)  → time = (12-3)/3 = 3.0
(0, 1)  → time = (12-0)/1 = 12.0
```

Now sort them by **position descending** (starting closest to target):

```
(10, 2) → 1.0
(8, 4)  → 1.0
(5, 1)  → 7.0
(3, 3)  → 3.0
(0, 1)  → 12.0
```

---

## 📚 How Fleet Check Works:

### Stack initially empty → count = 0

Now go one by one from closest to farthest:

1. (10, 2) → time = 1.0 → stack = \[1.0] (new fleet ✅)
2. (8, 4)  → time = 1.0

   * time <= top of stack (1.0) → **joins the previous fleet** ❌
3. (5, 1)  → time = 7.0

   * 7.0 > 1.0 → can't catch any → new fleet → stack = \[1.0, 7.0] ✅
4. (3, 3)  → time = 3.0

   * 3.0 < 7.0 → will catch up → **joins fleet with (5,1)** ❌
5. (0, 1)  → time = 12.0

   * 12.0 > 7.0 → too slow → new fleet → stack = \[1.0, 7.0, 12.0] ✅

---

## ✅ Final Answer:

`stack.Count = 3` → 3 car fleets will arrive.

---

## 🧠 Summary — How to Know If Cars Form a Fleet?

* Sort cars from closest to target to farthest.
* Calculate time to reach destination for each.
* **Use a stack**:

  * If a car takes **longer** than the fleet in front of it → it **can’t catch up**, so it’s a **new fleet**.
  * If it takes **less or equal time**, it **catches up** and **joins** the previous fleet.

---

Want a **visual drawing or animation** in Mermaid or diagram form? I can do that too if it helps!

*/
