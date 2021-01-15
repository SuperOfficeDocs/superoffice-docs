---
title: Integer getTypeDimensions(Generic generic)
path: /EJScript/Classes/Generic/Member functions/Integer getTypeDimensions(Generic generic)
intellisense: 1
langref: 1
sortOrder: 110
keywords: getTypeDimensions(Generic)
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
