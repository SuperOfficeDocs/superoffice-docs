---
uid: create-appointment-row
title: Create an appointment row
description: How to create an appointment row.
keywords: diary, calendar, appointment, API, row, AppointmentRow
author: Bergfrid Skaara Dias
date: 11.04.2021
content_type: howto
redirect_from:
  - /en/diary/howto/row/create-apt-row
  - /en/api/netserver/rows/howto/diary/create-apt-row
---

# Create an appointment row

An [AppointmentRow][2] refers to a row in the [appointment database table][1]. Therefore, it consists of basic data types supported by SQL. To create an `AppointmentRow` we use the `SuperOffice.CRM.Rows` namespace.

The following example shows how we create an appointment using the `AppointmentRow` class.

## Code

[!code-csharp[CS](includes/create-apt-row.cs)]

## Walk-through

The first step of the example shows how to instantiate an `AppointmentRow` class and then the next step is to set the default values of it with the `SetDefaults` method.

[!code-csharp[CS](includes/create-apt-row.cs?range=6,9)]

The next statements show how the different properties of the `AppointmentRow` are assigned. Once such assignments are made, the row could be saved with the `Save` method available in the `AppointmentRow` class.

<!-- Referenced links -->
[1]: ../../../../database/tables/appointment.md
[2]: <xref:SuperOffice.CRM.Rows.AppointmentRow>
