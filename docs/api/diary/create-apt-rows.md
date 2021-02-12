---
# Mandatory fields.
title: create_appointment_rows       # (Required) Very important for SEO.
description: Create an appointment rows  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: diary,rows,collection
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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
