---
uid: crmscript_ref_NSContactAgent_GetContactList
title: NSContact[] GetContactList(Integer[]  contactIds);
intellisense: NSContactAgent.GetContactList
keywords: NSContactAgent, GetContactList
so.topic: reference
---

Gets a vector of Contact objects.

**Parameters:**
 - **contactIds** The identifiers of the NSContact objects

**Returns:** NSContact[]

```crmscript
Integer[] ids;
NSContactAgent agent;
agent.GetContactList(ids);
```

