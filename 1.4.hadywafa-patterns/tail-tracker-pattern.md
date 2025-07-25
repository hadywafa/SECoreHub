# Tail Tracker Pattern

```js
var last = current;
while (current != null) {
  last = current;
  current = current.next;
}
```

وده **Pattern كلاسيكي بيتكرر في Linked Lists أو أي Structure فيه سلسلة (next pointer)**.

---

## 🔍 إيه اللي بيعمله الكود؟

- بيبدأ من `current` (أول عنصر).
- ويمشي واحد ورا التاني باستخدام `.next`.
- وكل مرة بيسجل `last = current`، بحيث لما `current` يوصل لـ `null`، يفضل `last` هو **آخر عنصر حقيقي في السلسلة**.

---

## 💡 تشبيه واقعي — "أوتوبيس بيعدّي على المحطات"

### 🚍 _تخيل إنك قاعد في أوتوبيس وعايز تعرف آخر محطة قبل ما الأوتوبيس يوقف تماما_

- كل محطة عندها مؤشر بيقولك "المحطة الجاية هي كذا" (`.next`)
- وانت قاعد بتسجّل في كراسة كل محطة بتعدي عليها.
- لما توصل لمحطة مفيش بعدها (`next = null`)، ساعتها آخر محطة كتبتها في الكراسة هي `last`.

---

## 🧠 خلاصة التشبيه

| الكود                     | التشبيه الواقعي                      |
| ------------------------- | ------------------------------------ |
| `current = current.next`  | الأوتوبيس بيتحرك للمحطة اللي بعدها   |
| `last = current`          | بتسجّل اسم المحطة الحالية في الكراسة |
| `while (current != null)` | بتكمل تسجّل طول ما الأوتوبيس ماشي    |
| `last`                    | آخر محطة عدّى عليها الأوتوبيس فعليًا |

---

## 🧠 Pattern name

ده اسمه أحيانًا **“Tail Tracker Pattern”** أو **“Last-Node Finder”**
وبيستخدم في:

- معرفة نهاية Linked List
- عمليات الـ Reverse
- Append للـ Tail
- Detect if list is circular (لو مش بيوقف عند null)

---

## 🎉 الخلاصة الممتعة

> الكود ده هو:
> **"رحلة موظف بيدوّر على آخر محطة في خط الأوتوبيس، وبيسجّل كل محطة لحد ما يوصل لمحطة مفيش بعدها!"**

---

```js
// 🚌 الأوتوبيس بيبدأ رحلته من أول محطة
var current = firstStation;

// 📝 السكرتير معاه كراسة وبيكتب فيها اسم كل محطة بيمر عليها
var last = current;

// 🛣️ طول ما فيه محطة جاي بعدها، نكمل نتحرك
while (current != null) {
  // 📝 سجّل المحطة الحالية في الكراسة
  last = current;

  // ⏭️ نروح للمحطة اللي بعدها
  current = current.next;
}

// ✅ لما اللوب يخلص، يبقى last هي آخر محطة عدينا عليها قبل ما الأوتوبيس يقف!
```
