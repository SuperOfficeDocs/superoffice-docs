---
uid: crmscript_ref_NSProjectEventEntity_GetIsPublished
title: Bool GetIsPublished()
intellisense: NSProjectEventEntity.GetIsPublished
keywords: NSProjectEventEntity, GetIsPublished
so.topic: reference
---

# Bool GetIsPublished()

Publish to external users? When true, the event/project information is visible to external users through the Audience portal. You can control the publish duration using the PublishFrom/PublishTo properties.

**Returns:** Bool

```crmscript
NSProjectEventEntity thing;
Bool isPublished  = thing.GetIsPublished();
```

