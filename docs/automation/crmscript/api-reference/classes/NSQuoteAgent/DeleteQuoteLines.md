---
uid: crmscript_ref_NSQuoteAgent_DeleteQuoteLines
title: Void DeleteQuoteLines(Integer[] quoteLineIds)
intellisense: NSQuoteAgent.DeleteQuoteLines
keywords: NSQuoteAgent, DeleteQuoteLines
so.topic: reference
---

# Void DeleteQuoteLines(Integer[] quoteLineIds)

Delete the QuoteLines in the SuperOffice database

**Parameters:**
 - **quoteLineIds** Primary keys of the quotelines to delete

```crmscript
NSQuoteAgent agent;
Integer[] quoteLineIds;
agent.DeleteQuoteLines(quoteLineIds);
```
