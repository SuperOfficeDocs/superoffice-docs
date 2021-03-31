---
title: crmscript_ref_NSFreeTextAgent_GetSuggestedStopWords
description: MDOListItemArray GetSuggestedStopWords(Integer countWords)
intellisense: NSFreeTextAgent.GetSuggestedStopWords
keywords: NSFreeTextAgent,GetSuggestedStopWords
so.topic: reference
---

Returns the top used words in the freetext index table, sorted as most used first

**Parameters:**
 - **countWords** The count of words that will be returned

**Returns:** The most used words

```crmscript
NSFreeTextAgent agent;
Integer countWords;
MDOListItemArray res = agent.GetSuggestedStopWords(countWords);
```

