---
title: Create an appointment using services
uid: create_appointment_services
description: Create an appointment using NetServer services
author: Bergfrid Skaara Dias
so.date: 03.18.2022
keywords: diary, calendar, appointment, API, web services
so.topic: howto
# so.envir:
# so.client:
---

# Create an appointment using services

This example shows you how to create an appointment using [NetServer services][1]. The new appointment will be added to the diary of associate 103 by the logged-in user is SAL0.

## Code

[!code-csharp[CS](includes/create-apt-services.cs)]

## Walk-through

In the example, we create an `Appointment` using the [CreateDefaultAppointmentEntityByTypeAndAssociate][2] method exposed through the agent. The method requires 2 parameters:

* the type of the requested task
* the `AssociateID` - the ID for whom the appointment should be created

<!-- Referenced links -->
[1]: ../../../api/web-services/index.md
[2]: ../../../api/reference/restful/agent/Appointment_Agent/v1AppointmentAgent_CreateDefaultAppointmentEntityByTypeAndAssociate.md
