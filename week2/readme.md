# Chapter 2 Processing Data

# Topics
-3.1 Reading Input with TextBox Controls.
-3.2 A First Look at Variables.
-3.3 Numeric Data Type and Variables.
-3.4 Performing Calculations.
-3.5 Inputting and Outputting Numeric Values.
-3.6 Formatting Numbers with the ToString Method.
-3.7 Simple Exception Handling.
-3.8 Using Named Constants.
-3.9 Declaring Variables as Fields.
-3.10 Using the Math Class.
-3.11 More G U I Details.
-3.12 Using the Debugger to Locate Logic Errors.

## 3.1 TextBox Controls.
TextBox control : is a rectangular area can accept keyboard input from the user located in the Common Control group of the Toolbox.

### Main Features
-A `TextBox` is a rectangular area.
-It can accept keyboard input from the user.
-It is located in the *Common Controls* group of the Toolhox.
-You can double-click the TextBox in the Toolbox to add it to the form.
-The default control name is usually.

# 3.2 A First Look at Variables
Variable: A variable is a storage location in memory.
*In C# you must declare a variable in a program before using it to store data.
*The syntax to declare variables is:
DataType VariableName;

## Data Types
.A C# variable must be declared with a proper data type.
.The data type specifies the type of data a variable can hold.
.In C# many data types are known as primitive data types.
.In C#, primitive data types are already defined by the language, not created by you.

### Variable Names
*Basic naming conventions are:
-the first character must be a letter (upper or lowercase) or an underscore (_).
-the name cannot contain spaces.
-do not use C# keywords or reserved words.

#### String Variables
*A string is a combination of characters. 
*A variable of the string data type can hold any combination of characters, such as names, phone numbers, and social security numbers.

##### String Concatenation
-Concatenation is the appending of one string to the end of another string.

###### Declaring Variables Before Using Them
You can declare variables and use them later.

# Local Variables and Scope
.A local variable belongs to the method in which it was declared.
Only statements inside that method can access the variable.
-Scope describes the part of a program in which a variable may be accessed.

## Duplicate Variable Names
.You cannot declare two variables with the same name in the same scope. 
.For example, if you declare a variable named productDescription in an event handler, you cannot declare another variable with that name in the same event handler. 

### Assignment Compatibility 
.You can assign a value to a variable only if the value is compatible with the variable’s data type.
.Only strings are compatible with the string data type.

#### Initializing Variables
In C#, a variable must be assigned a value before it can be used. For example, look at this code:
. String fucalti;
 MessageBox.shwo(fucalti); 
-fucalti will be error because is with out value.

##### Declaring Multiple Variables with One Statement
You can declare multiple variables of the same data type with one declaration statement. Here is an example:
string lastName, firstName, middleName; .


# 3.3 Numeric Data Types and Variables
If you need to store a number in a variable and use the number in a mathematical operation, the variable must be of a numeric data type.

## Numeric Literals
A numeric literal is a number that is written into a program’s code.
Examples of variables initialized with numeric literals:
int hoursWorked = 40;
double temperature = 87.6;

### Explicit Conversion with Cast Operators
C# allows you to explicitly convert among types, which is
known as type casting.
You can use the cast operator which is simply the name of the type enclosed in parentheses.

#### Declaring Local Variables with the var Keyword
-var is a keyword you can use instead of writing the full type of a variable.
-You can use the var keyword to declare and initialize a local variable. Example:
var interestRate = 12.0;
var stockCode = "D465U";
var accountBalance = 1000.0m;

# 3.4 Performing Calculations
Basic calculations such as arithmetic calculations can be performed by math operators

## Rules for Performing Calculations
-A math expression performs a calculation and gives a value.
int x = 5, y = 4;
MessageBox.Show((x + y).ToString());
-Be sure to follow the order of operations and group with parentheses if necessary
result = (a + b) / 4;
-In a calculation of mixed data types, the data type of the result is determined by:
.When an operation involves an int and a double, int is treated as double and the result is double
.When an operation involves an int and a decimal, int is treated as decimal and the result is decimal
.An operation involving a double and a decimal is not allowed.

### Integer Division
When you divide an integer by an integer in C# the result is always given as an integer. The result of the following is 2.
*int x = 7, y = 3;
MessageBox.Show((x / y).ToString());

# 3.5 Inputting and Outputting Numeric Values
A TextBox control reads keyboard input, such as 25.65. However, the TextBox treats it as a string, not a number.
If the user has entered a numeric value into a TextBox control and you want to assign that value to a numeric variable, you have to convert the control’s Text property to the desired numeric data type. Unfortunately, you cannot use a cast operator to convert a string to a numeric type. 
.in C# use the following Parse methods to convert string to numeric data.
types:
-int.Parse.
-double.Parse.
-decimal.Parse.

## Displaying Numeric Values
The Text property of a control only accepts string literals
To display a number in a TextBox or Label control requires you to convert a numeric data to string type
.In C# all variables work with the ToString method to convert the value of the variables to strings:
You call the ToString method using the following general format: variableName.ToString()

# 3.6 Formatting Numbers with the ToString Method
*The ToString method can optionally format a number to appear in a specific way.

# 3.7 Simple Exception Handling
An exception is an unexpected error that happens while a program is running ,Exceptions = runtime errors. Example errors:
-Dividing by zero
-Trying to open a file that does not exist
-Invalid user input

What is exception handling? Exception handling is writing special code that catches errors and tells the program what to do instead of crashing.
This code is called an exception handler.
This allows you to write code that responds to exceptions. Such code is known as an exception handler.

## Handling Exceptions with try-catch
The try block is where you place the statements that can cause an exception.
The catch block is where you place statements that respond to the exception when it happens.

### Throwing an Exception
In the following example, if the user enters nonnumeric data into the milesText control, an exception is thrown.

#### What is different Throwing, Catching
Throwing = raising the error (problem occurs).
Catching = handling the error (deciding what to do about it).

##### Displaying an Exception’s Default Message
Every exception (error) in C# is an object.
That object has a property called Message which stores a description of the error.
The Exception object's Message property holds the exception's default error message.
You can use the following format to display the exception’s error message:
try
    {
         statement;
         statement;
         etc.
    }
catch (Exception ex)
    {
     MessageBox.Show(ex.Message);
    }

# 3.8 Using Named Constants
A named constant is a name that represents a value that cannot be changed during the program’s execution.
Writing the name of a constant in uppercase letters is traditional in many programming languages but is not a requirement.


































.