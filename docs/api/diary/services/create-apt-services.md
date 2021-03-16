---
# Mandatory fields.
title: create_appointment_services       # (Required) Very important for SEO.
description: Create an appointment using NetServer services  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords: diary,api-services
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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
