---
uid: crmscript_ref_NSPersonEntity_SetConsents
title: SetConsents(ConsentInfo[] consents)
intellisense: NSPersonEntity.SetConsents
keywords: NSPersonEntity, GetConsents
so.topic: reference
---

The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN'

**Parameter:** 
 - **consents** ConsentInfo[]

```crmscript
NSPersonEntity thing;
ConsentInfo[] consents;
thing.SetConsents(consents);
```

