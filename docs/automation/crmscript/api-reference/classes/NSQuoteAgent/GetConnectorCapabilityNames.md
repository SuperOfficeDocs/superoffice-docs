---
uid: crmscript_ref_NSQuoteAgent_GetConnectorCapabilityNames
title: String[] GetConnectorCapabilityNames(Integer quoteConnectionId)
intellisense: NSQuoteAgent.GetConnectorCapabilityNames
keywords: NSQuoteAgent, GetConnectorCapabilityNames
so.topic: reference
---

Gets a list of all possible connector capabilities

**Parameters:**
 - **quoteConnectionId** Primary key of the connection

**Returns:** String[]

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
String[] res = agent.GetConnectorCapabilityNames(quoteConnectionId);
```

