---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_GetPublishedUserDefinedFieldFromFieldLabel
title: UserDefinedFieldInfo GetPublishedUserDefinedFieldFromFieldLabel(String fieldLabel, Integer ownerType)
intellisense: NSUserDefinedFieldInfoAgent.GetPublishedUserDefinedFieldFromFieldLabel
keywords: NSUserDefinedFieldInfoAgent, GetPublishedUserDefinedFieldFromFieldLabel
so.topic: reference
---

Return information about the given user defined field identified by the owner and the field label. Note that field labels are fuzzy. Leading and trailing spaces and punctuation are ignored.

**Parameters:**
 - **fieldLabel** The field label - the text label shown in the user interface. Trailing spaces and punctuation (":" and ".") are ignored when searching.
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
String fieldLabel;
Integer ownerType;
UserDefinedFieldInfo res = agent.GetPublishedUserDefinedFieldFromFieldLabel(fieldLabel, ownerType);
```

