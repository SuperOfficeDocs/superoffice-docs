---
uid: crmscript_ref_Generic_getTypeDimensions_Generic_generic
title: Generic.getTypeDimensions(Generic generic)
intellisense: Generic.getTypeDimensions
langref: 1
sortOrder: 110
keywords: getTypeDimensions(Generic)
so.topic: reference
---


Get the number of array dimensions for any variable (will automatically be up-casted to a Generic).

Note: this is the number of dimensions, not the length of the arrays.

For example:

```crmscript
Integer[][] i;
getTypeDimensions(i); // Returns 2
```

* **generic:** Generic The value to get the dimensions for
* **Returns:** Integer number of dimensions.
