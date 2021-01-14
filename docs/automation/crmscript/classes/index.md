---
title: Classes
---

# Classes

You can declare variables of these objects in CRMScripts to get an object of the specified class. Then you can perform operations on that object.

## Example code

```crmscript
Customer myCust;
myCust.load(5);
myCust.setValue("firstname", "Erik");
myCust.save();
```

This script will create a customer object, load it with values from the customer with `id=5`, set the first name to "Erik", and save the customer.
