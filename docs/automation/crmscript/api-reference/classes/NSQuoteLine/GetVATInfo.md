---
uid: crmscript_ref_NSQuoteLine_GetVATInfo
title: String GetVATInfo()
intellisense: NSQuoteLine.GetVATInfo
keywords: NSQuoteLine, GetVATInfo
so.topic: reference
---

Tax/VAT information, Extra info about VAT that the connector might insert, and the users might want to specify on the quote. The core CRM product has no business logic for this field, it is wholly up to connectors to use it.

**Returns:** String


```crmscript
NSQuoteLine thing;
String vATInfo  = thing.GetVATInfo();
```


