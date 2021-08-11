---
uid: crmscript_ref_NSProjectAgent_IsNumberValid
title: Bool IsNumberValid(Integer contactId, String number)
intellisense: NSProjectAgent.IsNumberValid
keywords: NSProjectAgent, IsNumberValid
so.topic: reference
---

# Bool IsNumberValid(Integer contactId, String number)

Checks if the number is unique or required.  The setting is configured from admin under system options.

**Parameters:**
 - **contactId** The Project id
 - **number** The number to check for uniqueness and validity

**Returns:** Bool

```crmscript
NSProjectAgent agent;
Integer contactId;
String number;
Bool res = agent.IsNumberValid(contactId, number);
```

