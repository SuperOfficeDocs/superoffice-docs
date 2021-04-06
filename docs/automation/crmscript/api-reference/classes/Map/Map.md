---
uid: crmscript_ref_Map
title: Map
intellisense: Void.Map
sortOrder: 522
so.topic: reference
---


The Map class represents a collection of key-value pairs. Both key and value are strings.

The Map class supports two constructors. The default constructor accepts no parameters, and initializes a Map with an empty key-value pair collection. The other constructor that accepts a String. The String parameter must be one or more lines of key-value pairs, delimited by a Line Feed (LF) character (\n).

Don't add a space between \n and the 1st character of the key!

## Example code

```crmscript
Map m = Map("foo = bar\n2+2 = 4\ntestNumber = 3");

m.insert("test", "someValue");
m.remove("testNumber");
printLine(m.exists("testNumber").toString());

m.first();
while (!m.eof()){
  printLine(m.getKey() + " = " + m.getVal());
  m.next();
}
```

1. autolist
