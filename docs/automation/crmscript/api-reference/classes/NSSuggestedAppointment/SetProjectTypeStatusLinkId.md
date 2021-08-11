---
uid: crmscript_ref_NSSuggestedAppointment_SetProjectTypeStatusLinkId
title: SetProjectTypeStatusLinkId(Integer projectTypeStatusLinkId)
intellisense: NSSuggestedAppointment.SetProjectTypeStatusLinkId
keywords: NSSuggestedAppointment, GetProjectTypeStatusLinkId
so.topic: reference
---

# SetProjectTypeStatusLinkId(Integer projectTypeStatusLinkId)

Link to projectTypeStatusLink, the anchor for project guide items. Either this OR saleAnchorId should be set, not both at the same time.

**Parameter:** 
 - **projectTypeStatusLinkId** Integer

```crmscript
NSSuggestedAppointment thing;
Integer projectTypeStatusLinkId;
thing.SetProjectTypeStatusLinkId(projectTypeStatusLinkId);
```

