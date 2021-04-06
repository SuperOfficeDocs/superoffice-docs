---
uid: crmscript_ref_NSQuoteLine_SetVAT
title: SetVAT(Float vAT)
intellisense: NSQuoteLine.SetVAT
keywords: NSQuoteLine, GetVAT
so.topic: reference
---

Tax/VAT - THIS IS A PERCENTAGE. The connector is responsible for populating this field; the percentage will be used to calculate VAT amounts available as merge fields in the document templates (but amounts are never stored in the database).

**Parameter:** 
 - **vAT** Float

```crmscript
NSQuoteLine thing;
Float vAT;
thing.SetVAT(vAT);
```

