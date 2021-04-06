---
uid: crmscript_ref_NSPersonEntity_GetConsents
title: ConsentInfoArray GetConsents()
intellisense: NSPersonEntity.GetConsents
keywords: NSPersonEntity, GetConsents
so.topic: reference
---

The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN'

**Returns:** ConsentInfoArray


```crmscript
NSPersonEntity thing;
ConsentInfoArray consents  = thing.GetConsents();
```


