---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_DetectColumnIdChanges
title: Bool DetectColumnIdChanges(Integer ownerType)
intellisense: NSUserDefinedFieldInfoAgent.DetectColumnIdChanges
keywords: NSUserDefinedFieldInfoAgent, DetectColumnIdChanges
so.topic: reference
---

Detect columnid changes to the admin version (for determining publish warning)

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

**Returns:** Bool

```crmscript
NSUserDefinedFieldInfoAgent agent;
Integer ownerType;
Bool res = agent.DetectColumnIdChanges(ownerType);
```

