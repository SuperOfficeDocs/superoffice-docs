---
# Mandatory fields.
title: create_appointment_entity_in_entity       # (Required) Very important for SEO.
description: Create an Appointment entity through an entity  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: diary,entity
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Create an Appointment entity through an entity

Creating an appointment through an entity can be done in 2 different ways:

* If you create an entity called A and assign it to an entity called B, when saving B - entity A will be saved through `NestedPersistent`

* you can create an entity that is a property of another entity. Then when saving the main entity, the entity created as the property of it will be saved as well.

Both these would give the same results.

## Example 1

[!code-csharp[CS](includes/create-apt-entity-in-entity-1.cs)]

In the example above, we have created an appointment as explained in [this example][2]. The difference is that here we do not save the created appointment. Instead, we assign it to the `Appointments` property of the `Contact` instance created and then save the `Contact`:

[!code-csharp[CS](includes/create-apt-entity-in-entity-1.cs?range=28,31,34)]

## Example 2

Below is an example of how we may use the `AddNew` method available in the `Appointments` property of the `Contact` class to create a new appointment.

[!code-csharp[CS](includes/create-apt-entity-in-entity-2.cs)]

The difference between example 1 and example 2 is that here we have created an instance of the `Appointment` to be added to the `Appointments` collection and by indexing through the collection we have assigned the desired values for the specific appointment as shown below.

[!code-csharp[CS](includes/create-apt-entity-in-entity-2.cs?range=8,16,27)]

The `Appointment` created will be saved when saving the `Contact` entity with the use of its `Save` method.

> [!NOTE]
> When adding an appointment by indexing through the Appointment collection of any entity, you should take caution to identify and add to the newly created `Appointment`, without updating an earlier `Appointment`. For instance, in example 2 if there was an appointment already existing in `Appointment[0]` location when you assigned values to properties what actually would happen is an update instead of an insert since the values that already exist in the 0th location will be modified.

<!-- Referenced links -->
[1]: create-apt-entity.md
