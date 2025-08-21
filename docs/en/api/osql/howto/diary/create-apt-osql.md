---
uid: create-appointment-osql
title: Create an appointment through OSQL
description: How to create an appointment through OSQL.
keywords: diary, calendar, appointment, API, OSQL, AppointmentTableInfo
author: Bergfrid Skaara Dias
date: 03.02.2022
content_type: howto

redirect_from:
  - /en/diary/howto/osql/create-apt-osql
  - /en/api/netserver/osql/howto/diary/create-apt-osql
---

# Create an appointment through OSQL

[!include[import OSQL namespaces](../../../includes/using-osql.md)]

The following example shows how we could create an appointment using OSQL.

## Code

[!code-csharp[CS](includes/create-apt-osql.cs)]

## Walk-through

Since we are creating an appointment, we would need to create an instance of the [AppointmentTableInfo][3] with the use of the `TablesInfo` class's [GetAppointmentTableInfo()][2]:

[!code-csharp[CS](includes/create-apt-osql.cs?range=8)]

Next, we create an instance of the `Insert` class that can be used to update the [appointment table][1]. After the instance has been created, we would be able to use the instance to update the fields of the `appointment` table.

[!code-csharp[CS](includes/create-apt-osql.cs?range=11,14-15)]

Once the required fields have been added, a database connection will be made with the use of the `ConnectionFactory` and the values will be inserted into the database with the `ExecuteNonQuery` method.

> [!NOTE]
> In OSQL, there is no method that provides default values. It is necessary to insert values to all mandatory columns. If not a runtime exception will occur.

<!-- Referenced links -->
[1]: ../../../../database/tables/appointment.md
[2]: <xref:SuperOffice.Data.TablesInfo.GetAppointmentTableInfo>
[3]: <xref:SuperOffice.CRM.Data.AppointmentTableInfo>

<!-- Referenced images -->
