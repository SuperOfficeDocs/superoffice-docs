---
uid: crmscript_ref_NSQuoteVersion_GetERPDeliveryTermsKey
title: String GetERPDeliveryTermsKey()
intellisense: NSQuoteVersion.GetERPDeliveryTermsKey
keywords: NSQuoteVersion, GetERPDeliveryTermsKey
so.topic: reference
---

# String GetERPDeliveryTermsKey()

Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text. For instance: ‘FOB’ (‘Free on board’).

**Returns:** String

```crmscript
NSQuoteVersion thing;
String eRPDeliveryTermsKey  = thing.GetERPDeliveryTermsKey();
```

