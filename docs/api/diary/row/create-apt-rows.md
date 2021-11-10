---
title: Create an appointment through row collection (Rows)
uid: create_appointment_rows
description: How to create an appointment through row collection (Rows).
author: Bergfrid Skaara Dias
so.date: 11.04.2021
keywords: diary, calendar, appointment, API, rows, collection, AppointmentRows
so.topic: howto
# so.envir:
# so.client:
---

# Create an appointment through row collection (Rows)

`Rows` type consists of a collection of rows such as `AppointmentRows` type consists of a collection of `AppointmentRow` types.

Therefore, it is possible to create an `AppointmentRow` with the `AppointmentRows` class.

## Code

[!code-csharp[CS](includes/create-apt-rows.cs)]

## Walk-through

An `AppointmentRow` can be created like in [this example][1].

The next phase of the code segment is to instantiate an `AppointmentRows` class. The instance can then be added to the collection with the execution of the `Add` method.

[!code-csharp[CS](includes/create-apt-rows.cs?range=20,23,26)]

Once the `AppointmentRow` is added the collection could be saved by executing the `Save` method, which ensures that the created entity is added to the `appointment` table in the database.

<!-- Referenced links -->
[1]: create-apt-row.md
