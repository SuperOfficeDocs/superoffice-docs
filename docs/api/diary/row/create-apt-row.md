---
title: Create an appointment row
uid: create_appointment_row
description: Create an appointment row
author: {github-id}
so.date: 05.11.2016
keywords: diary, row
so.topic: howto
# so.envir:
# so.client:
---

# Create an appointment row

An `AppointmentRow` refers to a row in the `appointment` database table. Therefore, it consists of basic data types supported by SQL. To create an `AppointmentRow` we use the `SuperOffice.CRM.Rows` namespace.

The following example shows how we create an appointment using the `AppointmentRow` class.

## Code

[!code-csharp[CS](includes/create-apt-row.cs)]

## Walk-through

The first step of the example shows how to instantiate an `AppointmentRow` class and then the next step is to set the default values of it with the `SetDefaults` method.

[!code-csharp[CS](includes/create-apt-row.cs?range=6,9)]

The next statements show how the different properties of the `AppointmentRow` are assigned. Once such assignments are made, the row could be saved with `Save` method available in the `AppointmentRow` class.
