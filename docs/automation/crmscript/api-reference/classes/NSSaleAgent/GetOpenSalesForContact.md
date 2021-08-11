---
uid: crmscript_ref_NSSaleAgent_GetOpenSalesForContact
title: NSSale[] GetOpenSalesForContact(Integer contactId)
intellisense: NSSaleAgent.GetOpenSalesForContact
keywords: NSSaleAgent, GetOpenSalesForContact
so.topic: reference
---

# NSSale[] GetOpenSalesForContact(Integer contactId)

Returns all open sales for the contact provided.

**Parameters:**
 - **contactId** The ID of the contact whose sales we want.

**Returns:** NSSale[]

```crmscript
NSSaleAgent agent;
Integer contactId;
NSSale[] res = agent.GetOpenSalesForContact(contactId);
```

