---
uid: crmscript_ref_NSAppointmentAgent_CreateAndAccept
title: Void CreateAndAccept(Integer emailItemId, Integer updateMode)
intellisense: NSAppointmentAgent.CreateAndAccept
keywords: NSAppointmentAgent, CreateAndAccept
so.topic: reference
---

# Void CreateAndAccept(Integer emailItemId, Integer updateMode)

Creating an appointment from an emailItem invitation and accepting it.

**Parameters:**
 - **emailItemId** The emailItemId
 - **updateMode** Update mode for a recurring appointment.
     - Enum: 0 = Unknown 
     - Enum: 1 = OnlyThis 
     - Enum: 2 = ThisAndForward 
     - Enum: 9 = StopRecurrence 
