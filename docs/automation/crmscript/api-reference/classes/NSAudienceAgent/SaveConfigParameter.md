---
uid: crmscript_ref_NSAudienceAgent_SaveConfigParameter
title: NSAudienceConfigParameter SaveConfigParameter(String layoutName, NSAudienceConfigParameter configParameter)
intellisense: NSAudienceAgent.SaveConfigParameter
keywords: NSAudienceAgent, SaveConfigParameter
so.topic: reference
---

Saves an Audience configuration parameter belonging to a Audience layout

**Parameters:**
 - **layoutName** Name of the Audience layout instance
 - **configParameter** The Audience configuration parameter to save.

**Returns:** The new or updated configuration parameter

```crmscript
NSAudienceAgent agent;
String layoutName;
NSAudienceConfigParameter configParameter;
NSAudienceConfigParameter res = agent.SaveConfigParameter(layoutName, configParameter);
```

