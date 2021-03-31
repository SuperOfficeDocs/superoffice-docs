---
title: crmscript_ref_NSRelationAgent_SaveContactRelation
description: ContactRelationEntity SaveContactRelation(ContactRelationEntity contactRelationEntity)
intellisense: NSRelationAgent.SaveContactRelation
keywords: NSRelationAgent,SaveContactRelation
so.topic: reference
---

Creates a new or updates an existing contact relation.

**Parameters:**
 - **contactRelationEntity** Relation to save

**Returns:** Saved relation

```crmscript
NSRelationAgent agent;
ContactRelationEntity contactRelationEntity;
ContactRelationEntity res = agent.SaveContactRelation(contactRelationEntity);
```

