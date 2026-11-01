# Week 4 – Loops (C#)

## 1. What is a Loop?
A **loop** is a control structure that repeats a statement or group of statements while a condition is satisfied or for a specified number of times. Loops help avoid writing the same code repeatedly.

## 2. The `while` Loop
- A `while` loop repeats statements as long as its Boolean condition is `true`.
- It checks the condition before executing the body, so it is a **pretest loop**.
- If the condition is false at the beginning, the body does not execute.
- The loop body should update the condition when necessary to avoid an infinite loop.

```csharp
int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
    count++;
}
```

## 3. Counter Variables
A **counter variable** tracks how many times a loop executes. It is usually initialized before or in the loop, tested in the condition, and updated during each iteration.

## 4. Infinite Loops
An **infinite loop** continues without ending because its condition never becomes false. A common cause is forgetting to update the counter variable.

```csharp
int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
    // Error: count is never increased.
}
```

## 5. Increment and Decrement Operators
- Increment means increase a variable by one: `count++`.
- Decrement means decrease a variable by one: `count--`.
- `count += 1` and `count = count + 1` also add one.
- `count -= 1` and `count = count - 1` also subtract one.

```csharp
int count = 0;
count++;  // count becomes 1
count--;  // count becomes 0
```

### Prefix and Postfix
- **Postfix** (`count++`): use the current value first, then increment.
- **Prefix** (`++count`): increment first, then use the new value.

```csharp
int a = 5;
int x = a++; // x is 5; a becomes 6

int b = 5;
int y = ++b; // b becomes 6; y is 6
```

## 6. The `for` Loop
A `for` loop is useful when the number of repetitions is known or controlled by a counter. It contains three expressions:
1. **Initialization** – gives the counter its starting value; runs once.
2. **Test** – Boolean condition checked before each iteration.
3. **Update** – changes the counter after each iteration.

```csharp
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}
```

A `for` loop is also a pretest loop. Its counter can increase by more than one or count backward.

```csharp
for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}

for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}
```

## 7. The `do-while` Loop
- A `do-while` loop executes its body first and checks the condition afterward.
- It is a **posttest loop**.
- Therefore, its body always executes at least once.
- Notice the semicolon after the `while` condition.

```csharp
int number = 1;
do
{
    MessageBox.Show(number.ToString());
    number++;
}
while (number <= 5);
```

## 8. Comparing the Three Loops

| Loop | When condition is checked | Guaranteed to run once? |
|---|---|---|
| `while` | Before the body | No |
| `for` | Before the body | No |
| `do-while` | After the body | Yes |

## Quick Revision
- Loop = repeats code.
- Iteration = one execution of the loop body.
- `while` = repeats while condition is true; pretest.
- `for` = initialization, test, update; pretest.
- `do-while` = body first, condition second; posttest.
- `++` = increment; `--` = decrement.
- Prefix changes the value before it is used; postfix uses the old value first.
- Infinite loop = loop that does not stop because its condition never becomes false.
