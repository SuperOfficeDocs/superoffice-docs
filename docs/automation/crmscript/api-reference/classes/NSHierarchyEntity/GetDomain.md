---
uid: crmscript_ref_NSHierarchyEntity_GetDomain
title: Integer GetDomain()
intellisense: NSHierarchyEntity.GetDomain
keywords: NSHierarchyEntity, GetDomain
so.topic: reference
---

# Integer GetDomain()

Domain seperating the different hierarchy

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = ExtraTables 
     - Enum: 2 = ScreenDefinitions 
     - Enum: 3 = Scripts 
     - Enum: 4 = Selections 
     - Enum: 5 = ExternalDocuments 
     - Enum: 6 = UserGroups 
     - Enum: 7 = ExternalDocumentRelatedToSpmMessage 
     - Enum: 8 = Dashboards 

```crmscript
NSHierarchyEntity thing;
Integer domain  = thing.GetDomain();
```

