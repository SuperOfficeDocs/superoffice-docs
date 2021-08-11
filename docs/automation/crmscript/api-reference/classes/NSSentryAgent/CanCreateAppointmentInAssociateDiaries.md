---
uid: crmscript_ref_NSSentryAgent_CanCreateAppointmentInAssociateDiaries
title: Bool CanCreateAppointmentInAssociateDiaries(Integer[] associateIds)
intellisense: NSSentryAgent.CanCreateAppointmentInAssociateDiaries
keywords: NSSentryAgent, CanCreateAppointmentInAssociateDiaries
so.topic: reference
---

# Bool CanCreateAppointmentInAssociateDiaries(Integer[] associateIds)

CanCreateAppointmentInAssociateDiaries will check if the current associate can create appointments in diaries belonging to the associates listed in associateIds. CanCreateAppointmentInAssociateDiaries will only check against associates that are diary owners. If none of the associates listed in the associateIds parameter is a diary owner, the method will return true.

**Parameters:**
 - **associateIds** Array of associate ids to check.

**Returns:** Bool

```crmscript
NSSentryAgent agent;
Integer[] associateIds;
Bool res = agent.CanCreateAppointmentInAssociateDiaries(associateIds);
```

