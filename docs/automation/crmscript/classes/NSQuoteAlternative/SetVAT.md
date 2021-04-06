---
uid: crmscript_ref_NSQuoteAlternative_SetVAT
title: SetVAT(Float vAT)
intellisense: NSQuoteAlternative.SetVAT
keywords: NSQuoteAlternative, GetVAT
so.topic: reference
---

Tax/VAT - THIS IS AN AMOUNT, available as a merge field in the quote document. The SuperOffice quote connector will calculate this field based on the vat PERCENTAGES on the individual lines; other connectors may implement other algorithms at will.

**Parameter:** 
 - **vAT** Float

```crmscript
NSQuoteAlternative thing;
Float vAT;
thing.SetVAT(vAT);
```

