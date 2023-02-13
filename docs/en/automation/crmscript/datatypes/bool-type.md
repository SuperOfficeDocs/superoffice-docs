---
uid: crmscript_datatypes_bool
title: Bool data type
author: Bergfrid Dias
so.date: 01.14.2022
keywords:
so.topic: concept
---

# Bool data type

The logical or boolean data type of CRMScript is **Bool**.

Variables of this type can only have 2 values: **true** or **false** and are commonly used in comparisons and conditional statements.

Aside from testing the value, you can't do much except to convert it to a number or a string.

[!include[Note about arrays](includes/note-arrays.md)]

## Constructors

### Bool Bool(Bool value)

Pass a `Bool` to copy into a new object.

```crmscript!
Bool isWellFormed = true;
Bool isValid = Bool(isWellFormed);
Bool isCertified = Bool(false);
printLine("Valid: " + isValid.toString() + "\t Certified: " + isCertified.toString());
```

## Integer toInteger()

Will return an integer representation of the boolean value.

False equals 0 and true equals 1.

```crmscript!
Bool b = true;
printLine(b.toInteger().toString());
```

In this example, we 1st call `toInteger()` to convert the Bool to an Integer, and then we call `toString()` *on the Integer* to get a printable string. Notice the difference between this and the next example.

## String toString()

`toString()` is one of the most frequently used methods, typically when you are going to output something. It returns a string representation of a Bool.

```crmscript!
Bool b = true;
printLine(b.toString());
```
