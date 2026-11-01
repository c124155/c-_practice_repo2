# Week 5 – Remaining Topics (C#)

This week combines the remaining topics from **Chapter 4: Loops, Files, and Random Numbers** with the **Making Decisions** chapter.

# Part A – Files, Dialogs, Random Numbers, and Load Event

## 1. Using Files for Data Storage
A program uses files to save information so it can be used later. The three general steps are:
1. **Open** – connect the program to a file.
2. **Process** – read data from or write data to the file.
3. **Close** – close the connection to the file.

### Types of Files
- **Text file:** stores data as encoded text and can be viewed with a text editor.
- **Binary file:** stores data in binary form and is not normally readable in a text editor.
- This chapter's examples focus on text files.

## 2. File Classes
- `StreamWriter` writes data to a text file.
- `StreamReader` reads data from a text file.
- Use `using System.IO;` to access file classes and methods.

## 3. Writing Data to a File
- Create a `StreamWriter` object.
- Open or create the file with `File.CreateText` or `File.AppendText`.
- Use `Write` or `WriteLine` to write information.
- Close the file (or use a `using` block).

```csharp
using (StreamWriter outputFile = File.CreateText("courses.txt"))
{
    outputFile.WriteLine("Computer Science");
    outputFile.WriteLine("English");
}
```

- `WriteLine` writes data and moves to a new line.
- `Write` writes data without adding a new line.
- `CreateText` creates a file; if it already exists, its previous contents are replaced.
- `AppendText` adds data to the end of an existing file.

## 4. Reading Data from a File
- Use `StreamReader` to read text.
- `File.OpenText` opens a text file for reading.
- `ReadLine` reads one line and returns it as a string.
- `Read` reads a character or characters.
- `ReadToEnd` reads the remaining content.
- `EndOfStream` indicates whether the end of the file has been reached.

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

## 5. OpenFileDialog and SaveFileDialog
- `OpenFileDialog` displays a standard Windows dialog for choosing a file to open.
- `SaveFileDialog` displays a standard Windows dialog for choosing where to save a file.
- These are invisible components in the form and appear in the Visual Studio component tray.
- `ShowDialog()` displays the dialog.
- `DialogResult.OK` means the user confirmed the selection.
- `DialogResult.Cancel` means the user cancelled.
- `FileName` provides the selected file path.
- `InitialDirectory` sets the folder shown first.

```csharp
if (openFileDialog1.ShowDialog() == DialogResult.OK)
{
    string selectedPath = openFileDialog1.FileName;
}
```

## 6. Random Numbers
- The `Random` class generates pseudo-random values.
- Create a generator with `Random rand = new Random();`.
- `Next()` returns a non-negative random integer.
- `Next(max)` returns an integer from zero up to, but not including, `max`.
- `Next(min, max)` returns an integer from `min` up to, but not including, `max`.
- `NextDouble()` returns a double from 0.0 up to, but not including, 1.0.

```csharp
Random rand = new Random();
int number = rand.Next(1, 7); // 1 through 6
double value = rand.NextDouble();
```

## 7. The Load Event
- The form's `Load` event occurs when the form is loaded.
- Code inside the Load event handler runs as the form is starting.
- In Visual Studio, double-clicking the form in the Designer can create its Load event handler.

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Welcome!");
}
```

# Part B – Making Decisions

## 8. Control Structures
- A **sequence structure** executes statements in the order they appear.
- A **decision structure** selects which statements execute based on a condition.
- A decision structure is also called a selection structure.
- A Boolean expression evaluates to `true` or `false`.

## 9. Relational Operators

| Operator | Meaning |
|---|---|
| `>` | Greater than |
| `<` | Less than |
| `>=` | Greater than or equal to |
| `<=` | Less than or equal to |
| `==` | Equal to |
| `!=` | Not equal to |

Remember: `=` assigns a value; `==` compares values.

## 10. `if` and `if-else`
- `if` executes its block only when its condition is true.
- `if-else` chooses between two blocks.
- Only one of the two `if-else` blocks executes.

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

## 11. Nested `if` and `if-else-if`
- **Nested if** means placing one decision inside another.
- `if-else-if` tests multiple conditions in order.
- The first true condition's block executes; the final `else` is optional.

```csharp
if (score >= 90)
{
    grade = "A";
}
else if (score >= 80)
{
    grade = "B";
}
else
{
    grade = "Needs improvement";
}
```

## 12. Logical Operators

| Operator | Name | Meaning |
|---|---|---|
| `&&` | AND | Both conditions must be true |
| `||` | OR | At least one condition must be true |
| `!` | NOT | Reverses a Boolean value |

## 13. `bool` Variables and Flags
- A `bool` variable stores `true` or `false`.
- A **flag** signals whether a condition exists.
- `true` means the condition exists; `false` means it does not.

## 14. Comparing Strings
- `==` compares two strings for equality.
- `!=` checks that two strings are not equal.
- `String.Compare(a, b) == 0` indicates that the strings compare as equal.

## 15. `TryParse` and Input Validation
- `int.TryParse`, `double.TryParse`, and `decimal.TryParse` check whether text can be converted to a number.
- The general pattern is `DataType.TryParse(text, out variable)`.
- `TryParse` checks format/conversion, not whether the value is sensible.
- **Input validation** checks whether the entered value is acceptable for the program.
- Example: hours worked in one week should be greater than 0 and no more than 168.

## 16. Radio Buttons and Check Boxes
- A **RadioButton** lets the user choose one option in a group (mutually exclusive).
- A **CheckBox** lets the user select multiple independent options.
- `Text` stores the displayed label.
- `Checked` indicates whether the control is selected.
- `CheckedChanged` occurs when the `Checked` property changes.

## 17. `switch` Statement
- `switch` is a multiple-alternative decision structure.
- It compares an expression with `case` values.
- `break` exits a case.
- `default` is optional and runs if no case matches.

## 18. ListBox
A `ListBox` displays a list of items and allows the user to select an item.

Important properties and methods:
- `Items` – collection of list items.
- `Items.Add()` – adds an item.
- `Items.Count` – number of items.
- `SelectedItem` – selected item.
- `SelectedIndex` – zero-based index of selected item.
- `SelectedIndex == -1` means no item is selected.
- `Items.Remove(value)` removes a matching item.
- `Items.RemoveAt(index)` removes an item at an index.
- `Items.Clear()` removes all items.

## Quick Revision
- `StreamWriter` writes; `StreamReader` reads.
- `WriteLine` adds a newline; `Write` does not.
- `CreateText` replaces an existing file; `AppendText` adds to it.
- `EndOfStream` helps read until the end of a file.
- `OpenFileDialog` selects a file; `SaveFileDialog` selects a save location.
- `Random.Next` generates integers; `NextDouble` generates a decimal value from 0 to less than 1.
- `Load` runs when a form is loaded.
- `if`, `if-else`, nested `if`, and `switch` make decisions.
- `TryParse` checks conversion; validation checks acceptable ranges.
- RadioButton = one choice; CheckBox = multiple choices.
- ListBox displays selectable items.
