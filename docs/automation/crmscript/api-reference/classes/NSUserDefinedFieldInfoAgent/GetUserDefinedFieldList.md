---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_GetUserDefinedFieldList
title: NSUserDefinedFieldInfo[] GetUserDefinedFieldList(Integer ownerType)
intellisense: NSUserDefinedFieldInfoAgent.GetUserDefinedFieldList
keywords: NSUserDefinedFieldInfoAgent, GetUserDefinedFieldList
so.topic: reference
---

# NSUserDefinedFieldInfo[] GetUserDefinedFieldList(Integer ownerType)

Return information about all the user defined fields on a particular owner type (project, contact, person, etc). Note this may be different than the currently published fields.

**Parameters:**
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
Integer ownerType;
NSUserDefinedFieldInfo[] res = agent.GetUserDefinedFieldList(ownerType);
```

