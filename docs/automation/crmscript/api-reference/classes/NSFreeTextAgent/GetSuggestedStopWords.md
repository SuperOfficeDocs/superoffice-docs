---
uid: crmscript_ref_NSFreeTextAgent_GetSuggestedStopWords
title: NSMDOListItem[] GetSuggestedStopWords(Integer countWords)
intellisense: NSFreeTextAgent.GetSuggestedStopWords
keywords: NSFreeTextAgent, GetSuggestedStopWords
so.topic: reference
---

Returns the top used words in the freetext index table, sorted as most used first

**Parameters:**
 - **countWords** The count of words that will be returned

**Returns:** NSMDOListItem[]

```crmscript
NSFreeTextAgent agent;
Integer countWords;
NSMDOListItem[] res = agent.GetSuggestedStopWords(countWords);
```

