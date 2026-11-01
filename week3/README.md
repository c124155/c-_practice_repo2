# Chapter 3 – Making Decisions (C#)

> **Study notes:** These notes summarize the concepts shown in the uploaded PowerPoint. The slides call the chapter **“Making Decisions”** and list sections **4.1–4.11**.

## 1. Decision Structures and the `if` Statement

- A **control structure** controls the order in which program statements execute.
- A **sequence structure** runs statements in the order they appear.
- A **decision structure** runs statements only when a condition is satisfied. It is also called a **selection structure**.
- A simple `if` statement is a **single-alternative** decision: it has one possible action when the condition is `true`.
- The condition in an `if` statement is a Boolean expression. It evaluates to `true` or `false`.

```csharp
if (sales > 50000)
{
    bonus = 500;
}
```

## 2. Relational Operators

Relational operators compare two values and produce a Boolean result.

| Operator | Meaning | Example |
|---|---|---|
| `>` | Greater than | `x > y` |
| `<` | Less than | `x < y` |
| `>=` | Greater than or equal to | `x >= y` |
| `<=` | Less than or equal to | `x <= y` |
| `==` | Equal to | `x == y` |
| `!=` | Not equal to | `x != y` |

**Remember:** In C#, `=` assigns a value, while `==` compares two values.

## 3. The `if-else` Statement

- An `if-else` statement has two paths.
- If the Boolean expression is `true`, the `if` block executes.
- If it is `false`, the `else` block executes.
- Only one of the two blocks runs.

```csharp
if (score >= 50)
{
    MessageBox.Show("Pass");
}
else
{
    MessageBox.Show("Fail");
}
```

## 4. Nested Decision Structures

- **Nested** means one decision structure is placed inside another.
- Nested `if` statements allow a program to test more than one condition.
- The inner decision is reached only when execution enters its containing block.

```csharp
if (salary >= 30000)
{
    if (yearsOnJob >= 2)
    {
        MessageBox.Show("You qualify for the loan");
    }
    else
    {
        MessageBox.Show("Minimum years at current job not met");
    }
}
else
{
    MessageBox.Show("Minimum salary requirement not met");
}
```

## 5. The `if-else-if` Statement

- Use `if-else-if` when a program must evaluate several conditions.
- Conditions are checked from top to bottom.
- The first condition that is `true` has its block executed.
- The final `else` is optional and handles cases where none of the earlier conditions is true.

```csharp
if (score >= 90)
{
    grade = "A";
}
else if (score >= 80)
{
    grade = "B";
}
else if (score >= 70)
{
    grade = "C";
}
else
{
    grade = "Needs improvement";
}
```

## 6. Logical Operators

Logical operators connect or reverse Boolean expressions.

| Operator | Name | Meaning |
|---|---|---|
| `&&` | AND | Both expressions must be `true`. |
| `||` | OR | At least one expression must be `true`. |
| `!` | NOT | Reverses a Boolean value. |

Examples:

```csharp
if (temperature < 20 && minutes > 12)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

if (temperature < 20 || temperature > 100)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

if (!(temperature > 100))
{
    MessageBox.Show("The temperature is below the maximum.");
}
```

## 7. `bool` Variables and Flags

- A `bool` variable stores only `true` or `false`.
- A **flag** is a variable used to signal whether a condition exists.
- `true` means the condition exists; `false` means it does not.

```csharp
bool isRegistered = true;

if (isRegistered)
{
    MessageBox.Show("Student is registered.");
}
```

## 8. Comparing Strings

- The `==` operator can compare two strings.
- A string variable can also be compared with a string literal.
- `String.Compare` can compare two strings. A result of `0` means the strings are equal.

```csharp
if (name1 == name2)
{
    MessageBox.Show("The names match.");
}

if (name1 != "bob")
{
    MessageBox.Show("The name is not bob.");
}

if (String.Compare(name1, name2) == 0)
{
    MessageBox.Show("The names match.");
}
```

## 9. Preventing Data Conversion Exceptions with `TryParse`

- User input may not be in the expected numeric format.
- `TryParse` checks whether text can be converted to a specified data type.
- Common methods include `int.TryParse`, `double.TryParse`, and `decimal.TryParse`.
- The general pattern is `DataType.TryParse(input, out targetVariable)`.
- The `out` keyword is required; the method places the converted value in the target variable.
- `TryParse` checks whether the input can be converted. It does **not** prove that the value is reasonable for the program.

