---
uid: crmscript_ref_NSProjectEventEntity_SetIsPublished
title: SetIsPublished(Bool isPublished)
intellisense: NSProjectEventEntity.SetIsPublished
keywords: NSProjectEventEntity, GetIsPublished
so.topic: reference
---

Publish to external users? When true, the event/project information is visible to external users through the Audience portal. You can control the publish duration using the PublishFrom/PublishTo properties.

**Parameter:** 
 - **isPublished** Bool

```crmscript
NSProjectEventEntity thing;
Bool isPublished;
thing.SetIsPublished(isPublished);
```

