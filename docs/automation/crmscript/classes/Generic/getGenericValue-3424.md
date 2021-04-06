---
uid: crmscript_ref_Generic_getGenericValue_String_name
title: Generic.getGenericValue(String name)
intellisense: Generic.getGenericValue
langref: 1
sortOrder: 80
keywords: getGenericValue(String)
so.topic: reference
---


Get a variable from the run-time environment given its name. The variable is returned as a Generic, independent of its type.

If the name is unknown, an exception is thrown.

For example:

```crmscript
Integer age = 42;
Generic g = getGenericValue("age");
```

* **name:** String Name of variable to get
* **Returns:** Generic The generic variable
