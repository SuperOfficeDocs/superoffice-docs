---
title: crmscript_ref_NSBLOBAgent_GetBlobEntityOnCountry
description: BlobEntity GetBlobEntityOnCountry(Integer countryId)
intellisense: NSBLOBAgent.GetBlobEntityOnCountry
keywords: NSBLOBAgent,GetBlobEntityOnCountry
so.topic: reference
---

Gets the blob entity that represents the country flag binary object.

**Parameters:**
 - **countryId** The country id

**Returns:** BlobEntity object

```crmscript
NSBLOBAgent agent;
Integer countryId;
BlobEntity res = agent.GetBlobEntityOnCountry(countryId);
```

