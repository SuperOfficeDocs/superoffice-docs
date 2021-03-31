---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_GetPublishedUserDefinedFieldList
title: UserDefinedFieldInfoArray GetPublishedUserDefinedFieldList(Integer ownerType)
intellisense: NSUserDefinedFieldInfoAgent.GetPublishedUserDefinedFieldList
keywords: NSUserDefinedFieldInfoAgent, GetPublishedUserDefinedFieldList
so.topic: reference
---

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

**Returns:** Returns an array of user-defined field info carriers. 

```crmscript
NSUserDefinedFieldInfoAgent agent;
Integer ownerType;
UserDefinedFieldInfoArray res = agent.GetPublishedUserDefinedFieldList(ownerType);
```

