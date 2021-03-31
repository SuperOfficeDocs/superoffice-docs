---
uid: crmscript_ref_NSAIAgent_TrainCategoryGuesser
title: String TrainCategoryGuesser(Integer selectionId, Integer maxItems, Integer maxTextLength)
intellisense: NSAIAgent.TrainCategoryGuesser
keywords: NSAIAgent, TrainCategoryGuesser
so.topic: reference
---

The category guesser training API will be called with an array of CategorizationTrainingItem during the (background, Batch) execution of this call

**Parameters:**
 - **selectionId** Id of selection of tickets, to retrieve training data from
 - **maxItems** Maximum number of tickets to retrieve data from
 - **maxTextLength** Maximum length of PlainTextBody or any other large text, truncated to nearest word boundary

**Returns:** Placeholder for result...  should this be a BatchTaskId?  maybe not useful?

```crmscript
NSAIAgent agent;
Integer selectionId;
Integer maxItems;
Integer maxTextLength;
String res = agent.TrainCategoryGuesser(selectionId, maxItems, maxTextLength);
```

