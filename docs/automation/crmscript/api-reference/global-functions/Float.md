---
uid: crmscript_global_float
title: Float
description: CRMScript Float constructor
intellisense: Void.Float
langref: 1
keywords: Float(Float), Float(String), Float(Integer)
so.topic: reference
---

# Float Float()

Float constructor. You can pass either a `Float` object to copy, a `String` to be parsed, or an `Integer` value to be converted.

Returns a `Float` object.

## Float Float(Float value)

`Float` value to copy.

## Float Float(String number)

Parse `String` and create a `Float` object.

## Float Float(Integer value)

`Integer` value that will be converted to a `Float`.

## Examples

```crmscript!
Float m = 3.14;
Float pi = Float(m);
Float e = Float(2.71);
printLine(pi.toString(2) + ", " + e.toString(2));
```

```crmscript!
Integer n = 10;
Float discount = Float(n);
Float vat = Float(25);
printLine(discount.toString(1) + ", " + vat.toString(2));
```

```crmscript!
String o = "1.618";
Float phi = Float(o);
Float twoSquared = Float("1.4142");
printLine(phi.toString(1) + ", " + twoSquared.toString(2));
```

For more examples, see the [Float datatype section][1].

<!-- Referenced links -->
[1]: ../../datatypes/float-type.md
