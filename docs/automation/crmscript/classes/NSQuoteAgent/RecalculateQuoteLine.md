---
title: NSQuoteLine RecalculateQuoteLine(NSQuoteLine quoteLine, String[] changedFields)
path: /EJScript/Classes/NSQuoteAgent/Member functions/NSQuoteLine RecalculateQuoteLine(NSQuoteLine p_0, String[] p_1)
intellisense: 1
classref: 1
sortOrder: 6009
keywords: RecalculateQuoteLine(NSQuoteLine,String[])
---


When the user changes one or more values in a quoteline, the connector gets to change the QuoteLine, for instance calculate VAT. Shall be called when the user changes any of the following fields: Quantity, DiscountAmount, DiscountPercent, ListPrice (if allowed). Will calculate the TotalPrice and the VAT (if possible) for the line.



* **quoteLine:** The QuoteLine to recalculate
* **changedFields:** The id of the changed fields in the form 'TableName.FieldName'
* **Returns:** The updated quote line.


