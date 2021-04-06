---
uid: crmscript_ref_NSSelectionAgent_GetRecipientStatisticsFromContactPersonIds
title: RecipientStatistics GetRecipientStatisticsFromContactPersonIds(ContactPersonIdArray contactPersonIds)
intellisense: NSSelectionAgent.GetRecipientStatisticsFromContactPersonIds
keywords: NSSelectionAgent, GetRecipientStatisticsFromContactPersonIds
so.topic: reference
---

Returns a RecipientStatistics object with a count of addresses, emailaddresses and emailaddresses based on contact and persons in a collection of ContactPersonId.

**Parameters:**
 - **contactPersonIds** A collection of ContactPersonId to get the statistics for.

**Returns:** Returns a RecipientStatistics object.

```crmscript
NSSelectionAgent agent;
ContactPersonIdArray contactPersonIds;
RecipientStatistics res = agent.GetRecipientStatisticsFromContactPersonIds(contactPersonIds);
```

