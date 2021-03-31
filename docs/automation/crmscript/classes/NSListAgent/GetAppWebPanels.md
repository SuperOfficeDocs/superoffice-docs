---
title: crmscript_ref_NSListAgent_GetAppWebPanels
description: WebPanelEntityArray GetAppWebPanels()
intellisense: NSListAgent.GetAppWebPanels
keywords: NSListAgent,GetAppWebPanels
so.topic: reference
---

Get all web panels owned by your app; works in Online only, for registered Apps that send a valid ApplicationToken


**Returns:** List of all web panels owned by the current App

```crmscript
NSListAgent agent;
WebPanelEntityArray res = agent.GetAppWebPanels();
```

