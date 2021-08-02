---
uid: crmscript_ref_NSSelectionAgent_GenerateFollowUps
title: Void GenerateFollowUps(Integer selectionId, NSAppointmentEntity appointmentEntity, Integer associateId, Bool saveOnContactOwner, Bool uniqueContact)
intellisense: NSSelectionAgent.GenerateFollowUps
keywords: NSSelectionAgent, GenerateFollowUps
so.topic: reference
---

Generate follow-ups for members in the selection.

**Parameters:**
 - **selectionId** The id of the selection to generate the follow-ups for.
 - **appointmentEntity** The NSAppointmentEntity with information about the appointment.
 - **associateId** The associate to save the appointments on. If saveOnContactOwner is true, this id will be ignored. Appointments wil be saved on current user if associateId = 0.
 - **saveOnContactOwner** If true, the appointments will be saved on contact owner (Our contact). This parameter will override associateId if true.
 - **uniqueContact** If true, only one appointment will be created for each contact.
