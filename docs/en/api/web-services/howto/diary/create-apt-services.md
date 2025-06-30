---
uid: create-appointment-services
title: Create an appointment using services
description: Create an appointment using NetServer services
keywords: diary, calendar, appointment, API, web services
author: Bergfrid Skaara Dias
date: 03.18.2022
content_type: howto
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
[1]: ../../index.md
[2]: ../../../reference/restful/agent/Appointment_Agent/v1AppointmentAgent_CreateDefaultAppointmentEntityByTypeAndAssociate.md
