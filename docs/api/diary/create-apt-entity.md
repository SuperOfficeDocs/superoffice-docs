---
# Mandatory fields.
title: create_appointment_entity       # (Required) Very important for SEO.
description: Create an appointment entity  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: diary,entity
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Create an Appointment entity

Using the `Appointment` [entity][1] exposed in the `SuperOffice.CRM.Entities` namespace is one of the easiest ways to create an appointment, as shown in the example below.

## Code

[!code-csharp[CS](includes/create-apt-entity.cs)]

## Walk-through

After a `SoSession` has been created, we proceed on to creating an appointment.

To create an appointment, it is required to create an instance of the `Appointment` entity using the `CreateNew` method exposed in the `Associate` class, after which the default values for the entity will be set using the `SetDefaultes` method like this:

[!code-csharp[CS](includes/create-apt-entity.cs?range=6,9)]

The next section of the code shows [how values are assigned to properties][2] exposed by the entity. Pay attention to how we assign the `Alarm` property:

[!code-csharp[CS](includes/create-apt-entity.cs?range=17-18)]

The `HasAlarm` property should be assigned **first** before the value for the `Alarm` property is assigned.

Once the required values to the properties of the `Appointment` entity have been added or assigned it could be saved with the `Save` method:

[!code-csharp[CS](includes/create-apt-entity.cs?range=28)]

<!-- Referenced links -->
[1]: ../entities/index.md
[2]: ../entities/create-entity.md
