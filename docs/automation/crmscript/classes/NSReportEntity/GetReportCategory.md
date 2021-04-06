---
uid: crmscript_ref_NSReportEntity_GetReportCategory
title: Integer GetReportCategory()
intellisense: NSReportEntity.GetReportCategory
keywords: NSReportEntity, GetReportCategory
so.topic: reference
---

The category of the report.

**Returns:** Integer

     - Enum: 0 = None 
     - Enum: 1 = All 
     - Enum: 2 = Contact 
     - Enum: 3 = Project 
     - Enum: 4 = Sale 
     - Enum: 5 = Appointment 
     - Enum: 6 = Selection 
     - Enum: 7 = Person 
     - Enum: 8 = Diary 
     - Enum: 9 = Favorites 

```crmscript
NSReportEntity thing;
Integer reportCategory  = thing.GetReportCategory();
```


