---
title: High-level database layer (Rows)
description: Rows are simple, straightforward persistence objects that represent one or more rows from a database table.
author: AnthonyYates
so.date: 11.16.2021
keywords: data access, row, rows, collection, HDB, DataTable, DataRow, SuperOffice.CRM.Rows, TableInfo, FieldInfo, GetFromIdx, CustomSearch
so.topic: concept
so.envir: cloud, onsite
so.client: win, web
---

# High-level database layer (Rows)

[NetServer exposes many layers][11] of its API to do the same functionality. Rows are simple, straightforward persistence objects that represent one or more rows from a database table. Each table in the database has a corresponding **Row object** and **Rows collection**. Rows can contain and expose properties of **basic data types only** (String, Double, Int, and so on).

HDB rows are very similar to that of ADO.NET DataTable and DataRow objects. The NetServer **DataTable** equivalent is a rows collection, such as PersonRows, whereas the **DataRow** equivalent is a single row object, such as PersonRow.

Unlike entity models, where an entity property may contain data fetched from other tables, Row types contain only **foreign key ID** values that point to the data details in another table.

For example, `Contact.Associate` corresponds to an `Associate` object with populated properties. In this case, the `ContactRow` associate property, which is called `AssociateId`, is an integer value that correlates to a row in the `associate` table where the `ContactRow.AssociateId` value equals the `associate_id` field value.

You can use row objects to read and update the database. Each row object supports queries and `Save` and `Delete` methods. All Rows are provided under the `SuperOffice.CRM.Rows` namespace.

## Code example

```csharp
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //retrieve the contact row that we want to change
  ContactRow theContact = ContactRow.GetFromIdxContactId(1234);

  //get the name
  String name = theContact.Name;

  //retrieve the address of the contact using the address type
  // and the contact ID
  AddressRow theAddressRow = AddressRow.GetFromIdxAtypeIdxOwnerId(
      SuperOffice.Data.AddressType.ContactPostalAddress, 1234);

  //change the address
  theAddressRow.City = "Oslo";

  //save the changed address row
  theAddressRow.Save();
}
```

The `AddressRow` will have the `owner_id` field set to 1234, and the `atypeidx` field set to 1 (postal address for contact).

## TableInfo and FieldInfo

Each row contains a `TableInfo` property. The **TableInfo type** is a schema type that contains all information for the schema of the table field layout.

The `TableInfo` property contains properties for:

* the table name and definition
* the database name
* a useful method to lookup fields by field name, called **FindField**

The `TableInfo` object is similar to an ADO.NET **DataTable.Columns** property, in that it exposes all of the columns as `FieldInfo` objects through the `TableInfo.All` property.

`TableInfo.All` returns an array of `FieldInfo` objects, one for each column in the table. For example, with the `PersonRow` object, the `PersonRow.TableInfo.All` property details all of the columns available in the `Person` table.

The result of running the following code would write out all 42 column names to the debug window. With each `FieldInfo` object, there are properties for the fields data type, the parent table, and many useful Argument methods, such as `Between`, `GreaterThan`, `LessThan`, and `Like`, to test the value of the field in the current row.

## Basic CRUD operations

To **create** a basic Row, you have to use the `CreateNew` method of the `Row` class (that you are going to create). Then you will want to populate its properties with data.

**Retrieving** data from a particular row of a table in the database can easily be done via Rows. Either by using the [Idx class](#idx-classes) or the [CustomSearch][2].

When data is retrieved through a Row, it is temporarily stored (**cashed**) in the instance. This instance can be used to make changes to the data, but the database is not affected until those changes are **updated** using the `Save()` method.

By using the `Delete()` method, we can delete a Row as well. In this case, it will **delete an entire row** from the database.

**How to:**

* [Get a row][3]
* [Create a row][5]
* [Update a row][7]
* [Delete a row][9]

### Idx classes

```csharp
//Accessing all columns of a PersonRow object
PersonRow person = new PersonRow.IdxPersonId(7);
FieldInfo [] fields = person.TableInfo.All;

foreach (FieldInfo fld in fields)
{
  Debug.WriteLine(fld.Name);
}
```

In contrast to the limited number of inner index fetcher classes for a single Row object, the Rows object expose many Idx fields to conduct useful queries.

![Code demonstrating available inner index classes of the PersonRows class -screenshot][img5]

Notice how easy it is to use the inner index classes as fetcher objects. The code demonstrates how to use the inner `IdxContactId` class to establish the criteria for the records returned in the result set. In this example, we see that passing in a value of 3 will limit the number of `PersonRow` objects in the `PersonRows` object to only the records in the database where the `contact_id` field is the value 3.

```csharp
//How the inner index class IdxContactId fetches a collection of PersonRow, PersonRows
PersonRows people = new PersonRows.IdxContactId(3);

foreach (PersonRow personRow in people)
{
  Debug.Assert(personRow.ContactId == 3);
}
```

As seen in Entities, each inner Idx fetcher class has a corresponding static helper method, `PersonRows.GetFromIdxName`.

## Working with Rows through Entities

An Entity may have properties that are of the type Row. A property of row type directly refers to a particular row of a table.

For example, in the `Sale` Entity, the `Associate` property would refer to the `Associate` table and would contain the columns that are in the `Associate` table as its properties.

**How to:**

* [Get a row through an entity][4]
* [Create a row through an entity][6]
* [Update a row through an entity][8]
* [Delete a row through an entity][10]

## More examples

* [Add list item using rows][1]

<!-- Referenced links -->
[1]: ../lists/row/add-list-item.md
[2]: customsearch.md
[3]: get-row.md
[4]: get-row-from-entity.md
[5]: create-row.md
[6]: create-row-in-entity.md
[7]: update-row.md
[8]: update-row-in-entity.md
[9]: delete-row.md
[10]: delete-row-from-entity.md
[11]: ../index.md

<!-- Referenced images -->
[img5]: media/personrowsobject.gif
