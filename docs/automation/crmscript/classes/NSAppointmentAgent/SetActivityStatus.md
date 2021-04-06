---
uid: crmscript_ref_NSAppointmentAgent_SetActivityStatus
title: Void SetActivityStatus(StringArray activityIdentifier, Integer activityStatus)
intellisense: NSAppointmentAgent.SetActivityStatus
keywords: NSAppointmentAgent, SetActivityStatus
so.topic: reference
---

Sets the completed status for an array of activities. The string activityIdentifier param may contain of a mix of appointment_id, sale_id, document_id and todo_id. The changes are saved immediately. If an invalid id is passed in (nonexistent record), no changes will be made. If there is no write access to the record being changed, a Sentry exception will be thrown in the usual manner.

**Parameters:**
 - **activityIdentifier** Array of activity ids. ex. appointment_id=666
 - **activityStatus** The status to set the activities
     - Enum: 0 = Unknown 
     - Enum: 1 = NotStarted 
     - Enum: 2 = Started 
     - Enum: 3 = Completed 
