---
uid: create-appointment-rows
title: Create an appointment through row collection (Rows)
description: How to create an appointment through row collection (Rows).
keywords: diary, calendar, appointment, API, rows, collection, AppointmentRows
author: Bergfrid Skaara Dias
date: 11.04.2021
content_type: howto
redirect_from:
  - /en/diary/howto/row/create-apt-rows
  - /en/api/netserver/rows/howto/diary/create-apt-rows
---

# Create an appointment through row collection (Rows)

`Rows` type consists of a collection of rows such as `AppointmentRows` type consists of a collection of [AppointmentRow][3] types.

Therefore, it is possible to create an `AppointmentRow` with the `AppointmentRows` class.

## Code

[!code-csharp[CS](includes/create-apt-rows.cs)]

## Walk-through

An `AppointmentRow` can be created like in [this example][1].

The next phase of the code segment is to instantiate an `AppointmentRows` class. The instance can then be added to the collection with the execution of the `Add` method.

[!code-csharp[CS](includes/create-apt-rows.cs?range=20,23,26)]

Once the `AppointmentRow` is added the collection could be saved by executing the `Save` method, which ensures that the created entity is added to the [appointment table][2] in the database.

<!-- Referenced links -->
[1]: create-apt-row.md
[2]: ../../../../database/tables/appointment.md
[3]: <xref:SuperOffice.CRM.Rows.AppointmentRow>
