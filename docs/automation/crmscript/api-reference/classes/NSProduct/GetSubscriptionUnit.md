---
uid: crmscript_ref_NSProduct_GetSubscriptionUnit
title: String GetSubscriptionUnit()
intellisense: NSProduct.GetSubscriptionUnit
keywords: NSProduct, GetSubscriptionUnit
so.topic: reference
---

# String GetSubscriptionUnit()

Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text with the actual subscription unit.

**Returns:** String

```crmscript
NSProduct thing;
String subscriptionUnit  = thing.GetSubscriptionUnit();
```

