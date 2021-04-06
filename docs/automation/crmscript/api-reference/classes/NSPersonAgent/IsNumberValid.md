---
uid: crmscript_ref_NSPersonAgent_IsNumberValid
title: Bool IsNumberValid(Integer contactId, String number)
intellisense: NSPersonAgent.IsNumberValid
keywords: NSPersonAgent, IsNumberValid
so.topic: reference
---

Checks if the number is unique or required.  The setting is configured from admin under system options.

**Parameters:**
 - **contactId** 
 - **number** Number to check.

**Returns:** True if number is ok (passes uniqueness/required checks)

```crmscript
NSPersonAgent agent;
Integer contactId;
String number;
Bool res = agent.IsNumberValid(contactId, number);
```

