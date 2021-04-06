---
uid: crmscript_ref_NSCustomerServiceAgent_ExecuteEventHandlers
title: EventData ExecuteEventHandlers(EventData eventData)
intellisense: NSCustomerServiceAgent.ExecuteEventHandlers
keywords: NSCustomerServiceAgent, ExecuteEventHandlers
so.topic: reference
---

This method will execute event handlers in CRMScript for a given event.

**Parameters:**
 - **eventData** The EventData instance sent to the event handler

**Returns:** The EventData instance after event handler execution

```crmscript
NSCustomerServiceAgent agent;
EventData eventData;
EventData res = agent.ExecuteEventHandlers(eventData);
```

