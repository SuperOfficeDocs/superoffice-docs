---
title: Create an Appointment entity through an entity collection
uid: create_appointment_entity_in_collection
description: Create an Appointment entity through an entity collection
author: {github-id}
so.date: 05.11.2016
keywords: diary,entity, collection
so.topic: howto
# so.envir:
# so.client:
---

# Create an Appointment entity through an entity collection

The `SuperOffice.CRM.Entities` namespace exposes entity collections such as `AppointmentCollection` and `PersonCollection`. It is therefore possible to create an `Appointment` entity and assign it to the collection and thereby saving the collection the Appointment entity will be saved.

The following example demonstrates the method of doing the above.

## Code

[!code-csharp[CS](includes/create-apt-entity-in-collection.cs)]

## Walk-through

After creating an instance of the `Appointment` entity and assigning the desired values the next step is to assign the created appointment to the collection.

First, we create an `AppointmentCollection` and then add the appointment to the collection using the `Add` method.

Once it has been added, the collection can be saved:

[!code-csharp[CS](includes/create-apt-entity-in-collection.cs?range=28,31-32)]
