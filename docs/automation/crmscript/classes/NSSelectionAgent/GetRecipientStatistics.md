---
title: crmscript_ref_NSSelectionAgent_GetRecipientStatistics
description: RecipientStatistics GetRecipientStatistics(Integer selectionId)
intellisense: NSSelectionAgent.GetRecipientStatistics
keywords: NSSelectionAgent,GetRecipientStatistics
so.topic: reference
---

Returns a RecipientStatistics object with a count of addresses, emailaddresses and emailaddresses.

**Parameters:**
 - **selectionId** The id of the selection to get the statistics for.

**Returns:** Returns a RecipientStatistics object.

```crmscript
NSSelectionAgent agent;
Integer selectionId;
RecipientStatistics res = agent.GetRecipientStatistics(selectionId);
```

