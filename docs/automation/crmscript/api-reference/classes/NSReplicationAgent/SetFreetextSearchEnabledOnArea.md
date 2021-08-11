---
uid: crmscript_ref_NSReplicationAgent_SetFreetextSearchEnabledOnArea
title: Void SetFreetextSearchEnabledOnArea(Integer areaId, Bool freetextEnabled)
intellisense: NSReplicationAgent.SetFreetextSearchEnabledOnArea
keywords: NSReplicationAgent, SetFreetextSearchEnabledOnArea
so.topic: reference
---

# Void SetFreetextSearchEnabledOnArea(Integer areaId, Bool freetextEnabled)

Enable freetext search on this area

**Parameters:**
 - **areaId** The id of the area
 - **freetextEnabled** True if freetextSearch on this area shall be enabled

```crmscript
NSReplicationAgent agent;
Integer areaId;
Bool freetextEnabled;
agent.SetFreetextSearchEnabledOnArea(areaId, freetextEnabled);
```

