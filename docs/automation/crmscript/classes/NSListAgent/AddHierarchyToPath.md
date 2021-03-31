---
title: crmscript_ref_NSListAgent_AddHierarchyToPath
description: HierarchyEntity AddHierarchyToPath(Integer domain, String path, String name)
intellisense: NSListAgent.AddHierarchyToPath
keywords: NSListAgent,AddHierarchyToPath
so.topic: reference
---

Add a hierarchy item to a path

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
 - **path** Hierarchy path to parent item
 - **name** Name of node to add

**Returns:** The hierarchy node added to the path

```crmscript
NSListAgent agent;
Integer domain;
String path;
String name;
HierarchyEntity res = agent.AddHierarchyToPath(domain, path, name);
```

