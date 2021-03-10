---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: ns_udef_lookup_class       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: The definitive NetServer user-defined field lookup class # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates
so.date: 01.17.2007
keywords:
so.topic: article             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# The definitive NetServer user-defined field lookup class

Although NetServer is a vast and intricate API for accessing SuperOffice data, one of the greatest defeats in the version 2.5 API is the lack of support for user-defined fields (UDF support does exist in NetServer 3,0). Before getting into the nitty-gritty details, lets take a look at a couple basic concepts first.

## SuperOffice user-defined field concepts

### Table Identity

Every table can be identified by an integer value. For example:

* company = 1
* associate = 2
* associategrouplink = 3
* associateheadinglink = 4
* contact = 5
* ...
* licencesatllink = 239
* productversion = 240

### Column Identity

Every column in a table is identified by an integer value. That value is derived by the following computation:

* Column Identity = Table Identity \* 256 + Column Offset

What is column offset? Column offset is the sequential place of the column in the table. This is zero-based number. For example:

**This is a visual representation of a Table:**

| Column One | Column Two | Column Three |
|-|-|-|
| Column Offset 0 | Column Offset 1 | Column Offset 2 |

Given this information, we can determine that the column identity values for the contact table are are follows:  

**Contact Table: ID = 5 (first three columns):**

| contact\_id | name | kananame |
|-|-|-|
|1280<br>(Column ID = Table ID \* 256 + offset) | 1281 | 1282 |

## How to get the value of a user-defined field in NetServer

With the understanding of the above information, all that is required to gain access to any user-defined value for a given field name (Field Label specified in the Admin App) is a simple formula. The key to this formula is the column identity value. With the column identity, we can figure out the following key pieces of information:

* Table Identity
* Field Offset ( User-Defined Field Index, whether that is long01, string01, ...)

### Table Identity

**C# :**

```csharp
int TableId = ColumnId >> 8;
```

**VB.NET:**

```vbnet
TableId = System.Convert.ToInt32(Machine.Shift.Right, 8)
```

### Field Offset

With both the column and table identity values, we can now easily get the column offset that will be needed to submit as a query to the database. We do this as follows:

```csharp
FieldOffset = ColumnId % (TableIdentity * 256)
```

### Steps

Given the main entity table (such as Appointment or Contact) and the field label, how is the field value returned? Essentially this is a 3-step process.  

1. Get the version number of the main entity table, from the `userpreference` table.
2. Get the column number of the field by using the version of the main entity table, the name of the main entity table, and the field label.
3. Get the table number from the column number, and get two TableInfo objects to use in a NetServer query.  

    The two TableInfo objects represent the main entity table and the user-defined entity table. For example, if the user-defined field label is "MyField", and is an Appointment user-defined field, then the two TableInfo objects will be:
    * AppointmentTableInfo  
    * UDAppntSmall or UDAppntLarge

Unfortunately each one of these steps requires a database hit. The version number is in the `userpreference` table. The column number is in the `udfield` table, and the actual user-defined field value is returned from either the `udxxxsmal` or `udxxxlarge` table via a join with the main entity table.

Ultimately, once the fields are all determined dynamically, the SQL boils down to something similar to:

```sql
SELECT crm5.udappntsmall.string05
FROM crm5.udappntsmall INNER JOIN crm5.appointment ON
         crm5.udappntsmall.udappntsmall_id = crm5.appointment.userdef_id
WHERE (crm5.appointment.appointment_id = 482);
```

Remember that only the SELECT, FROM, and WHERE are a fixed frame. The field, join, and tables are determined dynamically.

## Sample

Download the [sample application][1], including all sources, and test it out for yourself.

### How to use the UDFHelper class

This code demonstrates how to use `UDFHelper`. The next section contains a class called `UDFHelper` that can be used to retrieve the value of all user-defined fields.

[!code-csharp[example 1](includes/how-to-use-udefhelper.cs)]

### Complete UDFHelper Class and UDFInfo struct source

[!code-csharp[UDFHelper Class and UDFInfo struct](includes/class-udefhelper.cs)]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/content/content/netserver-sdk/archived-articles/the-definitive-netserver-user-defined-field-lookup-class/%7BEPsUploadDir%7D993/TestDevNetUDF.zip
