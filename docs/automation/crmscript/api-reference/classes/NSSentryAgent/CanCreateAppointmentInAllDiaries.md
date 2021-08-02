---
uid: crmscript_ref_NSSentryAgent_CanCreateAppointmentInAllDiaries
title: Bool CanCreateAppointmentInAllDiaries()
intellisense: NSSentryAgent.CanCreateAppointmentInAllDiaries
keywords: NSSentryAgent, CanCreateAppointmentInAllDiaries
so.topic: reference
---

CanCreateAppointmentInAllDiaries will check if the current associate can create appointments in diaries belonging all other associates. CanCreateAppointmentInAssociateDiaries will only check against associates that are diary owners.


**Returns:** Bool

```crmscript
NSSentryAgent agent;
Bool res = agent.CanCreateAppointmentInAllDiaries();
```

