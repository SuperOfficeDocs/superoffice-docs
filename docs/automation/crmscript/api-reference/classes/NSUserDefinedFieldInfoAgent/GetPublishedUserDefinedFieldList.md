---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_GetPublishedUserDefinedFieldList
title: NSUserDefinedFieldInfo[] GetPublishedUserDefinedFieldList(Integer ownerType)
intellisense: NSUserDefinedFieldInfoAgent.GetPublishedUserDefinedFieldList
keywords: NSUserDefinedFieldInfoAgent, GetPublishedUserDefinedFieldList
so.topic: reference
---

# NSUserDefinedFieldInfo[] GetPublishedUserDefinedFieldList(Integer ownerType)

Return information about all the user defined fields on a particular owner type (project, contact, person, etc).

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

**Returns:** RNSUserDefinedFieldInfo[]

```crmscript
NSUserDefinedFieldInfoAgent agent;
Integer ownerType;
NSUserDefinedFieldInfo[] res = agent.GetPublishedUserDefinedFieldList(ownerType);
```

