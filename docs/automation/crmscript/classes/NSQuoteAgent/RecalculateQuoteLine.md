---
uid: crmscript_ref_NSQuoteAgent_RecalculateQuoteLine
title: QuoteLine RecalculateQuoteLine(QuoteLine quoteLine, StringArray changedFields)
intellisense: NSQuoteAgent.RecalculateQuoteLine
keywords: NSQuoteAgent, RecalculateQuoteLine
so.topic: reference
---

When the user changes one or more values in a quoteline, the connector gets to change the QuoteLine, for instance calculate VAT. Shall be called when the user changes any of the following fields: Quantity, DiscountAmount, DiscountPercent, ListPrice (if allowed). Will calculate the TotalPrice and the VAT (if possible) for the line.

**Parameters:**
 - **quoteLine** The QuoteLine to recalculate
 - **changedFields** The id of the changed fields in the form 'TableName.FieldName'

**Returns:** The updated quote line.

```crmscript
NSQuoteAgent agent;
QuoteLine quoteLine;
StringArray changedFields;
QuoteLine res = agent.RecalculateQuoteLine(quoteLine, changedFields);
```

