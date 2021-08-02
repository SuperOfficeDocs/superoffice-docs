---
uid: crmscript_ref_NSSelectionAgent_GetRecipientStatisticsFromContactPersonIds
title: NSRecipientStatistics GetRecipientStatisticsFromContactPersonIds(NSContactPersonId[] contactPersonIds)
intellisense: NSSelectionAgent.GetRecipientStatisticsFromContactPersonIds
keywords: NSSelectionAgent, GetRecipientStatisticsFromContactPersonIds
so.topic: reference
---

Returns a NSRecipientStatistics object with a count of addresses, emailaddresses and emailaddresses based on contact and persons in a collection of ContactPersonId.

**Parameters:**
 - **contactPersonIds** A collection of ContactPersonId to get the statistics for.

**Returns:** NSRecipientStatistics

```crmscript
NSSelectionAgent agent;
NSContactPersonId[] contactPersonIds;
NSRecipientStatistics res = agent.GetRecipientStatisticsFromContactPersonIds(contactPersonIds);
```

