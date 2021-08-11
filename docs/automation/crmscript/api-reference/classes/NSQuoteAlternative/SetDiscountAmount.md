---
uid: crmscript_ref_NSQuoteAlternative_SetDiscountAmount
title: SetDiscountAmount(Float discountAmount)
intellisense: NSQuoteAlternative.SetDiscountAmount
keywords: NSQuoteAlternative, GetDiscountAmount
so.topic: reference
---

# SetDiscountAmount(Float discountAmount)

The discount the sales rep specifies, in whatever currency the sale is in. Both the two ‘DiscountPercent’ and ‘DiscountAmount’ shall be filled out, but the UserValueOverride field must be set to the field the user actually changed. If this field is filled out by the user, it overrides the discount suggested by the connector. If the user has not filled any values, the system will copy the ERP discount amount value into this field.

**Parameter:** 
 - **discountAmount** Float

```crmscript
NSQuoteAlternative thing;
Float discountAmount;
thing.SetDiscountAmount(discountAmount);
```

