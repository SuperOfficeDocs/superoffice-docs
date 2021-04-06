---
uid: crmscript_ref_NSListAgent_GetWebPanelByProgId
title: WebPanelEntity GetWebPanelByProgId(String progId)
intellisense: NSListAgent.GetWebPanelByProgId
keywords: NSListAgent, GetWebPanelByProgId
so.topic: reference
---

Get a web panel using the ProgId key that was specified when it was created

**Parameters:**
 - **progId** String key that can be used to uniquely retrieve the panel, set in the WebPanelEntity when saving

**Returns:** The Web panel information

```crmscript
NSListAgent agent;
String progId;
WebPanelEntity res = agent.GetWebPanelByProgId(progId);
```

