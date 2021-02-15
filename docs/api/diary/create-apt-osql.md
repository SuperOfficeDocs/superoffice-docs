---
# Mandatory fields.
title: create_appointment_osql       # (Required) Very important for SEO.
description: Create an appointment through OSQL  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: diary,osql
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Create an appointment through OSQL

[!include[import OSQL namespaces](../includes/using-osql.md)]

The following example shows how we could create an appointment using OSQL.

## Code

[!code-csharp[CS](includes/create-apt-osql.cs)]

## Walk-through

Since we are creating an appointment, we would need to create an instance of the `AppointmentTableInfo` with the use of the `TablesInfo` class's `GetAppointmentTableInfo()`:

[!code-csharp[CS](includes/create-apt-osql.cs?range=8)]

Next, we create an instance of the `Insert` class that can be used to update the `appointment` table. After the instance has been created, we would be able to use the instance to update the fields of the `appointment` table.

[!code-csharp[CS](includes/create-apt-osql.cs?range=11,14-15)]

Once the required fields have been added, a database connection will be made with the use of the `ConnectionFactory` and the values will be inserted into the database with the `ExecuteNonQuery` method.

> [!NOTE]
> In OSQL, there is no method that provides default values. It is necessary to insert values to all mandatory columns. If not a runtime exception will occur.
