---
title: crmscript_ref_NSContactAgent_GetNameDepartmentDuplicates
description: DuplicateEntryArray GetNameDepartmentDuplicates(String name, String department)
intellisense: NSContactAgent.GetNameDepartmentDuplicates
keywords: NSContactAgent,GetNameDepartmentDuplicates
so.topic: reference
---

Get duplicates based on the contact name and department

**Parameters:**
 - **name** Name used for lookup
 - **department** Department used for lookup (if any)

**Returns:** Any records matching the specified name and department

```crmscript
NSContactAgent agent;
String name;
String department;
DuplicateEntryArray res = agent.GetNameDepartmentDuplicates(name, department);
```

