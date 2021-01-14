---
title: Loops - for
uid: crmscript_fundamentals_loops_for
sortOrder: 110
---

A `for` loop is a control structure for repeating a block of code a number of times. It will run as long as the condition given is true.

The definition has 5 parts:

* keyword **for**
* 3 special statements separated by semicolon and enclosed in parentheses
  * initialization of the counter variable (optional)
  * condition
  * update (optional)
* 1 or more statements enclosed in curly brackets

```crmscript!
for(Integer i = 1; i < 10; i++) {
  printLine(i.toString());
}
```

The loop will be repeated a total of 9 times, printing the numbers 1 through 9 in ascending order.

## Initialization

The 1st statement in the parenthesis initializes the counter variable for the loop. You can either use an existing variable of type Integer or declare it here. This is only done **once**, before the loop actually starts.

You can optionally use a variable that is declared *and* initialized before the `for` loop. In this case, use an empty statement before the condition:

```crmscript
Integer i = 1;
for (;i < 10; i++) {
  printLine(i.toString());
}
```

## Condition

The 2nd statement is the condition that determines if the code inside the block will be run or not. It is tested at the beginning of each loop cycle. In the previous example, the counter must be less than 10.

You can use [conditional operators](./operators.md) and also statements that evaluate to true or false.

In contrast to the initialization and update, the condition **must** be set.

```crmscript
Integer i = 1;
for (;i < 10;) {
  printLine(i.toString());
  i++;
}
```

## Update

The 3rd and last statement is the update. It is done after any statements inside the block as the last code run before the condition is re-evaluated. Commonly, this statement increments or decrements the counter variable. In the previous example, we add 1 to the counter `i`.

You can optionally update the counter within the loop. In this case, use an empty statement after the condition:

```crmscript
for (Integer i = 1;i < 10;) {
  printLine(i.toString());
  i++;
}
```

## Usage

You should use a `for` loop when you know the number of iterations ahead of time and the counter updates follow a fixed pattern such as `++`.

It is also a more compact and explicit structure, which can be easier and safer for beginners. It is a lot harder to create an infinite loop by accident.

## For versus while

You might have noticed that `for` looks a lot like the [while loop](./while-loops.md). And you are absolutely right! In fact, `for` is a very common use of `while` that formalizes the initialization and update statements. They are both loops and can produce the same result. Whichever you use comes down to personal preference. But keep these factors in mind when choosing:

* Do you know the number of iterations ahead of time?
* Do you update the counter in a fixed pattern?
* How much programming experience do you have?
