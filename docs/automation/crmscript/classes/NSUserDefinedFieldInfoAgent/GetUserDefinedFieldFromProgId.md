---
title: crmscript_ref_NSUserDefinedFieldInfoAgent_GetUserDefinedFieldFromProgId
description: UserDefinedFieldInfo GetUserDefinedFieldFromProgId(String progId, Integer ownerType)
intellisense: NSUserDefinedFieldInfoAgent.GetUserDefinedFieldFromProgId
keywords: NSUserDefinedFieldInfoAgent,GetUserDefinedFieldFromProgId
so.topic: reference
---

Return information about the given user defined field identified by the owner and the prog-id. The prog-id is used as the key in the entity carriers. Note this may be different than the currently published fields.

**Parameters:**
 - **progId** The prog.id is a hidden name that uniquely identifies the field. 
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

**Returns:** Returns the user-defined field info carrier, or null if no matching field is found.

```crmscript
NSUserDefinedFieldInfoAgent agent;
String progId;
Integer ownerType;
UserDefinedFieldInfo res = agent.GetUserDefinedFieldFromProgId(progId, ownerType);
```

