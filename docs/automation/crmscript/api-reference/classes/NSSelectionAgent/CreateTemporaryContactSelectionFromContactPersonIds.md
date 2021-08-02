---
uid: crmscript_ref_NSSelectionAgent_CreateTemporaryContactSelectionFromContactPersonIds
title: NSSelectionEntity CreateTemporaryContactSelectionFromContactPersonIds(NSContactPersonId[] contactPersonIds)
intellisense: NSSelectionAgent.CreateTemporaryContactSelectionFromContactPersonIds
keywords: NSSelectionAgent, CreateTemporaryContactSelectionFromContactPersonIds
so.topic: reference
---

Creates a temporary selection with members from a collection of ContactPerson id's.

**Parameters:**
 - **contactPersonIds** A collection of ContactPersonId to copy into the temporary contact selection as members.

**Returns:** NSSelectionEntity

```crmscript
NSSelectionAgent agent;
NSContactPersonId[] contactPersonIds;
NSSelectionEntity res = agent.CreateTemporaryContactSelectionFromContactPersonIds(contactPersonIds);
```

