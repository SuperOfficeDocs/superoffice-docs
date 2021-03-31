---
uid: crmscript_ref_NSQuoteAgent_SaveQuoteVersionNumber
title: Bool SaveQuoteVersionNumber(Integer quoteVersionId, String number)
intellisense: NSQuoteAgent.SaveQuoteVersionNumber
keywords: NSQuoteAgent, SaveQuoteVersionNumber
so.topic: reference
---

Save the quote version number if it is valid

**Parameters:**
 - **quoteVersionId** VersionId of the quote version
 - **number** The number to save

**Returns:** True if the number was valid and then saved

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
String number;
Bool res = agent.SaveQuoteVersionNumber(quoteVersionId, number);
```

