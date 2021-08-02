---
uid: crmscript_ref_NSPersonEntity_GetConsents
title: NSConsentInfo[] GetConsents()
intellisense: NSPersonEntity.GetConsents
keywords: NSPersonEntity, GetConsents
so.topic: reference
---

The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN'

**Returns:** NSConsentInfo[]


```crmscript
NSPersonEntity thing;
NSConsentInfo[] consents  = thing.GetConsents();
```


