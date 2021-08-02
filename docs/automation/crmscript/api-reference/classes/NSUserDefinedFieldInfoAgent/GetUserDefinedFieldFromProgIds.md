---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_GetUserDefinedFieldFromProgIds
title: NSUserDefinedFieldInfo[] GetUserDefinedFieldFromProgIds(String[] progIds, Integer ownerType)
intellisense: NSUserDefinedFieldInfoAgent.GetUserDefinedFieldFromProgIds
keywords: NSUserDefinedFieldInfoAgent, GetUserDefinedFieldFromProgIds
so.topic: reference
---

Return an given array user defined field identified by the owner and the prog-ids. The prog-id is used as the key in the entity carriers. Note this may be different than the currently published field layout.

**Parameters:**
 - **progIds** The prog.id is a hidden name that uniquely identifies the field. 
 - **ownerType** The user-defined field owner-entity id. 
     - Enum: 0 = Invalid 
     - Enum: 7 = Contact 
     - Enum: 8 = Person 
     - Enum: 9 = Project 
     - Enum: 10 = Sale 
     - Enum: 11 = Temp 
     - Enum: 12 = Appointment 
     - Enum: 13 = Document 
     - Enum: 14 = None 

**Returns:** NSUserDefinedFieldInfo[]

```crmscript
NSUserDefinedFieldInfoAgent agent;
String[] progIds;
Integer ownerType;
NSUserDefinedFieldInfo[] res = agent.GetUserDefinedFieldFromProgIds(progIds, ownerType);
```

