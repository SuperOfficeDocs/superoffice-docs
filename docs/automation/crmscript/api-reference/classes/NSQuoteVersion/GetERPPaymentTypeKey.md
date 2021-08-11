---
uid: crmscript_ref_NSQuoteVersion_GetERPPaymentTypeKey
title: String GetERPPaymentTypeKey()
intellisense: NSQuoteVersion.GetERPPaymentTypeKey
keywords: NSQuoteVersion, GetERPPaymentTypeKey
so.topic: reference
---

# String GetERPPaymentTypeKey()

Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text. For instance: 'Invoice'.

**Returns:** String

```crmscript
NSQuoteVersion thing;
String eRPPaymentTypeKey  = thing.GetERPPaymentTypeKey();
```

