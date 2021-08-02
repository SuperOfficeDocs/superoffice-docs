---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_CreateUserDefinedFieldInfo
title: NSUserDefinedFieldInfo CreateUserDefinedFieldInfo(Integer ownerType, Integer fieldType)
intellisense: NSUserDefinedFieldInfoAgent.CreateUserDefinedFieldInfo
keywords: NSUserDefinedFieldInfoAgent, CreateUserDefinedFieldInfo
so.topic: reference
---

Create a UserDefinedFieldInfo based on a owner-entity id

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
 - **fieldType** The field type of the new field
     - Enum: 1 = Number 
     - Enum: 2 = ShortText 
     - Enum: 3 = LongText 
     - Enum: 4 = Date 
     - Enum: 5 = UnlimitedDate 
     - Enum: 6 = Checkbox 
     - Enum: 7 = List 
     - Enum: 8 = Decimal 

**Returns:** NSUserDefinedFieldInfo

```crmscript
NSUserDefinedFieldInfoAgent agent;
Integer ownerType;
Integer fieldType;
NSUserDefinedFieldInfo res = agent.CreateUserDefinedFieldInfo(ownerType, fieldType);
```

