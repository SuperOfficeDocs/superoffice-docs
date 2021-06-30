---
uid: crmscript_ref_NSFreeTextAgent_GetSuggestedStopWords
title: MDOListItem[] GetSuggestedStopWords(Integer countWords)
intellisense: NSFreeTextAgent.GetSuggestedStopWords
keywords: NSFreeTextAgent, GetSuggestedStopWords
so.topic: reference
---

Returns the top used words in the freetext index table, sorted as most used first

**Parameters:**
 - **countWords** The count of words that will be returned

**Returns:** The most used words

```crmscript
NSFreeTextAgent agent;
Integer countWords;
MDOListItem[] res = agent.GetSuggestedStopWords(countWords);
```

