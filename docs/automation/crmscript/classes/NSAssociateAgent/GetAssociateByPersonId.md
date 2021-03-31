---
title: crmscript_ref_NSAssociateAgent_GetAssociateByPersonId
description: Associate GetAssociateByPersonId(Integer personId)
intellisense: NSAssociateAgent.GetAssociateByPersonId
keywords: NSAssociateAgent,GetAssociateByPersonId
so.topic: reference
---

Returns the associate that belongs to this person if the person is an associate.

**Parameters:**
 - **personId** The person id

**Returns:** Associate if person is associate

```crmscript
NSAssociateAgent agent;
Integer personId;
Associate res = agent.GetAssociateByPersonId(personId);
```

