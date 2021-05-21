---
title: How to create a recurring appointment (services)
uid: create_recurring_appointment_ws
description: How to create a recurring appointment using services
author: {github-id}
so.date: 06.24.2016
keywords: diary, api-services
so.topic: howto
# so.envir:
# so.client:
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

<a href="../../assets/downloads/createarecurringappointment.zip" download>Get the source code (zip)</a>

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/image002.jpg
