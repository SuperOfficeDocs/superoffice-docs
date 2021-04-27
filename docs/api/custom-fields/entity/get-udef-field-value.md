---
title: Get value of user-defined field
uid: get_udef_field_value
description: How to get the value of a user-defined field in NetServer
author: Tony Yates
so.date: 01.17.2007
keywords:
so.topic: howto
---

# How to get the value of a user-defined field in NetServer

Although NetServer is a vast and intricate API for accessing SuperOffice data, one of the greatest defeats in the version 2.5 API is the lack of support for user-defined fields (UDF support does exist in NetServer 3,0).

All that is required to gain access to any user-defined value for a given field name is a simple formula. The key to this formula is the column identity value. With the column identity, we can figure out the following key pieces of information:

* Table identity
* Field offset ( User-Defined Field Index, whether that is long01, string01, ...)

## Table identity

### [C#](#tab/csharp)

```csharp
int TableId = ColumnId >> 8;
```

### [VB.NET](#tab/vb)

```vbnet
TableId = System.Convert.ToInt32(Machine.Shift.Right, 8)
```

***

## Field offset

With both the column and table identity values, we can now easily get the column offset that will be needed to submit as a query to the database. We do this as follows:

```csharp
FieldOffset = ColumnId % (TableIdentity * 256)
```

## Get field value

Given the main entity table (such as Appointment or Contact) and the field label, how is the field value returned? Essentially this is a 3-step process.

1. Get the version number of the main entity table, from the `userpreference` table.
2. Get the column number of the field by using the version of the main entity table, the name of the main entity table, and the field label.
3. Get the table number from the column number, and get 2 `TableInfo` objects to use in a NetServer query.

    The 2 `TableInfo` objects represent the main entity table and the user-defined entity table. For example, if the user-defined field label is "MyField", and is an Appointment user-defined field, then the 2 `TableInfo` objects will be:
    * AppointmentTableInfo
    * UDAppntSmall or UDAppntLarge

Unfortunately, each one of these steps requires a database hit. The version number is in the `userpreference` table. The column number is in the `udfield` table, and the actual user-defined field value is returned from either the `udxxxsmal` or `udxxxlarge` table via a join with the main entity table.

Ultimately, once the fields are all determined dynamically, the SQL boils down to something similar to:

```sql
SELECT crm5.udappntsmall.string05
FROM crm5.udappntsmall INNER JOIN crm5.appointment ON
         crm5.udappntsmall.udappntsmall_id = crm5.appointment.userdef_id
WHERE (crm5.appointment.appointment_id = 482);
```

Remember that only the SELECT, FROM, and WHERE are a fixed frame. The field, join, and tables are determined dynamically.

<!-- ## Sample

Download the [sample application](TestDevNetUDF.zip), including all sources, and test it out for yourself. -->
