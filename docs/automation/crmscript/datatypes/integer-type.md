---
uid: crmscript_datatypes_int
title: Integer data type
author:
so.date:
keywords:
so.topic:
---

# Integer data type

Integers are positive and negative whole numbers without decimals. If you need to work with decimals, use the Float data type.

```crmscript
Integer i = 42;
Float f = 3.14;
```

## Constructors

### Integer Integer(Integer value)

Pass an `Integer` to copy into a new object.

```crmscript!
Integer i = 42;
Integer j = Integer(i);
Integer k = Integer(256);
printLine(j.toString() + ", " + k.toString());
```

### Integer Integer(String value)

Pass a `String` containing a number. The constructor will parse the text and create an `Integer` object.

```crmscript!
String s = "1729";
Integer ramanujan = Integer(s);
Integer favOfSheldon = Integer("73");
printLine("Ramanujan's number: " + ramanujan.toString());
printLine("Sheldon Cooper's favorite number: " + favOfSheldon.toString());
```

## Numeric strings

Strings can have numeric content, but are always written in quotes.

```crmscript
Integer c = 100;
String s= "100";
```

Because CRMScript is statically typed, you can't use arithmetic operators on strings. With Integers, the `+` operator will add the numbers. With Strings, the same operator will concatenate.

```crmscript!
Integer c1 = 100;
Integer c2 = 100;
Integer c = c1 + c2;

String s1 = "100";
String s2 = "100";
String s = s1 + s2;

printLine(c.toString());
printLine(s);
```

The 1st output will be the sum of the numbers, 200 in this case.
The next output will be the concatenated string, "100100" here.

You can't add an Integer and a String together. We need to change the type of one of them 1st.

### String toString()

`toString()` is one of the most frequently used methods, typically when you are going to output something. It returns a string representation of an Integer.

```crmscript
Integer c = 100;
String s = c.toString();
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

## Math functions

### Integer abs()

`abs()`  will return the absolute value of an Integer. That is, the non-negative value of the number without regarding the sign.

```crmscript!
Integer i = -7;
print(i.abs().toString());
```

This example will print 7, without the sign.

## Hexadecimal

It is sometimes necessary to convert an Integer to a hexadecimal string. You can choose between dot notation and input parameter.

### String toHex()

```crmscript!
printLine("Int \t Hex");
for (Integer i = 0; i < 16; i++) {
  printLine(i.toString() +"\t " + i.toHex());
}
```

This example will print a mapping of numbers and their hexadecimal value.

### String toHex(Integer p0)

Same as above except you write `toHex(i)` rather than `i.toHex()`.

## Bool

In conditional statements, you need something that evaluates to **true** or **false**. For example in C, it is common to treat 0 as false and everything else as true.

In CRMScript, you can't use numbers directly. In the following example, the 1st test is OK, but the 2nd test will produce an error.

```crmscript
if (true)
  print("true");
```

```crmscript
if (1)
  print("true");
```

### Bool toBool()

`toBool()` will return **false** if the Integer is zero, otherwise **true**.

```crmscript!
Integer i = 3;
printLine(i.toBool().toString());
i = 0;
printLine(i.toBool().toString());
```

The 1st output will be `true` because we have a non-zero value.
The next output will be `false` because `i` now has the value 0.

## Zero vs. no value

Before an Integer is initialized, it has no value. This is commonly written as NULL, NUL, or NIL.

Null is different from zero, which is actually a numeric value. You can subtract any number from itself and get zero as a result. Null is also not the same as NaN (not a number).

CRMScript is usually forgiving and interprets null as zero.
However, it is a good habit to always test that you have a value before using it.

### Bool isNull()

`isNull()` will return **true** if it has no value and **false** if it does.

```crmscript!
Integer i;
printLine(i.isNull().toString());
i = 0;
printLine(i.isNull().toString());
```

The 1st output will be `true` because we haven't initialized `ì` yet.
The next output will be `false` because `i` now has the value 0.
