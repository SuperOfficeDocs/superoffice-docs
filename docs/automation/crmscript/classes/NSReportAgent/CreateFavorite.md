---
uid: crmscript_ref_NSReportAgent_CreateFavorite
title: ReportEntity CreateFavorite(Integer sourceId, String name, String description)
intellisense: NSReportAgent.CreateFavorite
keywords: NSReportAgent, CreateFavorite
so.topic: reference
---

Creates the report as favorite. The sourceId is the key to the report that the favorite is based on.

**Parameters:**
 - **sourceId** The primary key to the report to make the favorite from.
 - **name** The name of the new favorite.
 - **description** The description of the new favorite.

**Returns:** The new favorite ReportEntity.

```crmscript
NSReportAgent agent;
Integer sourceId;
String name;
String description;
ReportEntity res = agent.CreateFavorite(sourceId, name, description);
```

