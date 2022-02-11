---
uid: crmscript_fundamentals_loops_while
title: Loops - while
author:
so.date:
keywords:
so.topic:
---

# Loops - while

A `while` loop is a control structure for repeating a block of code as long as the condition given is true.

The definition has 3 parts:

* keyword **while**
* a condition enclosed in parentheses
* 1 or more statements enclosed in curly brackets

This definition is very similar to the [if statement][1]. The key difference is that with `if`, the code block is run 0 or exactly 1 time. With `while`, the code block is run 0 or more times.

```crmscript!
Integer i = 1;

while (i < 10){
  printLine(i.toString());
  i++;
}
```

In this example, the counter `i` must be less than 10. The loop will be repeated a total of 9 times, printing the numbers 1 through 9 in ascending order.

## Condition

The **condition** determines if the code inside the block will be run or not. It is tested at the beginning of each pass through the loop. If it evaluates to **true**, the enclosed statements are run. If it evaluates to **false**, the loop will terminate and we go to the 1st statement *after* the loop.

You can use both [conditional and logical operators][2] and also statements that evaluate to true or false.

> [!WARNING]
> It is crucial that you **update the counter!** If not, your loop will run forever (or until it crashes the browser).

## Usage

You should use a `while` loop when you don't know the number of iterations ahead of time.

It is also very useful when the counter updates don't follow a fixed pattern such as `++`. For example, when you receive a group sign-up, the new number of participants must reflect the size of the group.

<!-- Referenced links -->
[1]: ./conditions.md
[2]: ./operators.md
