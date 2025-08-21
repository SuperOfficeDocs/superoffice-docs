---
uid: create-appointment-entity-in-collection
title: Create an Appointment entity through an entity collection
description: How to create an Appointment entity through an entity collection at the NetServer data layer.
keywords: diary, calendar, appointment, API, entity, collection, AppointmentCollection
author: Bergfrid Skaara Dias
date: 11.04.2021
content_type: howto
redirect_from:
  - /en/diary/howto/entity/create-apt-entity-in-collection
  - /en/api/netserver/entities/howto/diary/create-apt-entity-in-collection
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
[1]: ../../collections.md
