---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_Publish
title: Integer Publish(Integer ownerType)
intellisense: NSUserDefinedFieldInfoAgent.Publish
keywords: NSUserDefinedFieldInfoAgent, Publish
so.topic: reference
---

# Integer Publish(Integer ownerType)

Publish changed Udef fields for the given owner type

**Parameters:**
 - **ownerType** The owner type to publish for
     - Enum: 0 = Invalid 
     - Enum: 7 = Contact 
     - Enum: 8 = Person 
     - Enum: 9 = Project 
     - Enum: 10 = Sale 
     - Enum: 11 = Temp 
     - Enum: 12 = Appointment 
     - Enum: 13 = Document 
     - Enum: 14 = None 

**Returns:** Integer

```crmscript
NSUserDefinedFieldInfoAgent agent;
Integer ownerType;
Integer res = agent.Publish(ownerType);
```

