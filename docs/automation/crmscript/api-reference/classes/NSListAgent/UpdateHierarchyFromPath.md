---
uid: crmscript_ref_NSListAgent_UpdateHierarchyFromPath
title: NSHierarchyEntity UpdateHierarchyFromPath(Integer domain, String path, NSHierarchyEntity entity)
intellisense: NSListAgent.UpdateHierarchyFromPath
keywords: NSListAgent, UpdateHierarchyFromPath
so.topic: reference
---

# NSHierarchyEntity UpdateHierarchyFromPath(Integer domain, String path, NSHierarchyEntity entity)

Update a hierarchy item from a path

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
 - **entity** The hierarchy node to update.

**Returns:** The hierarchy node updated to the path

```crmscript
NSListAgent agent;
Integer domain;
String path;
NSHierarchyEntity entity;
NSHierarchyEntity res = agent.UpdateHierarchyFromPath(domain, path, entity);
```

