---
uid: crmscript_ref_NSQuoteAgent_CopyQuoteAlternative
title: QuoteAlternative CopyQuoteAlternative(Integer quoteVersionId, Integer quoteAlternativeId, String quoteAlternativeName)
intellisense: NSQuoteAgent.CopyQuoteAlternative
keywords: NSQuoteAgent, CopyQuoteAlternative
so.topic: reference
---

Copy a quote alternative from the same sale and adds it to a version.

**Parameters:**
 - **quoteVersionId** QuoteVersionId of the version to copy the alternative to.
 - **quoteAlternativeId** QuoteAlternativeId of the alternative to make a copy of.
 - **quoteAlternativeName** The name to set on the new alternative.

**Returns:** The copied QuoteAlternative.

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
Integer quoteAlternativeId;
String quoteAlternativeName;
QuoteAlternative res = agent.CopyQuoteAlternative(quoteVersionId, quoteAlternativeId, quoteAlternativeName);
```

