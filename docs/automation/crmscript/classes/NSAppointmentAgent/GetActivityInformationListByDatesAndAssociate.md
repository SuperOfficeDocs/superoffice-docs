---
title: crmscript_ref_NSAppointmentAgent_GetActivityInformationListByDatesAndAssociate
description: ActivityInformationListItemArray GetActivityInformationListByDatesAndAssociate(DateTime startDate, DateTime endDate, Integer associateId)
intellisense: NSAppointmentAgent.GetActivityInformationListByDatesAndAssociate
keywords: NSAppointmentAgent,GetActivityInformationListByDatesAndAssociate
so.topic: reference
---

Get activity information for one or more days according to the given date interval. The time portion of the dates is ignored. Private appointments are counted, but may not be visible through tooltips or other more detailed services.

**Parameters:**
 - **startDate** Start date of interval. Time portion is ignored.
 - **endDate** End date of interval. Time portion is ignored.
 - **associateId** Associate id to identify the calendar to scan. If 0 is passed in, the currently authenticated associate is used instead.

**Returns:** Exactly one item per day of the given time span is returned. Days where nothing happens will have all values set to 0, but will still be in the returned array. Start end dates are treated as inclusive.

```crmscript
NSAppointmentAgent agent;
DateTime startDate;
DateTime endDate;
Integer associateId;
ActivityInformationListItemArray res = agent.GetActivityInformationListByDatesAndAssociate(startDate, endDate, associateId);
```

