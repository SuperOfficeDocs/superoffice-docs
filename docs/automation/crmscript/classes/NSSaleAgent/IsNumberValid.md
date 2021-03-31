---
title: crmscript_ref_NSSaleAgent_IsNumberValid
description: Bool IsNumberValid(Integer contactId, String number)
intellisense: NSSaleAgent.IsNumberValid
keywords: NSSaleAgent,IsNumberValid
so.topic: reference
---

Checks if the number is unique or required.  The setting is configured from admin under system options.

**Parameters:**
 - **contactId** SaleId
 - **number** Number value to check for uniqueness/required

**Returns:** True if the number is valid

```crmscript
NSSaleAgent agent;
Integer contactId;
String number;
Bool res = agent.IsNumberValid(contactId, number);
```

