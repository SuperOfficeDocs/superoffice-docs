---
title: crmscript_ref_NSQuoteAgent_RecalculateQuoteLine_NSQuoteLine_p_0_String__p_1
description: NSQuoteAgent.RecalculateQuoteLine(NSQuoteLine p_0, String[] p_1)
intellisense: NSQuoteAgent.RecalculateQuoteLine
keywords: RecalculateQuoteLine(NSQuoteLine,String[])
so.topic: reference
---


When the user changes one or more values in a quoteline, the connector gets to change the QuoteLine, for instance calculate VAT. Shall be called when the user changes any of the following fields: Quantity, DiscountAmount, DiscountPercent, ListPrice (if allowed). Will calculate the TotalPrice and the VAT (if possible) for the line.



* **quoteLine:** The QuoteLine to recalculate
* **changedFields:** The id of the changed fields in the form 'TableName.FieldName'
* **Returns:** The updated quote line.


