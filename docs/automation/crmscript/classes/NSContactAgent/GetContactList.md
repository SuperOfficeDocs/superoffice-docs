---
title: crmscript_ref_NSContactAgent_GetContactList
description: NSContact[] GetContactList(Integer[]  contactIds);
intellisense: NSContactAgent.GetContactList
keywords: NSContactAgent,GetContactList
so.topic: reference
---

Gets a vector of Contact objects.

**Parameters:**
 - **contactIds** The identifiers of the NSContact objects

**Returns:** Vector of NSContact objects

```crmscript
Integer[] ids;
NSContactAgent agent;
agent.GetContactList(ids);
```

