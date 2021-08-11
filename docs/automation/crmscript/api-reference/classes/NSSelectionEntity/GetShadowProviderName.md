---
uid: crmscript_ref_NSSelectionEntity_GetShadowProviderName
title: String GetShadowProviderName()
intellisense: NSSelectionEntity.GetShadowProviderName
keywords: NSSelectionEntity, GetShadowProviderName
so.topic: reference
---

# String GetShadowProviderName()

The name, if relevant, of the Archive Provider that will deliver the Shadow rows: contact/person rows related to the actual entity. Can be blank, indicating that there is no shadow archive

**Returns:** String

```crmscript
NSSelectionEntity thing;
String shadowProviderName  = thing.GetShadowProviderName();
```

