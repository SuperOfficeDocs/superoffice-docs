---
title: NSAppointmentEntity CreateDefaultAppointmentEntityFromSaleSuggestion(Integer suggestedAppointmentId, Integer saleId, Bool createNow, Integer p3)
path: /EJScript/Classes/NSAppointmentAgent/Member functions/NSAppointmentEntity CreateDefaultAppointmentEntityFromSaleSuggestion(Integer p_0, Integer p_1, Bool p_2, Integer p_3)
intellisense: 1
classref: 1
sortOrder: 878
keywords: CreateDefaultAppointmentEntityFromSaleSuggestion(Integer,Integer,Bool,Integer)
---


Creates an appointment based on a suggested appointment.



* **suggestedAppointmentId:** The id of the suggested appointment
* **saleId:** This is the id of the sale the appointment is connected to. This will be used to give the appointment it's starting date. If the id is 0 or invalid, we assume the start date is now
* **createNow:** If this parameter is true, we override the suggested start time and create the appointment with the current date and time
* **ownerId
* **Returns:**** The newly created appointment


