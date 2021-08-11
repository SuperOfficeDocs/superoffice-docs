---
uid: crmscript_ref_NSPersonAgent_IsNumberValid
title: Bool IsNumberValid(Integer contactId, String number)
intellisense: NSPersonAgent.IsNumberValid
keywords: NSPersonAgent, IsNumberValid
so.topic: reference
---

# Bool IsNumberValid(Integer contactId, String number)

Checks if the number is unique or required.  The setting is configured from admin under system options.

**Parameters:**
 - **contactId** 
 - **number** Number to check.

**Returns:** Bool

```crmscript
NSPersonAgent agent;
Integer contactId;
String number;
Bool res = agent.IsNumberValid(contactId, number);
```

