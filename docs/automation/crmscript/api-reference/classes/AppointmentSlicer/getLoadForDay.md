---
uid: crmscript_ref_AppointmentSlicer_getLoadForDay_Date_day_Time_start_Time_stop_Integer_max
title: AppointmentSlicer.getLoadForDay(Date day, Time start, Time stop, Integer max)
intellisense: AppointmentSlicer.getLoadForDay
sortOrder: 110
keywords: getLoadForDay(Date,Time,Time,Integer)
so.topic: reference
---

This function will return the accumulated load for a given day. The load is calculated by adding all the appointments for that day, cutting them at the start and stop times. Finally, the value returned is never more than max (unless max is -1, in which case there is no limit).

The start and stop limits are useful because it can be used to eliminate private appointments in the evening.

The max is good, because one normally never works more than 8 hours pr. day :)



## Parameters


 - day: The day to get the load for
 - start: When to start calculating.
 - stop: When to stop calculating.
 - max: The maximum time returned.


Returns the calculated load for the given day


