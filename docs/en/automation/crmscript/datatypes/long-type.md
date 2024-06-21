---
uid: crmscript_datatypes_long
title: Long data type
author: kronicz
date: 15.11.2022
keywords:
topic: concept
---

# Long data type

Longs are positive and negative whole 64-bit unsigned numbers without decimals If you need to work with decimals, use the Float data type.
To represent a long number in the code as a literal, suffix it with an &quot;L&quot;, for example, `Long l = 576460752303423488L;`

```crmscript
Long l = 4222222222L;
Float f = 3.14;
```

[!include[Note about arrays](includes/note-arrays.md)]

## Constructors

### Long Long(Long value)

Pass an `Long` to copy into a new object.

```crmscript!
Long l1 = 576460752303423488L;
Long l2 = Long(l1);
Long l3 = Long(9223372036854775807L);
printLine(l2.toString() + ", " + l3.toString());
```

### Long Long(Integer value)

Pass a `Integer` containing a number. The constructor will parse the text and create an `Long` object.

```crmscript!
Integer favOfSheldon = Integer("73");
Long l2 = Long(favOfSheldon);

printLine("Sheldon Cooper's favorite number: " + l2.toString());
```

### String toString()

`toString()` is one of the most frequently used methods, typically when you are going to output something. It returns a string representation of an Long.

```crmscript
Long l1 = 576460752303423488L;
String s = l1.toString();
```

### Integer getHighInteger()

Returns the high 32-bit Integer of the `Long`.

```crmscript
Long l1 = 576460752303423488L;
print(l1.getHighInteger().toString());
```

### Integer getLowInteger()

Returns the low 32-bit Integer of the `Long`.

```crmscript
Long l1 = 576460752303423488L;
print(l1.getLowInteger().toString());
```

## Math operators

| Operator | Description |
|:--------:|-------------|
| +        | add         |
| -        | subtract    |
| *        | multiply    |
| /        | divide      |
| %        | reminder    |
| ++       | increment   |
| --       | decrement   |

## Zero vs. no value

Before an Integer is initialized, it has no value. This is commonly written as NULL, NUL, or NIL.

Null is different from zero, which is actually a numeric value. You can subtract any number from itself and get zero as a result. Null is also not the same as NaN (not a number).

CRMScript is usually forgiving and interprets null as zero.
However, it is a good habit to always test that you have a value before using it.

### Bool isNull()

`isNull()` will return **true** if it has no value and **false** if it does.

```crmscript!
Long l1;
printLine(l1.isNull().toString());
l1 = 0L;
printLine(l1.isNull().toString());
```

The 1st output will be `true` because we haven't initialized `ì` yet.
The next output will be `false` because `i` now has the value 0.
