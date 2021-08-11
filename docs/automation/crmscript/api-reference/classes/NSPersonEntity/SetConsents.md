---
uid: crmscript_ref_NSPersonEntity_SetConsents
title: SetConsents(NSConsentInfo[] consents)
intellisense: NSPersonEntity.SetConsents
keywords: NSPersonEntity, GetConsents
so.topic: reference
---

# SetConsents(NSConsentInfo[] consents)

The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN'

**Parameter:** 
 - **consents** NSConsentInfo[]

```crmscript
NSPersonEntity thing;
NSConsentInfo[] consents;
thing.SetConsents(consents);
```

