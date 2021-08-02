---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_ChangeFieldType
title: NSUserDefinedFieldInfo ChangeFieldType(NSUserDefinedFieldInfo info, Integer fieldType, Bool isIndexed)
intellisense: NSUserDefinedFieldInfoAgent.ChangeFieldType
keywords: NSUserDefinedFieldInfoAgent, ChangeFieldType
so.topic: reference
---

Create a UserDefinedFieldInfo based on a owner-entity id

**Parameters:**
 - **info** The user-defined field info carrier to want to modify
 - **fieldType** The new field type you want
     - Enum: 1 = Number 
     - Enum: 2 = ShortText 
     - Enum: 3 = LongText 
     - Enum: 4 = Date 
     - Enum: 5 = UnlimitedDate 
     - Enum: 6 = Checkbox 
     - Enum: 7 = List 
     - Enum: 8 = Decimal 
 - **isIndexed** The new indexed status you want

**Returns:** NSUserDefinedFieldInfo

```crmscript
NSUserDefinedFieldInfoAgent agent;
NSUserDefinedFieldInfo info;
Integer fieldType;
Bool isIndexed;
NSUserDefinedFieldInfo res = agent.ChangeFieldType(info, fieldType, isIndexed);
```

