---
title: crmscript_ref_NSPersonAgent_NormalizeRanks
description: Bool NormalizeRanks(Integer contactId)
intellisense: NSPersonAgent.NormalizeRanks
keywords: NSPersonAgent,NormalizeRanks
so.topic: reference
---

Nomralize the ranks for all persons that belong to a contact. This means that the persons will be sorted according to their current rank values, and the ranks will be made monotonically increasing from 1.

**Parameters:**
 - **contactId** Id of contact whose persons are to be rank normalized

**Returns:** The reutrn value is true if the operation suceeded, either because all persons were already normalized, or because normalization was done. It is false if Sentry blocks any required changes.

```crmscript
NSPersonAgent agent;
Integer contactId;
Bool res = agent.NormalizeRanks(contactId);
```

