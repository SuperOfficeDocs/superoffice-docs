---
title: crmscript_ref_NSFavouriteAgent_ToggleFavourite
description: Bool ToggleFavourite(String tableName, Integer recordId, Integer associateId, String extraInfo)
intellisense: NSFavouriteAgent.ToggleFavourite
keywords: NSFavouriteAgent,ToggleFavourite
so.topic: reference
---

Toggle a record in a table as a favourite for an associate

**Parameters:**
 - **tableName** Table name, transformed to and from numeric table id by the service layer.
 - **recordId** 
 - **associateId** 
 - **extraInfo** 

**Returns:** Return the new value, true if added, false if removed

```crmscript
NSFavouriteAgent agent;
String tableName;
Integer recordId;
Integer associateId;
String extraInfo;
Bool res = agent.ToggleFavourite(tableName, recordId, associateId, extraInfo);
```

