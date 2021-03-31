---
uid: crmscript_ref_NSQuoteLine_GetERPDiscountPercent
title: Float GetERPDiscountPercent()
intellisense: NSQuoteLine.GetERPDiscountPercent
keywords: NSQuoteLine, GetERPDiscountPercent
so.topic: reference
---

The discount the system calculates based on customer / quantity / whatever. Can be overrided by the salesman in the field 'DiscountPercent' or 'DiscountAmount'. Both fields ERPDiscountPercent and ERPDiscountAmount will be filled out. If UserValueOverride is set to ‘None’ then the value is copied to DiscountPercent. The Percentage is given in integer form, i.e. ‘12%’ is represented as ‘12’.

**Returns:** Float


