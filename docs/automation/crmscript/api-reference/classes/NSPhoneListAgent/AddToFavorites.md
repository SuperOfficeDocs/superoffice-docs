---
uid: crmscript_ref_NSPhoneListAgent_AddToFavorites
title: Integer AddToFavorites(Integer contactId)
intellisense: NSPhoneListAgent.AddToFavorites
keywords: NSPhoneListAgent, AddToFavorites
so.topic: reference
---

Adds a new contact to the history/favorites. Returns the rank of the new history item. If the contact already existed in the history, it isn't added but the rank is updated.

**Parameters:**
 - **contactId** The contact id

**Returns:** The rank of the history item

```crmscript
NSPhoneListAgent agent;
Integer contactId;
Integer res = agent.AddToFavorites(contactId);
```

