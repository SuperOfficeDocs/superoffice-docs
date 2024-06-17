---
uid: api-custom-objects-search
title: Custom Objects search
description: How to use Custom Objects to search for information
author: Eivind Fasting
so.date: 04.28.2024
keywords: custom objects, Search
so.topic: howto
---

# How to use Custom Objects to search for information

While the other sections shows examples on how to [Read][1], [Insert][2], [Update][3] and [Delete][4], this section will focus on how to search for companies with existing relations connected to them.

This example uses Companies as an example, but same logic applies for all entities inside SuperOffice.

## Get available fields for the Contact Archive

One of the first things to determine is 'What relations do companies have inside our SuperOffice database?'. The best way is to use the Archive `GetAvailableColumns` endpoint to get all the available columns, including relational columns, for the Contact.

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

## Practical Example

The following example searches two ExtraTables, y_rentals and y_equipment.

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
> Notice the `Restictions` parameter. The `contactExtra` fields can be used as restrictions, additional citeria, to search for customers that have rented a specific item.
>
> Make sure to adjust PageSize to be more suited for your use-case.
<!-- Referenced links -->
[1]: ./custom-objects-read-row.md
[2]: ./custom-objects-insert-row.md
[3]: ./custom-objects-update-row.md
[4]: ./custom-objects-delete-row.md