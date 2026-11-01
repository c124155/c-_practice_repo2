# Week 5 – Code Screenshots Guide

Capture each code sample separately. These examples cover file handling, dialogs, random numbers, the Load event, and the Making Decisions topics.

# Part A – Files and Other Chapter Topics

## Screenshot 1 – Write to a Text File

```csharp
using System.IO;

using (StreamWriter outputFile = File.CreateText("courses.txt"))
{
    outputFile.WriteLine("Computer Science");
    outputFile.WriteLine("English");
}
```

**Explanation:** `StreamWriter` writes text to a file. `CreateText` creates the file or replaces its existing contents. `WriteLine` writes each item on a separate line. The `using` block closes the file automatically.

## Screenshot 2 – Append to a Text File

```csharp
using (StreamWriter outputFile = File.AppendText("courses.txt"))
{
    outputFile.WriteLine("Mathematics");
}
```

**Explanation:** `AppendText` adds new information to the end of an existing file instead of replacing its contents.

## Screenshot 3 – Read a Text File

```csharp
using (StreamReader inputFile = File.OpenText("courses.txt"))
{
    string line = inputFile.ReadLine();

    while (line != null)
    {
        MessageBox.Show(line);
        line = inputFile.ReadLine();
    }
}
```

**Explanation:** `StreamReader` reads text from a file. `ReadLine` reads one line at a time. The loop continues until there are no more lines.

## Screenshot 4 – Read Using `EndOfStream`

```csharp
using (StreamReader inputFile = File.OpenText("courses.txt"))
{
    while (!inputFile.EndOfStream)
    {
        string line = inputFile.ReadLine();
        MessageBox.Show(line);
    }
}
```

**Explanation:** `EndOfStream` becomes true when the end of the file is reached. The loop reads while the end has not yet been reached.

## Screenshot 5 – OpenFileDialog

```csharp
private void openButton_Click(object sender, EventArgs e)
{
    if (openFileDialog1.ShowDialog() == DialogResult.OK)
    {
        string selectedPath = openFileDialog1.FileName;
        MessageBox.Show(selectedPath);
    }
}
```

**Explanation:** The Open dialog lets the user select a file. The program checks for `DialogResult.OK` before using the selected file path.

## Screenshot 6 – SaveFileDialog

```csharp
private void saveButton_Click(object sender, EventArgs e)
{
    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
    {
        using (StreamWriter outputFile =
               File.CreateText(saveFileDialog1.FileName))
        {
            outputFile.WriteLine("My saved information");
        }
    }
}
```

**Explanation:** The Save dialog lets the user choose a file name and location. If the user confirms, the program writes text to that file.

## Screenshot 7 – Random Numbers

```csharp
Random rand = new Random();

int anyNumber = rand.Next();
int diceNumber = rand.Next(1, 7);
double decimalNumber = rand.NextDouble();

MessageBox.Show(diceNumber.ToString());
```

**Explanation:** `Random` creates pseudo-random values. `Next(1, 7)` returns an integer from 1 through 6. `NextDouble()` returns a value from 0.0 up to, but not including, 1.0.

## Screenshot 8 – Form Load Event

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Welcome!");
}
```

**Explanation:** This event handler runs when the form loads. It displays a welcome message when the form starts.

# Part B – Making Decisions

## Screenshot 9 – Simple `if`

```csharp
if (sales > 50000)
{
    bonus = 500;
}
```

**Explanation:** The bonus is assigned only when sales are greater than 50,000.

## Screenshot 10 – `if-else`

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

**Explanation:** The program displays Pass for a score of 50 or above; otherwise it displays Fail.

## Screenshot 11 – Nested `if`

```csharp
if (salary >= 30000)
{
    if (yearsOnJob >= 2)
    {
        MessageBox.Show("You qualify for the loan");
    }
    else
    {
        MessageBox.Show("Minimum years not met");
    }
}
else
{
    MessageBox.Show("Minimum salary not met");
}
```

**Explanation:** The program checks salary first, then checks years at the job if the salary requirement is met.

## Screenshot 12 – `if-else-if`

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

**Explanation:** Conditions are tested from top to bottom. The first true condition determines the grade.

## Screenshot 13 – Logical Operators

```csharp
if (age >= 18 && hasID)
{
    MessageBox.Show("Both conditions are true.");
}

