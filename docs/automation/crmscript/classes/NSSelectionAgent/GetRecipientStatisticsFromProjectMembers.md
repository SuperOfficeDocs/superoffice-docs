---
title: crmscript_ref_NSSelectionAgent_GetRecipientStatisticsFromProjectMembers
description: RecipientStatistics GetRecipientStatisticsFromProjectMembers(Integer projectId)
intellisense: NSSelectionAgent.GetRecipientStatisticsFromProjectMembers
keywords: NSSelectionAgent,GetRecipientStatisticsFromProjectMembers
so.topic: reference
---

Returns a RecipientStatistics object with a count of addresses, emailaddresses and emailaddresses based on members in a project.

**Parameters:**
 - **projectId** The id of the project to get the member statistics for.

**Returns:** Returns a RecipientStatistics object.

```crmscript
NSSelectionAgent agent;
Integer projectId;
RecipientStatistics res = agent.GetRecipientStatisticsFromProjectMembers(projectId);
```

