---
uid: crmscript_ref_NSReportEntity_GetReportLayout
title: Integer GetReportLayout()
intellisense: NSReportEntity.GetReportLayout
keywords: NSReportEntity, GetReportLayout
so.topic: reference
---

The layout of the report.

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = List 
     - Enum: 2 = Label 
     - Enum: 3 = GroupList 
     - Enum: 4 = CrossTable 
     - Enum: 5 = CalendarWeek5 
     - Enum: 6 = CalendarWeek7 
     - Enum: 7 = CalendarMonth 
     - Enum: 8 = Text 

```crmscript
NSReportEntity thing;
Integer reportLayout  = thing.GetReportLayout();
```


