---
title: Write output
uid: crmscript_fundamentals_write_output
sortOrder: 140
---

CRMScript can display data in different ways:

## Print a string to the screen (standard output)

* print()
* printLine()

The difference between these functions is that with `print()` you must add lineending `\n` where applicable yourself.

```crmscript!
print("To boldly go\n");
print("where" + " no one");
printLine(" has gone before");
print("\n\tJean-Luc Picard\n");
```

## Log

* log() will write the message to the log in the database.
* logMessage() will write the message to the log file.

## Debug

* printDebug() will add the input to the debug string, which will be shown in the Debug window.

You will learn more about debugging and logs later.
