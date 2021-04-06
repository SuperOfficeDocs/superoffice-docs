---
uid: crmscript_ref_AppointmentSlicer
title: AppointmentSlicer
intellisense: Void.AppointmentSlicer
sortOrder: 106
so.topic: reference
---

This class is used to slice appointments into single entities which are within a single day. This class is essential when having calender data (with entries possibly spanning several days), which you would like to display in the calender control (which only accepts data for single days).



###Example code:###


    AppointmentSlicer a;
    
    a.addAppointment(1, DateTime(2017, 4, 23, 8, 0, 0), DateTime(2017, 4, 23, 10, 30, 0), "Meeting");
    print(a.next().toString()); // Prints true if there is a preseding appointment the same day




1. autolist

