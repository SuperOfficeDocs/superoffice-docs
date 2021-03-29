---
title: crmscript_ref_NSAppointmentAgent_CreateDefaultAppointmentEntityFromSaleSuggestion_Integer_p_0_Integer_p_1_Bool_p_2_Integer_p_3
description: NSAppointmentAgent.CreateDefaultAppointmentEntityFromSaleSuggestion(Integer p_0, Integer p_1, Bool p_2, Integer p_3)
intellisense: NSAppointmentAgent.CreateDefaultAppointmentEntityFromSaleSuggestion
sortOrder: 878
keywords: CreateDefaultAppointmentEntityFromSaleSuggestion(Integer,Integer,Bool,Integer)
so.topic: reference
---


Creates an appointment based on a suggested appointment.



* **suggestedAppointmentId:** The id of the suggested appointment
* **saleId:** This is the id of the sale the appointment is connected to. This will be used to give the appointment it's starting date. If the id is 0 or invalid, we assume the start date is now
* **createNow:** If this parameter is true, we override the suggested start time and create the appointment with the current date and time
* **ownerId
* **Returns:**** The newly created appointment


