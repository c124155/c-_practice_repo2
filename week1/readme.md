## Chapter 1: Introduction to Visual C# — Key Concepts


> This chapter introduces object-based programming concepts and the Visual Studio environment, then explains the fundamentals of building a Windows Forms graphical user interface (GUI), writing event-driven C# code, displaying output, and handling common development issues.

# Objects, Classes, Properties, and Methods

• Object: A program component that contains data and performs
operations to accomplish tasks.
• Property: Data or a setting associated with an object.
Properties affect what an object contains, looks like, or how it behaves.
• Method: An operation an object can perform.
• Class: Code that describes a type of object. A class defines the structure and behavior of objects.
• Control: An object visible in a GUI, such as a Label, Button, or TextBox. Some GUI objects, such as timers and OpenFileDialog, are not visible at run time.
• .NET: A collection of classes and other code used to create
Windows applications. C# is a language supported by .NET, and .NET provides specialized classes for controls.

# Visual Studio and Its Main Windows

Visual Studio is an integrated development environment (IDE) used to create applications. Important parts include: - Designer Window:
Used to visually create and arrange a form and its controls. -
Solution Explorer: Displays a project and its files in an expandable
structure. - Properties Window: Displays the properties of the
selected form or control. Property names appear in one column and their values in another. - Toolbox: Contains controls that can be added to a form. Common controls include Button, CheckBox, ComboBox, Label, ListBox, and TextBox. - Code Editor: Used to write and edit source
code. - Menu Bar and Standard Toolbar: Provide menus and shortcuts for common commands. - Tooltip: A small help box that appears when the pointer rests over an item. - Docked window: Attached to an edge of the Visual Studio environment. - Floating window: Can be moved around the screen. A window in Auto Hide mode cannot float.

# Projects and Solutions

• A project represents an application and contains its files, such as Form1.cs and Program.cs.
• A solution is a container that can hold one or more projects.
• Project files contain the code and resources needed by the
application.
• If a form does not appear in the Designer, it can be opened from Solution Explorer using View Designer.

# Forms, Controls, and Properties

• A Windows Forms application starts with a form, commonly named Form1.
• A form is the window that holds controls.
• The form’s bounding box and sizing handles are used to resize it in the Designer.
• Controls can be added from the Toolbox by double-clicking or
dragging them onto the form. They can then be moved, resized,
configured, or deleted.
• The Properties window changes the appearance and behavior of a selected object. The Text property controls displayed text,
including the form’s title-bar text.
• The Properties window can show properties alphabetically or by category.

# Naming Controls

Control names are identifiers used to refer to controls in code Names: - Must begin with a letter or underscore. - May contain letters, digits, and underscores after the first character. - Cannot contain
spaces. - Common C# practice uses camelCase for control names: start with a lowercase word, then capitalize the first letter of each following word.

## C# Source-Code Organization

C# code is commonly organized into: - Namespace: A container that
holds classes. - Class: A container that holds methods. -
Method: One or more statements that perform an operation. -
Source-code file: A file containing program code.

In a Windows Forms project: - Program.cs contains application startup
code. - Form1.cs contains code associated with the form. - The form
constructor initializes the form’s components.

# Event-Driven Programming

GUI applications are event-driven: they wait for an event, such as a button click or key press, and then respond. - An event is an action or occurrence recognized by the application. - An event handler is a
method that runs when a particular event occurs. - Double-clicking a control in the Designer can create a default event handler for it.

# Labels and Displaying Output

A Label displays text on a form. It can show fixed text or program
output. Common properties include: - Text: Gets or sets the
displayed text. - Name: Identifies the Label. - Font: Sets font
family, style, and size. - BorderStyle: Controls whether a border is
shown. - AutoSize: Controls automatic sizing. - TextAlign: Sets
text alignment. Supported positions include top, middle, or bottom
combined with left, center, or right. The Label’s Text property accepts
a string. Assigning an empty string clears its displayed text.

# Message Boxes

A message box (dialog box) displays a message to the user. The .NET
MessageBox.Show method displays the message in a separate window and
can be called from an event handler.

# IntelliSense

IntelliSense is Visual Studio’s code-completion feature. As code is
typed, it suggests relevant keywords, variables, methods, classes, and
properties, helping developers find and insert language elements.

# PictureBox Controls

A PictureBox displays a graphic image on a form. Common properties
include: - Image: Specifies the image to display. - SizeMode:
Determines how the image is displayed within the control. - Visible:
Determines whether the control is visible at run time. A PictureBox can
respond to a Click event through an event handler.

# Statement Order, Comments, and Readability

• Statements execute in the order they appear in a method. Incorrect
ordering can cause logic errors.
• Comments explain code and are ignored as executable
instructions. A line comment occupies one line; a block comment can
span multiple lines.
• Blank lines and indentation make source code easier to read and
maintain.

# Closing a Form or Application

The chapter distinguishes closing the current form from exiting the
application: - Closing a form affects the current form. - Exiting the
application closes the application as a whole.

# Syntax Errors

Visual Studio checks statements as code is entered and marks detected
syntax errors with a jagged underline. Syntax errors can prevent a
program from compiling and running.

# Key Takeaways

• GUI applications are built from forms and controls.
• Properties configure objects; methods perform operations.
• Event handlers connect user actions to program behavior.
• Clear names, comments, blank lines, and indentation improve
readability.
• Correct statement order matters, and syntax errors must be fixed
before successful compilation.