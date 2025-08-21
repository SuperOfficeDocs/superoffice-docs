---
uid: create-appointment-entity
title: Create an Appointment entity
description: How to create an appointment entity.
keywords: diary, calendar, appointment, API, entity, SuperOffice.CRM.Entities
author: Bergfrid Skaara Dias
date: 11.04.2021
content_type: howto
redirect_from:
  - /en/diary/howto/entity/create-apt-entity
  - /en/api/netserver/entities/howto/diary/create-apt-entity
---

# Create an Appointment entity

Using the `Appointment` [entity][1] exposed in the `SuperOffice.CRM.Entities` namespace is one of the easiest ways to create an appointment, as shown in the example below.

## Code

[!code-csharp[CS](includes/create-apt-entity.cs)]

## Walk-through

After an `SoSession` has been created, we proceed on to creating an appointment.

To create an appointment, it is required to create an instance of the `Appointment` entity using the `CreateNew` method exposed in the `Associate` class, after which the default values for the entity will be set using the `SetDefaults` method like this:

[!code-csharp[CS](includes/create-apt-entity.cs?range=6,9)]

The next section of the code shows [how values are assigned to properties][2] exposed by the entity. Pay attention to how we assign the `Alarm` property:

[!code-csharp[CS](includes/create-apt-entity.cs?range=17-18)]

The `HasAlarm` property should be assigned **first** before the value for the `Alarm` property is assigned.

Once the required values to the properties of the `Appointment` entity have been added or assigned it could be saved with the `Save` method:

[!code-csharp[CS](includes/create-apt-entity.cs?range=28)]

<!-- Referenced links -->
[1]: ../../index.md
[2]: ../../create-entity.md
