---
title: crmscript_ref_NSQuoteAgent_GetConnectorCapabilityNames
description: StringArray GetConnectorCapabilityNames(Integer quoteConnectionId)
intellisense: NSQuoteAgent.GetConnectorCapabilityNames
keywords: NSQuoteAgent,GetConnectorCapabilityNames
so.topic: reference
---

Gets a list of all possible connector capabilities

**Parameters:**
 - **quoteConnectionId** Primary key of the connection

**Returns:** Capabilities names

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
StringArray res = agent.GetConnectorCapabilityNames(quoteConnectionId);
```

