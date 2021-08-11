---
uid: crmscript_ref_NSSelectionEntity_SetShadowProviderName
title: SetShadowProviderName(String shadowProviderName)
intellisense: NSSelectionEntity.SetShadowProviderName
keywords: NSSelectionEntity, GetShadowProviderName
so.topic: reference
---

# SetShadowProviderName(String shadowProviderName)

The name, if relevant, of the Archive Provider that will deliver the Shadow rows: contact/person rows related to the actual entity. Can be blank, indicating that there is no shadow archive

**Parameter:** 
 - **shadowProviderName** String

```crmscript
NSSelectionEntity thing;
String shadowProviderName;
thing.SetShadowProviderName(shadowProviderName);
```

