---
uid: crmscript_ref_NSQuoteAgent_CreateQuoteAlternative
title: NSQuoteAlternative CreateQuoteAlternative(Integer quoteVersionId, String quoteAlternativeName, String quoteAlternativeDescription)
intellisense: NSQuoteAgent.CreateQuoteAlternative
keywords: NSQuoteAgent, CreateQuoteAlternative
so.topic: reference
---

Create a new quote alternative on a version.

**Parameters:**
 - **quoteVersionId** QuoteVersionId of the version to create the alternative on.
 - **quoteAlternativeName** The name to set on the new alternative.
 - **quoteAlternativeDescription** The description to set on the new alternative.

**Returns:** NSQuoteAlternative.

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
String quoteAlternativeName;
String quoteAlternativeDescription;
NSQuoteAlternative res = agent.CreateQuoteAlternative(quoteVersionId, quoteAlternativeName, quoteAlternativeDescription);
```

