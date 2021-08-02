---
uid: crmscript_ref_NSListAgent_GetHierarchyFromPath
title: NSHierarchyEntity GetHierarchyFromPath(Integer domain, String path, Bool children)
intellisense: NSListAgent.GetHierarchyFromPath
keywords: NSListAgent, GetHierarchyFromPath
so.topic: reference
---

Get a hierarchy item from a path

**Parameters:**
 - **domain** Type of items to get
     - Enum: 0 = Unknown 
     - Enum: 1 = ExtraTables 
     - Enum: 2 = ScreenDefinitions 
     - Enum: 3 = Scripts 
     - Enum: 4 = Selections 
     - Enum: 5 = ExternalDocuments 
     - Enum: 6 = UserGroups 
     - Enum: 7 = ExternalDocumentRelatedToSpmMessage 
     - Enum: 8 = Dashboards 
 - **path** Hierarchy path to item
 - **children** Include sub-items?

**Returns:** NSHierarchyEntity

```crmscript
NSListAgent agent;
Integer domain;
String path;
Bool children;
NSHierarchyEntity res = agent.GetHierarchyFromPath(domain, path, children);
```

