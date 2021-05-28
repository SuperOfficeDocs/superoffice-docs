---
uid: crmscript_global_integer
title: Integer
description: CRMScript Integer constructor
intellisense: Void.Integer
langref: 1
keywords: Integer(Integer), Integer(String value)
so.topic: reference
---

# Integer Integer()

Integer constructor. You can pass either an `Integer` object to copy or a `String` to be parsed.

Returns an `Integer` object.

## Integer Integer(Integer value)

`Integer` object to copy.

## Integer Integer(String value)

Parse `String` and create `Integer` object.

## Examples

```crmscript!
Integer i = 42;
Integer j = Integer(i);
Integer k = Integer(256);
printLine(j.toString() + ", " + k.toString());
```

```crmscript!
String s = "1729";
Integer ramanujan = Integer(s);
Integer favOfSheldon = Integer("73");
printLine("Ramanujan's number: " + ramanujan.toString());
printLine("Sheldon Cooper's favorite number: " + favOfSheldon.toString());
```

For more examples, see the [Integer datatype section][1].

<!-- Referenced links -->
[1]: ../../datatypes/integer-type.md
