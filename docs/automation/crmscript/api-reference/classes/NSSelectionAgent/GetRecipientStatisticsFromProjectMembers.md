---
uid: crmscript_ref_NSSelectionAgent_GetRecipientStatisticsFromProjectMembers
title: NSRecipientStatistics GetRecipientStatisticsFromProjectMembers(Integer projectId)
intellisense: NSSelectionAgent.GetRecipientStatisticsFromProjectMembers
keywords: NSSelectionAgent, GetRecipientStatisticsFromProjectMembers
so.topic: reference
---

# NSRecipientStatistics GetRecipientStatisticsFromProjectMembers(Integer projectId)

Returns a NSRecipientStatistics object with a count of addresses, emailaddresses and emailaddresses based on members in a project.

**Parameters:**
 - **projectId** The id of the project to get the member statistics for.

**Returns:** NSRecipientStatistics

```crmscript
NSSelectionAgent agent;
Integer projectId;
NSRecipientStatistics res = agent.GetRecipientStatisticsFromProjectMembers(projectId);
```

