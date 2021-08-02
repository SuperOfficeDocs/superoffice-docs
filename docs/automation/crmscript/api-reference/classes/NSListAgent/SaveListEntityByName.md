---
uid: crmscript_ref_NSListAgent_SaveListEntityByName
title: NSListEntity SaveListEntityByName(String name, NSListEntity listEntity)
intellisense: NSListAgent.SaveListEntityByName
keywords: NSListAgent, SaveListEntityByName
so.topic: reference
---

Save a NSListEntity resolved by the provided name.

**Parameters:**
 - **name** The name of the list to save.
 - **listEntity** The NSListEntity to save.

**Returns:** NSListEntity

```crmscript
NSListAgent agent;
String name;
NSListEntity listEntity;
NSListEntity res = agent.SaveListEntityByName(name, listEntity);
```

