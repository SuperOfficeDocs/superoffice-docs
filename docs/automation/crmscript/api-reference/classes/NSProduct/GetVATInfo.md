---
uid: crmscript_ref_NSProduct_GetVATInfo
title: String GetVATInfo()
intellisense: NSProduct.GetVATInfo
keywords: NSProduct, GetVATInfo
so.topic: reference
---

# String GetVATInfo()

A field for putting VATInfo you need to show in the final quoteDocument, like the VAT type that is used. Not used in any business logic in SuperOffice; available to document templates.

**Returns:** String

```crmscript
NSProduct thing;
String vATInfo  = thing.GetVATInfo();
```

