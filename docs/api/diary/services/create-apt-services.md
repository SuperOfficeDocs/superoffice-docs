---
title: Create an appointment using services
uid: create_appointment_services
description: Create an appointment using NetServer services
author: {github-id}
so.date: 06.24.2016
keywords: diary, api-services
so.topic: howto
# so.envir:
# so.client:
---

# Create an appointment using services

This example shows you how to create an appointment using NetServer services. The new appointment will be added to the diary of associate 103 by the logged-in user is SAL0.

## Code

[!code-csharp[CS](includes/create-apt-services.cs)]

## Walk-through

In the example, we create an `Appointment` using the `CreateDefaultAppointmentEntityByTypeAndAssociate` method exposed through the agent factory. The method requires 2 parameters:

* the type of the requested task
* the `AssociateID` - the ID for whom the appointment should be created

<!-- Referenced links -->
