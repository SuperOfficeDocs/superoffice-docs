---
title: crmscript_ref_NSAppointmentAgent_GetNextSuggestedAppointmentBySale_Integer_p_0_Integer_p_1_Bool_p_2
description: NSAppointmentAgent.GetNextSuggestedAppointmentBySale(Integer p_0, Integer p_1, Bool p_2)
intellisense: NSAppointmentAgent.GetNextSuggestedAppointmentBySale
sortOrder: 897
keywords: GetNextSuggestedAppointmentBySale(Integer,Integer,Bool)
so.topic: reference
---


Gets the next suggested appointment for a given sale (or rather a given sale's guide).



* **saleId:** The identifier of the (guided) sale from which we want to find a suggested appointment
* **currentAppointmentId:** The identifier of the appointment from which we calculate the next suggestion. The next suggested appointment is the subsequent appointment defined in the SoAdmin's sales guide.
* **skipCompleteCheck:** If you want to get the next appointment step in a sales guide for an appointment which is not completed, this value must be true. In all other cases, this value should be false, as it would return the value of null if the current appointment is not completes.
* **Returns:** The next suggestion based on the sale id of a guided sale and the id of the current apopintment. If we cannot find a next suggestion or the sale is not guided (or if any of the paramters are invalid), we will return null.


