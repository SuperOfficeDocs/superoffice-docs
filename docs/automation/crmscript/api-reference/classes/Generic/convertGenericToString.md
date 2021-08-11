---
uid: crmscript_ref_Generic_convertGenericToString_Generic_generic
title: Generic.convertGenericToString(Generic generic)
intellisense: Generic.convertGenericToString
langref: 1
sortOrder: 120
keywords: convertGenericToString(Generic)
so.topic: reference
---

# Generic.convertGenericToString(Generic generic)

Return the string representation of any variable (will automatically be up-casted to a generic). Not all types have implemented support for this, and might return "[complex]". All the basic types (String, Integer, Float, and so on) will return a correct string representation of their value.

```crmscript
Void printDebugGeneric2(Generic g){
  printLine("Debug " + convertGenericToString(g));
}
```

* **generic:** Generic variable to get string representation for
* **Returns:** String The string representation of the value in the generic
