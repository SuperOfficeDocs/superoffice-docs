---
uid: crmscript_ref_NSSaleAgent_IsNumberValid
title: Bool IsNumberValid(Integer contactId, String number)
intellisense: NSSaleAgent.IsNumberValid
keywords: NSSaleAgent, IsNumberValid
so.topic: reference
---

# Bool IsNumberValid(Integer contactId, String number)

Checks if the number is unique or required.  The setting is configured from admin under system options.

**Parameters:**
 - **contactId** SaleId
 - **number** Number value to check for uniqueness/required

**Returns:** Bool

```crmscript
NSSaleAgent agent;
Integer contactId;
String number;
Bool res = agent.IsNumberValid(contactId, number);
```

