---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_SetPublishStartSystemEvent
title: Void SetPublishStartSystemEvent(Integer ownerType)
intellisense: NSUserDefinedFieldInfoAgent.SetPublishStartSystemEvent
keywords: NSUserDefinedFieldInfoAgent, SetPublishStartSystemEvent
so.topic: reference
---

Set the start flag for udef publishing. Must be called before PUBLISH, or PUBLISH will fail. Start flag is removed when publish process completes.

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
