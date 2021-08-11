---
uid: crmscript_ref_String_isNumber
title: String.isNumber()
intellisense: String.isNumber
keywords: isNumber()
so.topic: reference
---

# String.isNumber()

Method should return true if it is possible to convert string to integer. If string begins with number it is possible to convert until illegal character occurs.

## Example
    //Returns true
    printLine(String("123").isNumber().toString());
    //Returns true, conversion to Integer will return 123
    printLine(String("123nok").isNumber().toString());
    //Returns false
    printLine(String("nok123").isNumber().toString());
    //Returns true, conversion to Integer will return 12
    printLine(String("12nok3").isNumber().toString());

* **Returns:** True if string can be converted to an integer, false otherwise.

