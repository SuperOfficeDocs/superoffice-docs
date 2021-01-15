---
title: String convertGenericToString(Generic generic)
path: /EJScript/Classes/Generic/Member functions/String convertGenericToString(Generic generic)
intellisense: 1
langref: 1
sortOrder: 120
keywords: convertGenericToString(Generic)
---

Return the string representation of any variable (will automatically be up-casted to a generic). Not all types have implemented support for this, and might return "[complex]". All the basic types (String, Integer, Float, and so on) will return a correct string representation of their value.

```crmscript
Void printDebugGeneric2(Generic g){
  printLine("Debug " + convertGenericToString(g));
}
```

* **generic:** Generic variable to get string representation for
* **Returns:** String The string representation of the value in the generic
