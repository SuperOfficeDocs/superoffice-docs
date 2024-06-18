---
uid: api-custom-objects-search
title: Custom objects search
description: How to use custom objects to search for information
author: Eivind Fasting
so.date: 04.28.2024
so.version: 10
keywords: custom object, search, DatabaseTable, TableRecord, extra table
so.topic: howto
so.audience: api
so.audience.tooltip: SuperOffice APIs and database
---

# How to use custom objects to search for information

While the other sections show examples of how to [Read][1], [Insert][2], [Update][3] and [Delete][4], this section focuses on how to search for companies with existing relations connected to them.

This example uses companies, but the same logic applies to all SuperOffice entities.

## Get available fields for the Contact Archive

One of the first things to determine is which relations companies have inside the SuperOffice database. The best way is to use the Archive `GetAvailableColumns` endpoint to get all the available columns, including relational columns, for the Contact.

```http!
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/Archive/GetAvailableColumns?$select=name HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json
{
  "ProviderName": "Contact",
  "Columns": ""
}
```

All ExtraTable relations in the result are shown as `contactExtra/{ExtraTableName}/{FieldName}`.

When relations exist between ExtraTables these will be shown as `contactExtra/y_rentals/x_contact_id/x_equipment/x_name`.

When known, perform the search using either the `GetArchiveListByColumns` or `GetArchiveListByColumns2` Archive methods.

## Example

The following example searches two extra tables, y_rentals and y_equipment.

`y_equipment` in this case contains different items we are renting out. `y_rentals` is the link-table between the available items and the companies, and functions as a registry of what items are rented out to which customer.

The follow query can be used to find out what items a specific customer has rented out:

```http!
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/Archive/GetArchiveListByColumns2
Accept: application/json
Content-Type: application/json
Authorization: Bearer {{token}}
{
  "Columns": "contactExtra/y_rentals/x_contact_id,contactExtra/y_rentals/x_contact_id/x_equipment/x_name",
  "ProviderName": "contact",
  "Page": 0,
  "PageSize": 1,
  "Entities": "contact",
  "SortOrder": "",
  "Restrictions": "contactId eq 4"
}
```

> [!NOTE]
> Notice the `Restrictions` parameter. The `contactExtra` fields can be used as restrictions, additional criteria, to search for customers that have rented a specific item.
>
> Make sure to adjust PageSize according to your use case.

<!-- Referenced links -->
[1]: rest-get-custom-object-row.md
[2]: rest-add-custom-object-row.md
[3]: rest-update-custom-object-row.md
[4]: rest-delete-custom-object-row.md
