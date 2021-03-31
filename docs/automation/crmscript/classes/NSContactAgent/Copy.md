---
uid: crmscript_ref_NSContactAgent_Copy
title: Integer Copy(Integer sourceContactId, String destinationContactName, String destinationContactDepartment, Bool copyPersons)
intellisense: NSContactAgent.Copy
keywords: NSContactAgent, Copy
so.topic: reference
---

Copy a contact. Activities and related data will be ignored

**Parameters:**
 - **sourceContactId** The id of the contact to copy
 - **destinationContactName** The name of the destination contact
 - **destinationContactDepartment** The department of the destination contact
 - **copyPersons** If true, persons will be copied from source contact

**Returns:** Id of copied contact

```crmscript
NSContactAgent agent;
Integer sourceContactId;
String destinationContactName;
String destinationContactDepartment;
Bool copyPersons;
Integer res = agent.Copy(sourceContactId, destinationContactName, destinationContactDepartment, copyPersons);
```

