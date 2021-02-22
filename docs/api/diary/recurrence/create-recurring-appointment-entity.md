---
# Mandatory fields.
title: create_recurring_appointment_entity       # (Required) Very important for SEO.
description: How to create a recurring appointment using entities # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: diary,entity
so.topic: howto           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to create a recurring appointment (data layer)

This demonstrates the use of `AppointmentMatrix` to create recurring appointments. `SuperOffice.CRM.Entities.AppointmentMatrix` is a matrix holding information about repeating appointments and their participants.

In the following example, we will be creating an appointment at 2.00 P.M. tomorrow that will recur for the next 8 working days.

The following screenshot shows the resulting recurring appointment in the SuperOffice diary week-view.

![01][img1]

## Code

[!code-csharp[CS](includes/create-recurring-apt-entity.cs)]

## Walk-through

First, we have created the appointment that should recur, using the `CreateNew` method exposed in the `Appointment` entity. The appointment text is set next, followed by setting the contact, appointment type, and status for the appointment.

Next, we have created the appointment matrix passing the appointment to recur.

In creating recurring appointments the most important part is **setting the recurrence information**. This is done by creating a recurrence pattern. In this example, the pattern is as such the appointment should recur daily for 8 days starting from tomorrow. Thus the recurrence pattern is set to *Daily* and further specified as *EveryWorkday*. The `RecurrencePattern` and `RecurrenceDailyPattern` are enumerations.

Next, we have set the start and end dates for the repetition pattern. Using the `CalculateDays` method the days for the recurrence pattern are created.

Finally, the recurrence information is assigned to the matrix and the matrix is saved to the database.

[Get the source code (zip)][1]

<!-- Referenced links -->
[1]: media/HowToCreateRecurringAppointment.zip

<!-- Referenced images -->
[img1]: media/image001.jpg
