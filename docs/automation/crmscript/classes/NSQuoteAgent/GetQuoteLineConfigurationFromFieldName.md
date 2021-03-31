---
title: crmscript_ref_NSQuoteAgent_GetQuoteLineConfigurationFromFieldName
description: QuoteLineConfiguration GetQuoteLineConfigurationFromFieldName(String fieldName)
intellisense: NSQuoteAgent.GetQuoteLineConfigurationFromFieldName
keywords: NSQuoteAgent,GetQuoteLineConfigurationFromFieldName
so.topic: reference
---

Returns the configuration field with the given field name

**Parameters:**
 - **fieldName** Field name of the QuoteLineConfiguration to get.

**Returns:** QuoteLineConfiguration

```crmscript
NSQuoteAgent agent;
String fieldName;
QuoteLineConfiguration res = agent.GetQuoteLineConfigurationFromFieldName(fieldName);
```

