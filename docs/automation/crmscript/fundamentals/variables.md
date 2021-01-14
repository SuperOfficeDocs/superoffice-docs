---
title: crmscript_fundamentals_variables
description: Variables
author:
so.date:
keywords:
so.topic:
---

# Variables

A variable is a box for storing data values. The label you put on that box represents the variable **name** and **type**. It identifies what is or can be put in there.

## Declaration

You start by **declaring** a variable with its type followed by you chosen name and a semicolon.

```crmscript
Integer shoeSize;
```

In CRMScript, variables *must* be declared with a specific type (for example Integer, Bool, Float, String, or DateTime). They must also be declared *before* they are used. If you refer to a variable that is declared later, you will get an error.

## Assignment

After declaring the variable, you can give - or **assign** - a value to it.

```crmscript
shoeSize = 39;
```

The 1st time you assign a value to a specific variable is also called the **initialization**.

If you prefer, you can combine declaration and initialization into a single statement.

```crmscript
Integer shoeSize = 39;
```

## Use

To **retrieve** the value, you simply refer to the variable name.

To **change** (update) the value, you use another assign statement.

```crmscript
shoeSize = 42;
```

## Variable names

You can label variables *almost* anything you want.

* Lower-case and upper-case letters a-z, numbers, and underscore.
* Names must be unique within their scope.
* Names can't be any of the reserved words.

## Variable types

The basic built-in data types are:

* Bool
* Float
* Generic
* Integer
* String

Also, you can create objects of all the built-in classes, for example DateTime or Company.

## Scope

Scope determines where you variable is visible and can be used.

Most variables are **local**, meaning that they are available only within the block you declared them in. This lets you reuse variable names in multiple functions and blocks, such as the counter `i` in loops.

Variables declared outside any class, struct, or function are **global**. These are available to any other code in the current script.
