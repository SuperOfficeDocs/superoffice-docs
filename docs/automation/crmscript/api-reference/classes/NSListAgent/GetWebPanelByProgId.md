---
uid: crmscript_ref_NSListAgent_GetWebPanelByProgId
title: NSWebPanelEntity GetWebPanelByProgId(String progId)
intellisense: NSListAgent.GetWebPanelByProgId
keywords: NSListAgent, GetWebPanelByProgId
so.topic: reference
---

# NSWebPanelEntity GetWebPanelByProgId(String progId)

Get a web panel using the ProgId key that was specified when it was created

**Parameters:**
 - **progId** String key that can be used to uniquely retrieve the panel, set in the NSWebPanelEntity when saving

**Returns:** NSWebPanelEntity

```crmscript
NSListAgent agent;
String progId;
NSWebPanelEntity res = agent.GetWebPanelByProgId(progId);
```

