# Week 4 – Code Screenshots Guide

This file explains each C# example to capture as a screenshot. Open the code in Visual Studio or another C# editor, show one example at a time, and capture it clearly.

## Screenshot 1 – Basic `while` Loop

```csharp
int count = 0;

while (count < 5)
{
    MessageBox.Show("Hello");
    count++;
}
```

**Explanation:** The loop checks whether `count` is less than 5. It displays “Hello” and increases the counter until the condition becomes false. It runs five times.

## Screenshot 2 – Infinite Loop Example (Study Only)

```csharp
int count = 0;

while (count < 5)
{
    MessageBox.Show("Hello");
    // count is not updated, so the condition stays true.
}
```

**Explanation:** This is an example of an infinite loop because `count` never increases. Do not run this example in a normal application; it can make the application appear stuck.

## Screenshot 3 – Increment and Decrement

```csharp
int count = 5;

count++;
MessageBox.Show(count.ToString()); // 6

count--;
MessageBox.Show(count.ToString()); // 5
```

**Explanation:** `++` increases the value by one, while `--` decreases it by one.

## Screenshot 4 – Prefix and Postfix

```csharp
int a = 5;
int x = a++; // x = 5, a = 6

int b = 5;
int y = ++b; // b = 6, y = 6
```

**Explanation:** Postfix uses the old value before changing it. Prefix changes the value first, then uses the new value.

## Screenshot 5 – Basic `for` Loop

```csharp
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}
```

**Explanation:** Initialization sets `count` to zero. The condition is checked before each iteration. `count++` updates the counter after each iteration.

## Screenshot 6 – `for` Loop Counting by 10

```csharp
for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}
```

**Explanation:** The counter starts at zero and increases by ten until it reaches 100.

## Screenshot 7 – `for` Loop Counting Backward

```csharp
for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}
```

**Explanation:** The counter starts at ten and decreases by one until it reaches zero.

## Screenshot 8 – `do-while` Loop

```csharp
int number = 1;

do
{
    MessageBox.Show(number.ToString());
    number++;
}
while (number <= 5);
```

**Explanation:** The body executes before the condition is checked. The loop displays numbers 1 through 5. The semicolon after the condition is required.

## Screenshot Checklist
- [ ] Capture each example separately.
- [ ] Keep the screenshot title and complete code visible.
- [ ] Use readable font size and C# syntax highlighting.
- [ ] Do not crop off braces, conditions, or semicolons.
- [ ] Save screenshots as `01-while.png`, `02-infinite-loop.png`, `03-increment-decrement.png`, etc.
- [ ] Save all images in a folder named `screenshots`.

**Note:** The infinite-loop example is for understanding only. Do not execute it because it may freeze or block the application.
