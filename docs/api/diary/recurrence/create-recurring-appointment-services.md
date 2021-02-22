---
# Mandatory fields.
title: create_recurring_appointment_ws       # (Required) Very important for SEO.
description: How to create a recurring appointment using services # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords: diary,api-services
so.topic: howto           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to create a recurring appointment (services)

This demonstrates how to create recurring appointments using NetServer services.

In the following example, we will be creating an appointment at 2.00 P.M. tomorrow that will recur for the next 8 working days.

The following screenshot shows the resulting recurring appointment in the SuperOffice diary week-view.

![02][img1]

## Code

[!code-csharp[CS](includes/create-recurring-apt-services.cs)]

## Walk-through

In creating a recurring appointment, first, an appointment is created and then the recurrence information has to be set according to the requirement. In the above code, we have created an `AppointmentAgent`, which we then use to create a new `AppointmentEntity`. Next, the appointment text, contact, and duration are set.

The recurrence information is specified by creating a **recurrence pattern**. Here, we want the appointment to recur daily for 8 days starting from tomorrow. Thus the recurrence pattern is set to *Daily* and further specified as *EveryWorkday*. `RecurrencePattern` and `RecurrenceDailyPattern` are enumerations.

[!code-csharp[CS](includes/create-recurring-apt-services.cs?range=31-34)]

Because it should recur 8 working days, we cannot specify an end date directly. Instead, the number of recurrences is set to 8 and the recurrence end date is calculated based on the number of recurrences:

[!code-csharp[CS](includes/create-recurring-apt-services.cs?range=38-39)]

Next, the recurrence pattern is created using the `CalculateDays` method of the agent.  Finally, the recurrence information is assigned to the `AppointmentEntity` and the appointment is saved to the database.

[Get the source code (zip)][1]

<!-- Referenced links -->
[1]: media/CreateARecurringAppointment.zip

<!-- Referenced images -->
[img1]: media/image002.jpg
