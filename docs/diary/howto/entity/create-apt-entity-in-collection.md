---
title: Create an Appointment entity through an entity collection
uid: create_appointment_entity_in_collection
description: How to create an Appointment entity through an entity collection at the NetServer data layer.
author: Bergfrid Skaara Dias
so.date: 11.04.2021
keywords: diary, calendar, appointment, API, entity, collection, AppointmentCollectio
so.topic: howto
# so.envir:
# so.client:
---

# Create an Appointment entity through an entity collection

The `SuperOffice.CRM.Entities` namespace exposes [entity collections][1] such as `AppointmentCollection` and `PersonCollection`. It is therefore possible to create an `Appointment` entity and assign it to the collection and thereby saving the collection the Appointment entity will be saved.

The following example demonstrates the method of doing the above.

## Code

[!code-csharp[CS](includes/create-apt-entity-in-collection.cs)]

## Walk-through

After creating an instance of the `Appointment` entity and assigning the desired values the next step is to assign the created appointment to the collection.

First, we create an `AppointmentCollection` and then add the appointment to the collection using the `Add` method.

Once it has been added, the collection can be saved:

[!code-csharp[CS](includes/create-apt-entity-in-collection.cs?range=28,31-32)]

<!-- Referenced links -->
[1]: ../../../api/entities/collections.md