```csharp
int hours;

if (int.TryParse(hoursTextBox.Text, out hours))
{
    MessageBox.Show("The input is a number.");
}
else
{
    MessageBox.Show("Enter a valid whole number.");
}
```

## 10. Input Validation

- **Input validation** means checking entered data before using it.
- `TryParse` checks the data format, but additional conditions may be needed to check whether the value makes sense.
- Example: hours worked in a week must be greater than `0` and no more than `168`.
- Example: a test score must be from `0` through `100`.
- For example, `999` can be parsed as an integer, but it is not a reasonable number of working hours in one week.

```csharp
int hours;

if (int.TryParse(hoursTextBox.Text, out hours))
{
    if (hours > 0 && hours <= 168)
    {
        MessageBox.Show("Valid hours.");
    }
    else
    {
        MessageBox.Show("Hours must be from 1 to 168.");
    }
}
else
{
    MessageBox.Show("Enter a whole number.");
}
```

## 11. Radio Buttons and Check Boxes

### Radio buttons

- Radio buttons let the user select **one** choice from several choices in a group.
- Selecting one radio button automatically deselects the others in that group. This is called **mutually exclusive selection**.
- Common properties:
  - `Text`: text displayed next to the control.
  - `Checked`: Boolean value indicating whether it is selected.

```csharp
if (choiceRadioButton.Checked)
{
    MessageBox.Show("This choice is selected.");
}
```

### Check boxes

- Check boxes let the user select **multiple** options.
- They are often used for yes/no or true/false options.
- They also use the `Text` and `Checked` properties.

```csharp
if (option1CheckBox.Checked)
{
    MessageBox.Show("Option 1 is selected.");
}
```

### `CheckedChanged` event

- A `CheckedChanged` event is raised when a radio button's or check box's `Checked` property changes.
- An event handler contains the code that responds to that change.
- Double-clicking the control in the Visual Studio Designer can create an empty event handler.

```csharp
private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
{
    if (yellowRadioButton.Checked)
    {
        MessageBox.Show("Yellow was selected.");
    }
}
```

## 12. The `switch` Statement

- `switch` is a multiple-alternative decision structure.
- It chooses a path based on the value of an expression.
- It can be an alternative to an `if-else-if` structure when checking one expression against several values.
- Each `case` identifies a value.
- `break` ends that case.
- `default` is optional and runs when no case matches.

```csharp
switch (day)
{
    case "Monday":
        MessageBox.Show("Start of the week.");
        break;

    case "Friday":
        MessageBox.Show("End of the work week.");
        break;

    default:
        MessageBox.Show("Another day.");
        break;
}
```

## 13. Introduction to List Boxes

- A **ListBox** displays a list of items and lets the user select an item.
- Important properties:
  - `Text`: text of the currently selected item.
  - `Items`: the collection of items in the ListBox.
  - `Items.Count`: number of items.
  - `SelectedItem`: the currently selected item.
  - `SelectedIndex`: zero-based position of the selected item.
- Indexes start at `0`. The first item has index `0`; the nth item has index `n - 1`.
- If no item is selected, `SelectedIndex` is `-1`.
- Accessing `SelectedItem` when nothing is selected can cause an exception, so check the selection first.
- `SelectedItem` is an object; `Text` is a string. Use the property that suits the task.

### Add items

```csharp
daysListBox.Items.Add("Monday");
daysListBox.Items.Add("Tuesday");
daysListBox.Items.Add("Wednesday");
```

### Read the selected item safely

```csharp
if (fruitListBox.SelectedIndex != -1)
{
    string selectedFruit = fruitListBox.SelectedItem.ToString();
    MessageBox.Show(selectedFruit);
}
```

### Remove and clear items

```csharp
daysListBox.Items.Remove("Tuesday"); // Removes a specific item
daysListBox.Items.RemoveAt(2);       // Removes the item at index 2
daysListBox.Items.Clear();           // Removes all items
```

**Important:** `RemoveAt` needs a valid index. An invalid index can cause an exception.

---

## Quick Revision

- `if`: one action when a condition is true.
- `if-else`: choose between two paths.
- Nested `if`: put one decision inside another.
- `if-else-if`: test several conditions in order.
- `&&`: AND; both conditions must be true.
- `||`: OR; at least one condition must be true.
- `!`: NOT; reverses true/false.
- `bool`: stores true or false; often used as a flag.
- `TryParse`: checks whether text can be converted.
- Input validation: checks whether entered data is acceptable.
- RadioButton: choose one option in a group.
- CheckBox: choose multiple options.
- `switch`: choose a path based on matching cases.
- ListBox: display and select items from a list.
