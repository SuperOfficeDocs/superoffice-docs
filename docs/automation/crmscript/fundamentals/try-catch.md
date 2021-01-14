---
title: Control - try...catch 
uid: crmscript_fundamentals_try_catch
sortOrder: 100
---

CRMScript has a set of special statements to handle error-situations in your own scripts and react accordingly. This gives you the opportunity to recover, or fail gracefully instead of crashing.

## Try statement

The `try` statement contains the code you want to run but acknowledge might fail at some point.

The definition has 2 parts:

* keyword **try**
* 1 or more statements, enclosed in curly brackets - {} must always be used

```crmscript
try {
  myFunction();
}
```

## Catch statement

The `catch` statement contains the code to run if an exception is thrown from the `try` block.

The definition has 2 parts:

* keyword **catch**
* 1 or more statements, enclosed in curly brackets - {} must always be used

```crmscript
catch {
  printLine(error);
}
```

## Built-in exceptions

The built-in classes and functions of CRMScript may throw exceptions, which you can catch.
Inside the `catch` block, you can use the following implicit String variables:

* **error** - a status code or description of the error
* **errorLocation** - the location where the exception was thrown

```crmscript!
try {
  Integer i = 123;
  Integer j = 0;
  Integer k = i/j;
}
catch {
  printLine("Exception caught: " + error);
  printLine("...at " + errorLocation);
}
```

## Custom exceptions

You can also throw you own exceptions from the `try` block.

The `throw` statement has 2 parts:

* keyword **throw**
* a string (in quotes) followed by a semicolon

Preferably place the `throw` statement inside a `try` block. If you throw an exception outside `try`, it will eventually be caught by us and shown as if the script failed.

```crmscript!
try {
  throw "This is my own error";
}
catch {
  printLine(error);
}
```

This will print **GeneralException:** followed by the text string you threw.
