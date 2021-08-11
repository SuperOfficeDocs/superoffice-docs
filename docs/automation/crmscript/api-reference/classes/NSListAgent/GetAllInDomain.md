---
uid: crmscript_ref_NSListAgent_GetAllInDomain
title: NSHierarchyEntity[] GetAllInDomain(Integer domain, Bool children)
intellisense: NSListAgent.GetAllInDomain
keywords: NSListAgent, GetAllInDomain
so.topic: reference
---

# NSHierarchyEntity[] GetAllInDomain(Integer domain, Bool children)

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

**Returns:** NSHierarchyEntity[]

```crmscript
NSListAgent agent;
Integer domain;
Bool children;
NSHierarchyEntity[] res = agent.GetAllInDomain(domain, children);
```

