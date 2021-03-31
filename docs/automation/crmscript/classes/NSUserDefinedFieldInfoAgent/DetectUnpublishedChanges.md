---
title: crmscript_ref_NSUserDefinedFieldInfoAgent_DetectUnpublishedChanges
description: Bool DetectUnpublishedChanges(Integer ownerType)
intellisense: NSUserDefinedFieldInfoAgent.DetectUnpublishedChanges
keywords: NSUserDefinedFieldInfoAgent,DetectUnpublishedChanges
so.topic: reference
---

Detect changes to the admin version (unpublished)

**Parameters:**
 - **ownerType** The owner type
     - Enum: 0 = Invalid 
     - Enum: 7 = Contact 
     - Enum: 8 = Person 
     - Enum: 9 = Project 
     - Enum: 10 = Sale 
     - Enum: 11 = Temp 
     - Enum: 12 = Appointment 
     - Enum: 13 = Document 
     - Enum: 14 = None 

**Returns:** Returns true if any changes were found. This includes cosmetic changes.

```crmscript
NSUserDefinedFieldInfoAgent agent;
Integer ownerType;
Bool res = agent.DetectUnpublishedChanges(ownerType);
```

