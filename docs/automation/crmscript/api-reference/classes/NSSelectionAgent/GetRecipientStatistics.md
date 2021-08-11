---
uid: crmscript_ref_NSSelectionAgent_GetRecipientStatistics
title: NSRecipientStatistics GetRecipientStatistics(Integer selectionId)
intellisense: NSSelectionAgent.GetRecipientStatistics
keywords: NSSelectionAgent, GetRecipientStatistics
so.topic: reference
---

# NSRecipientStatistics GetRecipientStatistics(Integer selectionId)

Returns a NSRecipientStatistics object with a count of addresses, emailaddresses and emailaddresses.

**Parameters:**
 - **selectionId** The id of the selection to get the statistics for.

**Returns:** NSRecipientStatistics

```crmscript
NSSelectionAgent agent;
Integer selectionId;
NSRecipientStatistics res = agent.GetRecipientStatistics(selectionId);
```

