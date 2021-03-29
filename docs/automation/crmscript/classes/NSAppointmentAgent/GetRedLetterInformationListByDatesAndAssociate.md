---
title: crmscript_ref_NSAppointmentAgent_GetRedLetterInformationListByDatesAndAssociate_DateTime_p_0_DateTime_p_1_Integer_p_2
description: NSAppointmentAgent.GetRedLetterInformationListByDatesAndAssociate(DateTime p_0, DateTime p_1, Integer p_2)
intellisense: NSAppointmentAgent.GetRedLetterInformationListByDatesAndAssociate
sortOrder: 894
keywords: GetRedLetterInformationListByDatesAndAssociate(DateTime,DateTime,Integer)
so.topic: reference
---


Get detailed red letter day information (redletter summary + individual day texts) for one or more days according to the given date interval. The time portion of the dates is ignored.



* **startDate:** Start date of interval. Time portion is ignored.
* **endDate:** End date of interval. Time portion is ignored.
* **associateId:** Associate id to identify the calendar to scan. If 0 is passed in, the currently authenticated associate is used instead.
* **Returns:** Exactly one item per day of the given time span is returned. Days where nothing happens will have all values set to 0, but will still be in the returned array. Start end dates are treated as inclusive.


