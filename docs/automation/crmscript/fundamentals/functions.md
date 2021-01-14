---
title: crmscript_fundamentals_functions
description: Functions
author:
so.date:
keywords:
so.topic:
---

# Functions

## What is a function

A **function** is a code block designed to do a specific task. For example, to calculate a value or to update a variable.

In your CRMScript, a function is **a named, reusable sub-routine**. The key here is *reuse*: you significantly improve the readability and maintainability of your CRMScripts with reusable code blocks.

You have probably already seen some of the built-in functions, such as print() and toString(). Here we explain how to write and use your own functions.

## Declaration

The definition has 4 parts:

* the (return) type of the function
* the name of the function
* 0 or more input parameters separated by commas and enclosed in parentheses
* 1 or more statements enclosed in curly brackets

Note that there is not a specific keyword in the definition!

```crmscript
Void sayHello(){
  print("Hello!");
}
```

The type, name, and parameter list together make up the **signature** of the function. Here, the signature is `Void sayHello()`.

The statements in the function's **body** {} are run when you call the function. Here, we have only 1 statement, `print("Hello!");`. More on calling (invocation) shortly.

> [!NOTE]
> In CRMScript, functions *must* be declared with a specific type (for example Integer, Bool, Float, String, or Generic). They must also be declared *before* they are used. If you refer to a function that is declared later, you will get an error.

### Function names

You can label functions *almost* anything you want (same rules as variables).

* Lower-case and upper-case letters a-z, numbers, and underscore.
* Names must be unique within their scope.
* Names can't be any of the reserved words.

## Invocation

**Invocation** is a programming language term for calling a function. It is a request to run the statements inside the function. These statements are run when and only when you call the function. If you never call it, that code is never run.

To get output from our `sayHello()` function, we must call it:

```crmscript!
Void sayHello(){
  print("Hello!");
}
sayHello();
```

Don't forget the semicolon after the function's name and parenthesis!

### Call chaining

Call chaining makes it possible to call functions inside other functions.

```crmscript!
Void sayHello(){
  printLine("Hello!");
}
Void sayGoodbye(){
  printLine("Good bye!");
}
Void chat(){
  sayHello();
  sayGoodbye();
}
chat();
```

In this example, we declare 3 functions. Then we call `chat()`, which then calls `sayHello()`, which again calls `printLine()`, and so on.

## Parameters

The behavior of the function can be changed by input parameters. To use parameters:

1. List the parameters with type and name inside the parentheses when you declare the function.

2. Supply variables or literal values as arguments when you call the function. The type, number, and order of arguments must match the signature.

3. Use the received input parameters as local variables inside your function.

To make our say- functions more generic, we could introduce a parameter:

```crmscript!
Void sayTheWord(String word){
  printLine(word);
}
sayTheWord("Hello!");
sayTheWord("Good bye!");
```

Note that we are using the input parameter of `sayTheWord()` as a local variable and passing it as an argument to `printLine()`.

## Return

Just like you can stop and jump out of for and while loops with a [break statement][1], you can stop and jump out of a function with a **return** statement. The control goes to the 1st statement after the function call.

```crmscript!
Void sayHello(){
  print("Hello!\n");
  return;
  print("I am ignored!\n");
}
sayHello();
print("You came back to me!\n");
```

### Return value

Many functions calculate a value. And rather than simply printing that value inside the function, you can transfer it back to be used in the calling code. To use a return value:

1. State the type of the return value when you declare the function. (Replaces `Void` in the previous examples.)

2. Supply a variable or literal of that type to the return statement.

3. Use the returned value in the calling code.

```crmscript!
Integer square( Integer number ) {
  return number * number;
}

Integer myNumber = 5;
print("The square of " +myNumber.toString()+ " is " + square(myNumber).toString() +".\n");
```

### Function types

The basic built-in data types are:

* Bool
* Date
* DateTime
* Float
* Integer
* Map
* String

Also, you can return objects of all the built-in classes, for example Company or Generic.

<!-- Referenced links -->
[1]: loop-control.md