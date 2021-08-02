---
uid: crmscript_ref_NSCustomerServiceAgent_ExecuteEventHandlers
title: NSEventData ExecuteEventHandlers(NSEventData eventData)
intellisense: NSCustomerServiceAgent.ExecuteEventHandlers
keywords: NSCustomerServiceAgent, ExecuteEventHandlers
so.topic: reference
---

This method will execute event handlers in CRMScript for a given event.

**Parameters:**
 - **eventData** The NSEventData instance sent to the event handler

**Returns:** NSEventData

```crmscript
NSCustomerServiceAgent agent;
NSEventData eventData;
NSEventData res = agent.ExecuteEventHandlers(eventData);
```

