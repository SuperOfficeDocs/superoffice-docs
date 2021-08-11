---
uid: crmscript_ref_NSQuoteAlternative_GetVATInfo
title: String GetVATInfo()
intellisense: NSQuoteAlternative.GetVATInfo
keywords: NSQuoteAlternative, GetVATInfo
so.topic: reference
---

# String GetVATInfo()

Extra info about VAT that the connector might insert. This field has no business logic in the CRM code, but is available as a merge field in the quote documents.

**Returns:** String

```crmscript
NSQuoteAlternative thing;
String vATInfo  = thing.GetVATInfo();
```