if (score < 50 || absent)
{
    MessageBox.Show("At least one condition is true.");
}

if (!hasID)
{
    MessageBox.Show("ID is not available.");
}
```

**Explanation:** `&&` means both conditions must be true. `||` means at least one must be true. `!` reverses a Boolean value.

## Screenshot 14 – `bool` Flag

```csharp
bool isRegistered = true;

if (isRegistered)
{
    MessageBox.Show("Student is registered.");
}
```

**Explanation:** The Boolean flag records whether the student is registered.

## Screenshot 15 – Comparing Strings

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
    MessageBox.Show("The names compare as equal.");
}
```

**Explanation:** String values can be compared with `==`, `!=`, and `String.Compare`.

## Screenshot 16 – TryParse

```csharp
int age;

if (int.TryParse(ageTextBox.Text, out age))
{
    MessageBox.Show("Valid integer format.");
}
else
{
    MessageBox.Show("Please enter a whole number.");
}
```

**Explanation:** `TryParse` checks whether the entered text can be converted to an integer without throwing a conversion exception.

## Screenshot 17 – Input Validation

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

**Explanation:** First, the code checks that the input is an integer. Then it checks that the number is within the acceptable range.

## Screenshot 18 – RadioButton and CheckBox

```csharp
if (choiceRadioButton.Checked)
{
    MessageBox.Show("Radio button is selected.");
}

if (option1CheckBox.Checked)
{
    MessageBox.Show("Check box is selected.");
}
```

**Explanation:** `Checked` tells whether a control is selected. Radio buttons in the same group allow one choice; check boxes allow multiple choices.

## Screenshot 19 – CheckedChanged Event

```csharp
private void yellowRadioButton_CheckedChanged(
    object sender, EventArgs e)
{
    if (yellowRadioButton.Checked)
    {
        MessageBox.Show("Yellow was selected.");
    }
}
```

**Explanation:** The event handler responds when the radio button's checked state changes.

## Screenshot 20 – `switch`

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

**Explanation:** `switch` selects a case based on the value of `day`. `default` handles values that do not match a case.

## Screenshot 21 – Add Items to a ListBox

```csharp
daysListBox.Items.Add("Monday");
daysListBox.Items.Add("Tuesday");
daysListBox.Items.Add("Wednesday");
```

**Explanation:** `Items.Add` adds new entries to the ListBox.

## Screenshot 22 – Read Selected ListBox Item

```csharp
if (fruitListBox.SelectedIndex != -1)
{
    string selectedFruit =
        fruitListBox.SelectedItem.ToString();

    MessageBox.Show(selectedFruit);
}
```

**Explanation:** `SelectedIndex != -1` confirms that an item is selected before reading `SelectedItem`.

## Screenshot 23 – Remove and Clear ListBox Items

```csharp
daysListBox.Items.Remove("Tuesday");

if (daysListBox.Items.Count > 2)
{
    daysListBox.Items.RemoveAt(2);
}

daysListBox.Items.Clear();
```

**Explanation:** `Remove` deletes an item by value. `RemoveAt` deletes an item by its zero-based index. `Clear` removes all items.

---

## Screenshot Checklist
- [ ] Capture each example separately.
- [ ] Make sure the screenshot title and complete code are visible.
- [ ] Use readable font size and C# syntax highlighting.
- [ ] Do not crop off important code lines.
- [ ] Save screenshots in order, for example `01-write-file.png`, `02-append-file.png`, etc.
- [ ] Store the images in a folder named `screenshots`.

## Setup Notes
These are separate teaching examples, not one complete program to paste together. Create the required Windows Forms controls in Visual Studio and use the exact control names shown. For file examples, include `using System.IO;`. For event-handler examples, connect the handler to the appropriate control event in the Designer.
