# Code Screenshots – Chapter 3: Making Decisions

This README explains the C# code examples prepared for screenshots. Each section gives a suggested screenshot title, the code to display, and a short explanation/caption.

> **Note:** The uploaded slides teach Windows Forms controls such as `MessageBox`, `TextBox`, `RadioButton`, `CheckBox`, and `ListBox`. The examples below use those same kinds of controls. For a Windows Forms project, add the controls in the Visual Studio Designer and use the control names shown in each example.

## Screenshot 1 – Simple `if` Statement

```csharp
if (sales > 50000)
{
    bonus = 500;
}
```

**Explanation:** The program checks whether sales are greater than 50,000. If the condition is true, it assigns 500 to `bonus`. If the condition is false, the statement inside the `if` block is skipped.

## Screenshot 2 – `if-else` Statement

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

**Explanation:** This code checks a student's score. A score of 50 or higher displays “Pass”; otherwise, it displays “Fail”. Only one block runs.

## Screenshot 3 – Nested Decision Structure

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

**Explanation:** The program first checks the salary. When the salary condition is true, it checks the number of years at the current job. The user qualifies only when both requirements are met.

## Screenshot 4 – `if-else-if` Statement

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

**Explanation:** Several conditions are checked from top to bottom. The first condition that is true determines the grade. The final `else` handles scores that do not match the earlier conditions.

## Screenshot 5 – Logical Operators

```csharp
// AND: both conditions must be true
if (temperature < 20 && minutes > 12)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

// OR: at least one condition must be true
if (temperature < 20 || temperature > 100)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

// NOT: reverses the result
if (!(temperature > 100))
{
    MessageBox.Show("The temperature is below the maximum.");
}
```

**Explanation:** `&&` connects conditions that must both be true. `||` is true when one or both conditions are true. `!` reverses the Boolean result.

## Screenshot 6 – `bool` Variable and Flag

```csharp
bool isRegistered = true;

if (isRegistered)
{
    MessageBox.Show("Student is registered.");
}
```

**Explanation:** `isRegistered` is a Boolean flag. It stores `true` or `false` to indicate whether the student is registered.

## Screenshot 7 – Comparing Strings

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

**Explanation:** The `==` and `!=` operators compare strings. `String.Compare` can also compare two strings; a result of `0` means they are equal.

## Screenshot 8 – `TryParse`

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

**Explanation:** `int.TryParse` checks whether the text in the TextBox can be converted to an integer. The `out` variable receives the converted number when conversion succeeds.

## Screenshot 9 – Input Validation

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

**Explanation:** The first check confirms that the input is an integer. The second check confirms that the number is within the acceptable range. This shows the difference between conversion checking and input validation.

## Screenshot 10 – Radio Button and Check Box

```csharp
if (choiceRadioButton.Checked)
{
    MessageBox.Show("This radio button is selected.");
}

if (option1CheckBox.Checked)
{
    MessageBox.Show("This check box is selected.");
}
```

**Explanation:** The `Checked` property tells the program whether a RadioButton or CheckBox is selected. Radio buttons in one group allow one choice; check boxes allow multiple choices.

## Screenshot 11 – `CheckedChanged` Event

```csharp
private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
{
    if (yellowRadioButton.Checked)
    {
        MessageBox.Show("Yellow was selected.");
    }
}
```

**Explanation:** This event handler responds when the radio button's `Checked` property changes. The message appears when the yellow option becomes selected.

## Screenshot 12 – `switch` Statement

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

**Explanation:** The `switch` statement compares `day` with each case value. The matching case runs. `default` runs if no case matches, and `break` exits the selected case.

## Screenshot 13 – Add Items to a ListBox

```csharp
daysListBox.Items.Add("Monday");
daysListBox.Items.Add("Tuesday");
daysListBox.Items.Add("Wednesday");
```

**Explanation:** `Items.Add` inserts new items into the ListBox. The list displays Monday, Tuesday, and Wednesday.

## Screenshot 14 – Get the Selected ListBox Item

```csharp
if (fruitListBox.SelectedIndex != -1)
{
    string selectedFruit = fruitListBox.SelectedItem.ToString();
    MessageBox.Show(selectedFruit);
}
```

**Explanation:** `SelectedIndex != -1` checks that an item has been selected. The code then reads the selected item safely. The check helps avoid an error when the ListBox has no selection.

## Screenshot 15 – Remove and Clear ListBox Items

```csharp
daysListBox.Items.Remove("Tuesday");
daysListBox.Items.RemoveAt(2);
daysListBox.Items.Clear();
```

**Explanation:** `Remove` deletes a specific item by value. `RemoveAt` deletes the item at a given zero-based index. `Clear` removes every item from the ListBox. Use a valid index with `RemoveAt`.

---

## Screenshot checklist

- [ ] Capture the code for each screenshot section.
- [ ] Make sure the code and its title are visible and readable.
- [ ] Use Visual Studio with C# syntax highlighting if available.
- [ ] Do not crop off braces, conditions, or important lines.
- [ ] Save the images in order, for example `01-if.png`, `02-if-else.png`, and so on.
- [ ] Put the screenshots in a folder named `screenshots`.

## Important setup note

The snippets are teaching examples, not one complete program to paste all at once. Some names (`sales`, `bonus`, `score`, `hoursTextBox`, `daysListBox`, and others) represent variables or Windows Forms controls that must be declared or created in the project before the corresponding snippet is used.
