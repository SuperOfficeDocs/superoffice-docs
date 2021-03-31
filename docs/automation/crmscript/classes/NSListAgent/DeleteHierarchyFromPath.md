---
title: crmscript_ref_NSListAgent_DeleteHierarchyFromPath
description: Void DeleteHierarchyFromPath(Integer domain, String path)
intellisense: NSListAgent.DeleteHierarchyFromPath
keywords: NSListAgent,DeleteHierarchyFromPath
so.topic: reference
---

Remove a hierarchy item and its children from a path

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
 - **path** Hierarchy path to item to delete

**Returns:** This method has no return value

```crmscript
NSListAgent agent;
Integer domain;
String path;
Void res = agent.DeleteHierarchyFromPath(domain, path);
```

