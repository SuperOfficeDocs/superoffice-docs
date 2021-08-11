---
uid: crmscript_ref_NSAssociateAgent_GetAssociateByPersonId
title: NSAssociate GetAssociateByPersonId(Integer personId)
intellisense: NSAssociateAgent.GetAssociateByPersonId
keywords: NSAssociateAgent, GetAssociateByPersonId
so.topic: reference
---

# NSAssociate GetAssociateByPersonId(Integer personId)

Returns the associate that belongs to this person if the person is an associate.

**Parameters:**
 - **personId** The person id

**Returns:** NSAssociate

```crmscript
NSAssociateAgent agent;
Integer personId;
NSAssociate res = agent.GetAssociateByPersonId(personId);
```

