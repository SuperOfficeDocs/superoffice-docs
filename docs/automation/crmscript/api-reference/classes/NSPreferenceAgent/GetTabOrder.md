---
uid: crmscript_ref_NSPreferenceAgent_GetTabOrder
title: TabOrder GetTabOrder(String tabName)
intellisense: NSPreferenceAgent.GetTabOrder
keywords: NSPreferenceAgent, GetTabOrder
so.topic: reference
---

Gets the tab order.

**Parameters:**
 - **tabName** Name of the tab control

**Returns:** Tab order. Array of strings. Each string represent a named tab.

```crmscript
NSPreferenceAgent agent;
String tabName;
TabOrder res = agent.GetTabOrder(tabName);
```

