---
uid: crmscript_ref_NSReportEntity_SetReportLayout
title: SetReportLayout(Integer reportLayout)
intellisense: NSReportEntity.SetReportLayout
keywords: NSReportEntity, GetReportLayout
so.topic: reference
---

# SetReportLayout(Integer reportLayout)

The layout of the report.

**Parameter:** 
 - **reportLayout** Integer
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
Integer reportLayout;
thing.SetReportLayout(reportLayout);
```

