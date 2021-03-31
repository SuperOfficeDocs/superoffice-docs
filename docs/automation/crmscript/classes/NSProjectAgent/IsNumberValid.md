---
title: crmscript_ref_NSProjectAgent_IsNumberValid
description: Bool IsNumberValid(Integer contactId, String number)
intellisense: NSProjectAgent.IsNumberValid
keywords: NSProjectAgent,IsNumberValid
so.topic: reference
---

Checks if the number is unique or required.  The setting is configured from admin under system options.

**Parameters:**
 - **contactId** The Project id
 - **number** The number to check for uniqueness and validity

**Returns:** True if the number is valid

```crmscript
NSProjectAgent agent;
Integer contactId;
String number;
Bool res = agent.IsNumberValid(contactId, number);
```

