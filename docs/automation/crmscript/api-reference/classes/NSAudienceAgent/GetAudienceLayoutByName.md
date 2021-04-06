---
uid: crmscript_ref_NSAudienceAgent_GetAudienceLayoutByName
title: AudienceLayoutEntity GetAudienceLayoutByName(String layoutName)
intellisense: NSAudienceAgent.GetAudienceLayoutByName
keywords: NSAudienceAgent, GetAudienceLayoutByName
so.topic: reference
---

Gets an Audience layout by it's instance name

**Parameters:**
 - **layoutName** Name of the Audience layout instance

**Returns:** Audience layout entity

```crmscript
NSAudienceAgent agent;
String layoutName;
AudienceLayoutEntity res = agent.GetAudienceLayoutByName(layoutName);
```

