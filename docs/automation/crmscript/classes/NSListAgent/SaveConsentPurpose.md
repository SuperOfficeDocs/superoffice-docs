---
uid: crmscript_ref_NSListAgent_SaveConsentPurpose
title: ConsentPurpose SaveConsentPurpose(ConsentPurpose consentPurpose)
intellisense: NSListAgent.SaveConsentPurpose
keywords: NSListAgent, SaveConsentPurpose
so.topic: reference
---

Save a ConsentPurpose object

**Parameters:**
 - **consentPurpose** The ConsentPurpose object to save

**Returns:** The saved ConsentPurpose object, updated with the ConsentPurposeId if it is a new database entry

```crmscript
NSListAgent agent;
ConsentPurpose consentPurpose;
ConsentPurpose res = agent.SaveConsentPurpose(consentPurpose);
```

