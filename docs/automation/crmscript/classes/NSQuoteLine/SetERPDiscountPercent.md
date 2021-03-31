---
uid: crmscript_ref_NSQuoteLine_SetERPDiscountPercent
title: SetERPDiscountPercent(Float eRPDiscountPercent)
intellisense: NSQuoteLine.SetERPDiscountPercent
keywords: NSQuoteLine, GetERPDiscountPercent
so.topic: reference
---

The discount the system calculates based on customer / quantity / whatever. Can be overrided by the salesman in the field 'DiscountPercent' or 'DiscountAmount'. Both fields ERPDiscountPercent and ERPDiscountAmount will be filled out. If UserValueOverride is set to ‘None’ then the value is copied to DiscountPercent. The Percentage is given in integer form, i.e. ‘12%’ is represented as ‘12’.

**Parameter:** 
 - **eRPDiscountPercent** Float

