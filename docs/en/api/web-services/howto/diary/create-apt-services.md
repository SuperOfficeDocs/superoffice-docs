---
uid: create-appointment-services
title: Create an appointment using services
description: Create an appointment using NetServer services
keywords: diary, calendar, appointment, API, web services
author: Bergfrid Skaara Dias
date: 03.18.2022
content_type: howto
redirect_from:
  - /en/diary/howto/services/create-apt-services
  - /en/api/netserver/web-services/howto/diary/create-apt-services
---

# Create an appointment using services

This example shows you how to create an appointment using [NetServer services][1]. The new appointment will be added to the diary of associate 103 by the logged-in user is SAL0.

## Code

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;

using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Create an appointment agent
  using(AppointmentAgent appointmentAgent = new AppointmentAgent())
  {
    //Create an appointment entity through the appointment agent
    AppointmentEntity myAppointment = appointmentAgent.CreateDefaultAppointmentEntityByTypeAndAssociate(SuperOffice.Data.TaskType.Appointment, 103);

    //Assign values to some of the properties of the appointment
    myAppointment.Location = "5th Floor,Seminar Room";
    myAppointment.AlarmLeadTime = TimeSpan.FromMinutes(10.00);
    myAppointment.StartDate = DateTime.Today.AddDays(5);
    myAppointment.EndDate = DateTime.Today.AddDays(5);
    myAppointment.HasAlarm = true;
    myAppointment.Description = "this is a new appointment";
    myAppointment.AlldayEvent = true;

    //Save the newly created appointment in the database
    appointmentAgent.SaveAppointmentEntity(myAppointment);
  }
}
```

## Walk-through

In the example, we create an `Appointment` using the [CreateDefaultAppointmentEntityByTypeAndAssociate][2] method exposed through the agent. The method requires 2 parameters:

* the type of the requested task
* the `AssociateID` - the ID for whom the appointment should be created

<!-- Referenced links -->
[1]: ../../index.md
[2]: ../../../reference/restful/agent/Appointment_Agent/v1AppointmentAgent_CreateDefaultAppointmentEntityByTypeAndAssociate.md
