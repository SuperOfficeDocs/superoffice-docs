---
uid: crmscript_global_map
title: Map
description: CRMScript Map constructor
intellisense: Void.Map
langref: 1
keywords: Map(), Map(String)
so.topic: reference
---

# Map Map()

Map constructor. Called with no parameters, it creates an empty Map. You can optionally pass a `String` of key-value pairs to be parsed and inserted into the new Map.

Returns a `Map` object.

## Functions

* Map Map()
* Map Map(String text)

## Parameters

The optional string must be formatted as [key] = [value] and pairs must be separated with `\n`:

"key=value\nkey=value\nkey=value,..."

For example:

```crmscript
String t = 'Foo = bar\nhelpFile = c:\winnt\help.hlp\nsomeStirng = This is a test: 2 + 2 = 4';

Map m = Map(t);
```

or

```crmscript
String t;
t += "Foo = bar\n";
t += "helpFile = c:\winnt\help.hlp\n";
t += "someStirng = This is a test: 2 + 2 = 4";

Map m = Map(t);
```

The constructor also supports multiple-line values. For example:

```crmscript
String t = 
"1=first
2=second
3=third";

Map m = Map(t);
```
