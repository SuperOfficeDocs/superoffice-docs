---
uid: crmscript_ref_NSQuoteAgent_GetQuoteLineConfigurationFromFieldName
title: NSQuoteLineConfiguration GetQuoteLineConfigurationFromFieldName(String fieldName)
intellisense: NSQuoteAgent.GetQuoteLineConfigurationFromFieldName
keywords: NSQuoteAgent, GetQuoteLineConfigurationFromFieldName
so.topic: reference
---

Returns the configuration field with the given field name

**Parameters:**
 - **fieldName** Field name of the NSQuoteLineConfiguration to get.

**Returns:** NSQuoteLineConfiguration

```crmscript
NSQuoteAgent agent;
String fieldName;
NSQuoteLineConfiguration res = agent.GetQuoteLineConfigurationFromFieldName(fieldName);
```

