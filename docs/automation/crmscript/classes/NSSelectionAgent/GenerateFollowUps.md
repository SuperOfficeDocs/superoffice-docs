---
title: crmscript_ref_NSSelectionAgent_GenerateFollowUps_Integer_p_0_NSAppointmentEntity_p_1_Integer_p_2_Bool_p_3_Bool_p_4
description: NSSelectionAgent.GenerateFollowUps(Integer p_0, NSAppointmentEntity p_1, Integer p_2, Bool p_3, Bool p_4)
intellisense: NSSelectionAgent.GenerateFollowUps
keywords: GenerateFollowUps(Integer,NSAppointmentEntity,Integer,Bool,Bool)
so.topic: reference
---


Generate follow-ups for members in the selection.



* **selectionId:** The id of the selection to generate the follow-ups for.
* **appointmentEntity:** The AppointmentEntity with information about the appointment.
* **associateId:** The associate to save the appointments on. If saveOnContactOwner is true, this id will be ignored. Appointments wil be saved on current user if associateId = 0.
* **saveOnContactOwner:** If true, the appointments will be saved on contact owner (Our contact). This parameter will override associateId if true.
* **uniqueContact:** If true, only one appointment will be created for each contact.


