---
title: crmscript_ref_NSContactAgent_GetAddress
description: Address GetAddress(Integer contactId)
intellisense: NSContactAgent.GetAddress
keywords: NSContactAgent,GetAddress
so.topic: reference
---

Gets the contact's localized address.

**Parameters:**
 - **contactId** The contact id

**Returns:** The address as LocalizedField[][].

```crmscript
NSContactAgent agent;
Integer contactId;
Address res = agent.GetAddress(contactId);
```

