---
uid: crmscript_ref_NSTimeZoneAgent_SetBaseTimeZoneId
title: Bool SetBaseTimeZoneId(Integer timezoneId)
intellisense: NSTimeZoneAgent.SetBaseTimeZoneId
keywords: NSTimeZoneAgent, SetBaseTimeZoneId
so.topic: reference
---

Set the base timezone id.

**Parameters:**
 - **timezoneId** The timezone id to save

**Returns:** Returns true if setting of base timezone was done

```crmscript
NSTimeZoneAgent agent;
Integer timezoneId;
Bool res = agent.SetBaseTimeZoneId(timezoneId);
```

