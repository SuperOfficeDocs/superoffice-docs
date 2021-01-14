---
title: crmscript_fundamentals_if_else
description: Control - if else and else if
author:
so.date:
keywords:
so.topic:
---

# Control - if else and else if

**Conditional statements** are one of the key control structures in CRMScript. They are used do different tasks based on whether the condition evaluates as true or false.

For example, you are taking sign-ups for an event and start a waiting-list when all available seats are taken.

## If statement

The definition has 3 parts:

* keyword **if**
* the condition in parentheses, must be a boolean expression
* 1 or more statements, blocks must be enclosed in curly brackets

```crmscript
Integer signupCount = 13;

if (signupCount <= 50)
  print("Thank you for signing up! Your participant number is " + signupCount.toString() +".\n");
```

You can use both [conditional and logical operators](./operators.md). You can also compare with the special values **true** and **false**.

```crmscript
Bool waitingList = false;

if (waitingList == true)
  print("We are fully booked and have added you to our waiting list.");
```

## If else statement

The definition extends the `if` statement with 2 more parts:

* keyword **else**
* 1 or more alternative statements, blocks must be enclosed in curly brackets

The alternative statements are run if the preceding condition (the if test) evaluates as false.

```crmscript!
Integer signupCount = 72;

if (signupCount <= 50)
  print("Thank you for signing up! ...");
else
  print("We are fully booked ...");
```

## Else if statement

The `else if` statement lets you test multiple conditions in sequence.

* keyword **else if**
* 1 or more alternative statements, blocks must be enclosed in curly brackets

* It *must* be preceded by either an `if` statement or another `else if` statement.
* It *can* optionally be followed by more `else if` statements or a closing `else` statement.

```crmscript!
Integer signupCount = 51;
Bool waitingList = false;

if (signupCount <= 50)
  print("Registration OK!\n");
else if (signupCount == 51) {
  waitingList = true;
  print ("Starting waiting list.\n");
}
else
  print("Adding to waiting list.\n");
```
