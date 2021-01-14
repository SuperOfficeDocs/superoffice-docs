---
title: crmscript_fundamentals_operators
description: Operators
author:
so.date:
keywords:
so.topic:
---

# Operators

## CRMScript assignment operators

The assignment operators store a value in a variable (on the left side of the operator).

The standard assignment operator is `=`.
Also, CRMScript has operators that combine an arithmetic operation with the assignment for a more compact notation.

| Operator | Description         | Same as   |
|:--------:|---------------------|-----------|
| +=       | add and assign      | x = x + 2 |
| -=       | subtract and assign | x = x - 2 |

## CRMScript arithmetic operators

The arithmetic operators do math with numbers, either Integer or Float.

| Operator | Description |
|:--------:|-------------|
| +        | add         |
| -        | subtract    |
| *        | multiply    |
| /        | divide      |
| %        | reminder    |
| ++       | increment   |
| --       | decrement   |

## CRMScript string operators

The `+` operator concatenates 2 strings.

```crmscript
String text1 = "Super";
String text2 = "Office";
String fullText = text1 + text2;
```

The result of fullText will be *SuperOffice*.

The `+=` operator appends the right-side string to the left-side variable.

```crmscript
fullText += " AS";
```

This will change our existing string to *SuperOffice AS*.

## CRMScript comparison operators

Comparison operators are used to test for true or false. They are typically used in conditional statements: you compare 2 values and the result determines what happens next.

| Operator | Description           |
|:--------:|-----------------------|
| ==       | equal                 |
| !=       | not equal             |
| <        | less than             |
| >        | greater than          |
| <=       | less than or equal    |
| >=       | greater than or equal |

## CRMScript logical operators

The logical operators are commonly used with boolean values and variables (Bool).

| Operator | Description | Use            |
|:--------:|-------------|----------------|
| &&       | logical AND | expr1 && expr2 |
| \|       | logical OR  | expr1 \| expr2 |
| !        | logical NOT | !expr          |

## Operator precedence

CRMScript operators follow the same precedence as in mathematics. For example, multiplication is done before addition.

Operators at the same precedence level are evaluated left-to-right. If you want to group expressions, use parentheses to specify the resolution.

```crmscript
Integer x = 5 + 2 * 3;
Integer y = ( 5 + 2 ) * 3;
```

In this example, x is 11 while y is 21. The only difference between the assignment statements being the parentheses.
