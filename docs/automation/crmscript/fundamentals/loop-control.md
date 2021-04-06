---
uid: crmscript_fundamentals_loops_break_continue
title: Loops - break and continue
author:
so.date:
keywords:
so.topic:
---

# Loops - break and continue

CRMScript has several statements that can alter the flow of `for` and `while` loops. This comes in addition to the loop conditions.

## Break statement

The `break` statement is a **loop control** mechanism that terminates the loop and jumps out of it to the 1st statement (if any) *after* the loop.

The definition is simply the keyword **break** followed by a semicolon.

```crmscript!
Integer i = 1;
while(i < 10) {
  if(i == 5) {
    break;
  }
  printLine(i.toString());
  i++;
}
```

Based on the loop condition, this loop would print the numbers 1-9 in ascending order. However, due to the `break` statement, when `i` equals 5 we hit full stop. Thus the loop will print only numbers 1-4.

## Continue statement

The `continue`statement is a **loop control** mechanism that skips the remainder of the statements in the code block and fast-forwards to the next iteration of the loop. It goes directly to the next evaluation of the condition.

The definition is simply the keyword **continue** followed by a semicolon.

```crmscript!
for(Integer i = 1; i < 10; i++) {
  if(i == 3) {
    continue;
  }
  printLine(i.toString());
}
```

Based on the loop condition, this loop would print the numbers 1-9 in ascending order. However, due to the `continue` statement, when `i` equals 3 we short-circuit the loop and go directly to `i++`. Thus the loop will print all numbers 1-9 **except** 3.

> [!WARN]
> As always, it is crucial that you **update the counter** of `while` loops. Pay attention to where you place your update in relation to the `continue` statement!
