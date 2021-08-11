---
uid: crmscript_ref_NSQuoteLine_GetVAT
title: Float GetVAT()
intellisense: NSQuoteLine.GetVAT
keywords: NSQuoteLine, GetVAT
so.topic: reference
---

# Float GetVAT()

Tax/VAT - THIS IS A PERCENTAGE. The connector is responsible for populating this field; the percentage will be used to calculate VAT amounts available as merge fields in the document templates (but amounts are never stored in the database).

**Returns:** Float

```crmscript
NSQuoteLine thing;
Float vAT  = thing.GetVAT();
```

