---
title: crmscript_ref_NSReplicationAgent_SetFreetextSearchEnabledOnArea
description: Void SetFreetextSearchEnabledOnArea(Integer areaId, Bool freetextEnabled)
intellisense: NSReplicationAgent.SetFreetextSearchEnabledOnArea
keywords: NSReplicationAgent,SetFreetextSearchEnabledOnArea
so.topic: reference
---

Enable freetext search on this area

**Parameters:**
 - **areaId** The id of the area
 - **freetextEnabled** True if freetextSearch on this area shall be enabled

**Returns:** No return value

```crmscript
NSReplicationAgent agent;
Integer areaId;
Bool freetextEnabled;
Void res = agent.SetFreetextSearchEnabledOnArea(areaId, freetextEnabled);
```

