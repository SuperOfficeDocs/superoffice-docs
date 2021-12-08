---
title: Get value of user-defined field
uid: get_udef_field_value
description: How to get the value of a user-defined field in NetServer
author: Tony Yates
so.date: 11.05.2021
keywords: udef, user-defined field, custom field, API
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

## Examples

### Get all user-defined fields of an entity

The below example illustrates how we can retrieve the entire user-defined fields in the `contact` entity.

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;

using(SoSession mySession = SoSession.Authenticate("SAL0",""))
{
  //get the contact agent
  using(ContactAgent contactAgent = new ContactAgent())
  {
    //get a contact you want
    ContactEntity contactEntity = contactAgent.GetContactEntity(43);

    //get the full set of UserDefinedFields to a string dictionary
    StringDictionary userDefinedFields = contactEntity.UserDefinedFields;
  }
}
```

From the above example, we have retrieved the entire set of user-defined fields that have been defined for a contact. If you define a user-defined field for the contact it is common for all the contacts. The values for each user-defined field will differ from contact to contact.

### Get value of a user-defined field

Now the question remains how we retrieve a value of a user-defined field. For this SuperOffice has provided us with an agent called `UserDefinedFieldInfoAgent`. By using this agent we can retrieve the values of any user-defined field.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //get the contact agent
  using(ContactAgent contactAgent = new ContactAgent())
  {
    //get a contact you want
    ContactEntity contactEntity = contactAgent.GetContactEntity(43);

    //get the full set of UserDefinedFields to a string dictionary
    StringDictionary userDefinedFields = contactEntity.UserDefinedFields;

    //create a User Defined Field Info Agent
    using(UserDefinedFieldInfoAgent udefAgent = new UserDefinedFieldInfoAgent())
    {
      //retrieve the User Defined Field Info for the given label text
      UserDefinedFieldInfo udefInfo = udefAgent.GetUserDefinedFieldFromFieldLabel("companyshorttext", 7);

      //retrieve the value using the progid of the field
      string valUdef = userDefinedFields[udefInfo.ProgId.ToString()];
    }
  }
}
```

In the above example, we can see that we have used the label text in the UI to retrieve the user-defined field info. The first parameter is the label text and the second parameter is to specify where this user-defined field exists. For example, in the contact or project table. The number is defined by NetServer below is a list of numbers that we can use.

* Contact – 7
* Project – 8
* Person – 9
* Sale – 10
* Appointment – 12
* Document - 13

When we have the field info we can retrieve the `progid` and then we can retrieve the value using that.

> [!NOTE]
> Using the label text to retrieve the field info can be bit messy since it can have trailing spaces, leading spaces and commas etc… that you may not notice. NetServer helps us by ignoring the trailing spaces, commas, and some other characters when searching. It is advised that you give extreme care when specifying the label text.

<!-- ## Sample

Download the [sample application](TestDevNetUDF.zip), including all sources, and test it out for yourself. -->
