---
uid: crmscript_ref_NSQuoteAgent_GetExtraInfo
title: NSProductExtraDataField[] GetExtraInfo(String quoteLineExtraData)
intellisense: NSQuoteAgent.GetExtraInfo
keywords: NSQuoteAgent, GetExtraInfo
so.topic: reference
---

# NSProductExtraDataField[] GetExtraInfo(String quoteLineExtraData)

Converts an xml string into an object representation.

**Parameters:**
 - **quoteLineExtraData** The extra data as xml.

**Returns:** NSProductExtraDataField[]

```crmscript
NSQuoteAgent agent;
String quoteLineExtraData;
NSProductExtraDataField[] res = agent.GetExtraInfo(quoteLineExtraData);
```

