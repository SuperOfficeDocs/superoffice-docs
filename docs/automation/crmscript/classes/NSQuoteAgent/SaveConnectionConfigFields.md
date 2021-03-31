---
title: crmscript_ref_NSQuoteAgent_SaveConnectionConfigFields
description: StringDictionary SaveConnectionConfigFields(Integer quoteConnectionId, StringDictionary connectionConfigFields)
intellisense: NSQuoteAgent.SaveConnectionConfigFields
keywords: NSQuoteAgent,SaveConnectionConfigFields
so.topic: reference
---

Saves the connection config fields

**Parameters:**
 - **quoteConnectionId** Primary key of the connection
 - **connectionConfigFields** ConnectionConfigFields to save.

**Returns:** Config Fields

```crmscript
NSQuoteAgent agent;
Integer quoteConnectionId;
StringDictionary connectionConfigFields;
StringDictionary res = agent.SaveConnectionConfigFields(quoteConnectionId, connectionConfigFields);
```

