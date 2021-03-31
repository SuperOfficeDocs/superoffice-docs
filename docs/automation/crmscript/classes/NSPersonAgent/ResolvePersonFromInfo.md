---
title: crmscript_ref_NSPersonAgent_ResolvePersonFromInfo
description: ResolvedPerson ResolvePersonFromInfo(Integer contactId, String personName, StringArray phoneNumbers, StringArray emails)
intellisense: NSPersonAgent.ResolvePersonFromInfo
keywords: NSPersonAgent,ResolvePersonFromInfo
so.topic: reference
---

Get a person from the provided information. If the person does not exist, it will be created on demand.

**Parameters:**
 - **contactId** The contact Id of the contact which the person belongs to. Cannot be 0.
 - **personName** The full name of the person to be resolved. Optional.
 - **phoneNumbers** Phone numbers registered on the person. Optional.
 - **emails** Email-addresses registered on the person. Optional.

**Returns:** The results of the resolve-operation.

```crmscript
NSPersonAgent agent;
Integer contactId;
String personName;
StringArray phoneNumbers;
StringArray emails;
ResolvedPerson res = agent.ResolvePersonFromInfo(contactId, personName, phoneNumbers, emails);
```

