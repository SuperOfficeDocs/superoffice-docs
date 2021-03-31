---
uid: crmscript_ref_NSPersonAgent_HasConsent
title: Bool HasConsent(Integer personId, String purpose)
intellisense: NSPersonAgent.HasConsent
keywords: NSPersonAgent, HasConsent
so.topic: reference
---

Check if consent has been given by a specified person, for a specific purpose. Withdraw consents return FALSE.

**Parameters:**
 - **personId** The person id
 - **purpose** The key of the purpose to check. (e.g. 'STORE' or 'EMARKETING')

**Returns:** True if the person has consented to the given purpose.

```crmscript
NSPersonAgent agent;
Integer personId;
String purpose;
Bool res = agent.HasConsent(personId, purpose);
```

