---
uid: crmscript_ref_NSSaleTypeEntity_GetConfirmationLinesTemplate
title: Integer GetConfirmationLinesTemplate()
intellisense: NSSaleTypeEntity.GetConfirmationLinesTemplate
keywords: NSSaleTypeEntity, GetConfirmationLinesTemplate
so.topic: reference
---

# Integer GetConfirmationLinesTemplate()

The template that this sale type should use when producing the order confirmation lines document; the template must have DocTmplQuoteType=ConfirmationLines

**Returns:** Integer

```crmscript
NSSaleTypeEntity thing;
Integer confirmationLinesTemplate  = thing.GetConfirmationLinesTemplate();
```

