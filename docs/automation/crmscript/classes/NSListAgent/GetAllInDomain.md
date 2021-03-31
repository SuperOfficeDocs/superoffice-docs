---
title: crmscript_ref_NSListAgent_GetAllInDomain
description: HierarchyEntityArray GetAllInDomain(Integer domain, Bool children)
intellisense: NSListAgent.GetAllInDomain
keywords: NSListAgent,GetAllInDomain
so.topic: reference
---

Get all items in a domain

**Parameters:**
 - **domain** Type of items to get (scripts, extra tables, etc)
     - Enum: 0 = Unknown 
     - Enum: 1 = ExtraTables 
     - Enum: 2 = ScreenDefinitions 
     - Enum: 3 = Scripts 
     - Enum: 4 = Selections 
     - Enum: 5 = ExternalDocuments 
     - Enum: 6 = UserGroups 
     - Enum: 7 = ExternalDocumentRelatedToSpmMessage 
     - Enum: 8 = Dashboards 
 - **children** Include sub-items?

**Returns:** All items and child items within a domain

```crmscript
NSListAgent agent;
Integer domain;
Bool children;
HierarchyEntityArray res = agent.GetAllInDomain(domain, children);
```

