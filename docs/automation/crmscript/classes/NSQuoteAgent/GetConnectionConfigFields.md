---
uid: crmscript_ref_NSQuoteAgent_GetConnectionConfigFields
title: StringDictionary GetConnectionConfigFields(Integer quoteConnectionId)
intellisense: NSQuoteAgent.GetConnectionConfigFields
keywords: NSQuoteAgent, GetConnectionConfigFields
so.topic: reference
---

Returns the config fields for the connection.

**Parameters:**
 - **quoteConnectionId** Primary key of the connection

**Returns:** Config Fields

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
StringDictionary res = agent.GetConnectionConfigFields(quoteConnectionId);
```

