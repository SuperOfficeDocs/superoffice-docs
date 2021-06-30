---
uid: crmscript_ref_NSSelectionAgent_CreateTemporaryContactSelectionFromContactPersonIds
title: SelectionEntity CreateTemporaryContactSelectionFromContactPersonIds(ContactPersonId[] contactPersonIds)
intellisense: NSSelectionAgent.CreateTemporaryContactSelectionFromContactPersonIds
keywords: NSSelectionAgent, CreateTemporaryContactSelectionFromContactPersonIds
so.topic: reference
---

Creates a temporary selection with members from a collection of ContactPerson id's.

**Parameters:**
 - **contactPersonIds** A collection of ContactPersonId to copy into the temporary contact selection as members.

**Returns:** Returns the newly created SelectionEntity.

```crmscript
NSSelectionAgent agent;
ContactPersonId[] contactPersonIds;
SelectionEntity res = agent.CreateTemporaryContactSelectionFromContactPersonIds(contactPersonIds);
```

