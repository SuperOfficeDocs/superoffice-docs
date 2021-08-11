---
uid: crmscript_ref_Generic_getTypeName_Generic_generic
title: Generic.getTypeName(Generic generic)
intellisense: Generic.getTypeName
langref: 1
sortOrder: 140
keywords: getTypeName(Generic)
so.topic: reference
---

# Generic.getTypeName(Generic generic)

Returns the type name of any variable (will automatically be up-casted to generic).

For example:

```crmscript
printLine(getTypeName(getCurrentDateTime()));
```

```crmscript
Void printDebugGeneric(Generic g)
{
  String type = getTypeName(g);
  if(type == "String")
    printLine("Debug " + GenericToString(g));
  else if(type == "Integer")
    printLine("Debug " + GenericToInteger(g).toString());
  else if(type == "Float")
    printLine("Debug " + GenericToFloat(g).toString(2));
}
```

* **generic:** Variable to get type of
* **Returns:** String name of type
