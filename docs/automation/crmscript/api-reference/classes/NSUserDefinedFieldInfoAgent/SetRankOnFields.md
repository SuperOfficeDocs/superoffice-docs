---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_SetRankOnFields
title: Void SetRankOnFields(Integer ownerType, Integer[] rankedFieldsIds)
intellisense: NSUserDefinedFieldInfoAgent.SetRankOnFields
keywords: NSUserDefinedFieldInfoAgent, SetRankOnFields
so.topic: reference
---

# Void SetRankOnFields(Integer ownerType, Integer[] rankedFieldsIds)

Change rank of user defined fields

**Parameters:**
 - **ownerType** The user-defined field owner-entity.
     - Enum: 0 = Invalid 
     - Enum: 7 = Contact 
     - Enum: 8 = Person 
     - Enum: 9 = Project 
     - Enum: 10 = Sale 
     - Enum: 11 = Temp 
     - Enum: 12 = Appointment 
     - Enum: 13 = Document 
     - Enum: 14 = None 
 - **rankedFieldsIds** All IDs of this owner-entity in desired rank order
