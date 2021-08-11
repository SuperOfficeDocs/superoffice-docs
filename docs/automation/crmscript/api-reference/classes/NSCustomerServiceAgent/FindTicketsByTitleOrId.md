---
uid: crmscript_ref_NSCustomerServiceAgent_FindTicketsByTitleOrId
title: NSTicketInfo[] FindTicketsByTitleOrId(String titleOrId, Integer maxRows)
intellisense: NSCustomerServiceAgent.FindTicketsByTitleOrId
keywords: NSCustomerServiceAgent, FindTicketsByTitleOrId
so.topic: reference
---

# NSTicketInfo[] FindTicketsByTitleOrId(String titleOrId, Integer maxRows)

This method wil search for tickets matching title or id

**Parameters:**
 - **titleOrId** The search string. If this is a number, it will also search for a matching ticket id
 - **maxRows** The maximum number of rows to be returned

**Returns:** NSTicketInfo[]

```crmscript
NSCustomerServiceAgent agent;
String titleOrId;
Integer maxRows;
NSTicketInfo[] res = agent.FindTicketsByTitleOrId(titleOrId, maxRows);
```

