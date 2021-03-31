---
uid: crmscript_ref_NSCustomerServiceAgent_FindTicketsByTitleOrId
title: TicketInfoArray FindTicketsByTitleOrId(String titleOrId, Integer maxRows)
intellisense: NSCustomerServiceAgent.FindTicketsByTitleOrId
keywords: NSCustomerServiceAgent, FindTicketsByTitleOrId
so.topic: reference
---

This method wil search for tickets matching title or id

**Parameters:**
 - **titleOrId** The search string. If this is a number, it will also search for a matching ticket id
 - **maxRows** The maximum number of rows to be returned

**Returns:** An array of objects containing some meta data for matching tickets

```crmscript
NSCustomerServiceAgent agent;
String titleOrId;
Integer maxRows;
TicketInfoArray res = agent.FindTicketsByTitleOrId(titleOrId, maxRows);
```

