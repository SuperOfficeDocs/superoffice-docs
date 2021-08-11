---
uid: crmscript_ref_NSContactAgent_GetNameDepartmentDuplicates
title: NSDuplicateEntry[] GetNameDepartmentDuplicates(String name, String department)
intellisense: NSContactAgent.GetNameDepartmentDuplicates
keywords: NSContactAgent, GetNameDepartmentDuplicates
so.topic: reference
---

# NSDuplicateEntry[] GetNameDepartmentDuplicates(String name, String department)

Get duplicates based on the contact name and department

**Parameters:**
 - **name** Name used for lookup
 - **department** Department used for lookup (if any)

**Returns:** NSDuplicateEntry[]

```crmscript
NSContactAgent agent;
String name;
String department;
NSDuplicateEntry[] res = agent.GetNameDepartmentDuplicates(name, department);
```

