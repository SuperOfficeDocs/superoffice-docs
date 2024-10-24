---
uid: crmscript-update-appointment
title: How to update appointments
description: How to update, move, and delete appointments; mark an appointment as complete
keywords: CRMScript, calendar, diary, appointments, follow-up
author: Bergfrid Skaara Dias
date: 03.18.2022
version: 10
topic: howto
---

# Update appointment

<!-- markdownlint-disable-next-line MD013 -->
## NSAppointment UpdateAppointment(Integer p0, DateTime p1, DateTime p2, Integer p3, Integer p4, Integer associateId)

Change the description, for example, to add an agenda:

```crmscript
NSAppointmentAgent appointmentAgent;
NSAppointmentEntity appointment = appointmentAgent.GetAppointmentEntity(146);

appointment.SetDescription("Agenda: 1. Welcome 2. Annual report 3. Election 4. Misc");
appointmentAgent.SaveAppointmentEntity(appointment);
```

## Move appointment

Postpone an existing appointment by 1 week (reschedule):

```crmscript
NSAppointmentAgent appointmentAgent;

NSAppointmentEntity a = appointmentAgent.GetAppointmentEntity(146);

DateTime start = a.GetStartDate();
a.SetStartDate(start.addDay(7));

DateTime end = a.GetEndDate();
a.SetEndDate(end.addDay(7));

a = appointmentAgent.SaveAppointmentEntity(a);
```

## Mark as complete

*Completed* means that the status is **3**.

### Void SetCompleted(Integer Completed)

```crmscript
NSAppointmentAgent appointmentAgent;

NSAppointmentEntity a = appointmentAgent.GetAppointmentEntity(77);
a.SetCompleted(3);
appointmentAgent.SaveAppointmentEntity(a);
```

### Integer GetCompleted()

You can't edit completed follow-ups until you have undone their Completed status!

Use `GetCompleted()` to check the status. Toggle it to **0** to do your edits and then toggle it back if applicable.

```crmscript
NSAppointmentAgent appointmentAgent;

NSAppointmentEntity e = appointmentAgent.GetAppointmentEntity(77);

if (e.GetCompleted() == 3) {
  e.SetCompleted(0);
  appointmentAgent.SaveAppointmentEntity(e);
}
```

## Delete appointment

### Void DeleteAppointmentEntity(Integer appointmentEntityId)

```crmscript
NSAppointmentAgent appointmentAgent;
appointmentAgent.DeleteAppointmentEntity(142);
```

<!-- Referenced links -->
