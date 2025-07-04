---
uid: crmscript_fundamentals_datatypes_intro
title: Introduction to data types
author:
date:
keywords:
content_type: concept
---

# Introduction to data types

A data type tells the computer what something **is** so that it can be processed properly.
CRMScript has 4 primitive data types and a huge range of complex types defined by the built-in classes.

Data types apply to:

* literal values
* variables
* parameters in functions
* return type of functions
* objects of built-in classes

CRMScript is **statically typed**, meaning you *must* set the type in the declaration, and it can't be changed later.

## Numbers

CRMScript has 2 types of numbers:

* Integer (without decimals)
* Float (with decimals)

You can use the[arithmetic operators][1] to do basic math.

```crmscript
Integer a = 5;
Integer b = 7;
Integer sum = a + b;
```

## Strings

A text string is a sequence of characters written with quotes.

You can use the [concatenation operator][1] to join multiple strings.

```crmscript
String myCompany = "Super" + "Office";
```

## Logical

The logical or boolean data type of CRMScript is **Bool**. Variables of this type can only have 2 values: **true** or **false** and are commonly used in comparisons and conditional statements.

<!-- Referenced links -->
[1]: operators.md
