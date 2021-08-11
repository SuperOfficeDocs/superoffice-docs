---
uid: crmscript_ref_NSQuoteVersion_SetERPDeliveryTermsKey
title: SetERPDeliveryTermsKey(String eRPDeliveryTermsKey)
intellisense: NSQuoteVersion.SetERPDeliveryTermsKey
keywords: NSQuoteVersion, GetERPDeliveryTermsKey
so.topic: reference
---

# SetERPDeliveryTermsKey(String eRPDeliveryTermsKey)

Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text. For instance: ‘FOB’ (‘Free on board’).

**Parameter:** 
 - **eRPDeliveryTermsKey** String

```crmscript
NSQuoteVersion thing;
String eRPDeliveryTermsKey;
thing.SetERPDeliveryTermsKey(eRPDeliveryTermsKey);
```

