---
title: How to create a recurring appointment (data layer)
uid: create_recurring_appointment_entity
description: How to create a recurring appointment using entities at the NetServer data layer.
author: Bergfrid Skaara Dias
so.date: 11.04.2021
keywords: diary, calendar, appointment, API, entity, AppointmentMatrix, RecurrencePattern, RecurrenceDailyPattern
so.topic: howto
# so.envir:
# so.client:
---

# How to create a recurring appointment (data layer)

This demonstrates the use of [AppointmentMatrix][1] to create [recurring appointments][2]. `SuperOffice.CRM.Entities.AppointmentMatrix` is a matrix holding information about repeating appointments and their participants.

In the following example, we will be creating an appointment at 2.00 P.M. tomorrow that will recur for the next 8 working days.

## Code

[!code-csharp[CS](includes/create-recurring-apt-entity.cs)]

## Walk-through

First, we have created the appointment that should recur, using the `CreateNew` method exposed in the `Appointment` entity. The appointment text is set next, followed by setting the contact, appointment type, and status for the appointment.

Next, we have created the appointment matrix passing the appointment to recur.

In creating recurring appointments the most important part is **setting the recurrence information**. This is done by creating a recurrence pattern. In this example, the pattern is as such the appointment should recur daily for 8 days starting from tomorrow. Thus the recurrence pattern is set to *Daily* and further specified as *EveryWorkday*. The `RecurrencePattern` and `RecurrenceDailyPattern` are enumerations.

Next, we have set the start and end dates for the repetition pattern. Using the `CalculateDays` method the days for the recurrence pattern are created.

Finally, the recurrence information is assigned to the matrix and the matrix is saved to the database.

<a href="../../../../assets/downloads/api/howtocreaterecurringappointment.zip" download>Get the source code (zip)</a>

<!-- Referenced links -->
[1]: appointment-matrix.md
[2]: ../../recurring-appointments.md

<!-- Referenced images -->
