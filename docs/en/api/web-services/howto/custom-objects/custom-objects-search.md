---
uid: api-custom-objects-search
title: Custom objects search
description: How to use custom objects to search for information
author: Eivind Fasting
date: 04.28.2024
version: 10
keywords: custom object, search, DatabaseTable, TableRecord, extra table
topic: howto
audience: api
audience_tooltip: SuperOffice APIs and database
---

# How to use custom objects to search for information

While the other sections show examples of how to [Read][1], [Insert][2], [Update][3] and [Delete][4], this section focuses on how to search for companies with existing relations connected to them.

The first example uses the [Contact Archive][12], while the other uses the [CustomObjectDynamicSelectionV2][11] and [Dynamic Archive][6] to fetch information from ExtraTables.

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

### Example

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

## Get available fields for the CustomObjectDynamicSelectionV2 Archive

The `GetAvailableColumns` Archive can also be used to get all the available columns, include relational columns, for an ExtraTable.

```http!
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/Archive/GetAvailableColumns?$select=name HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json

{
  "ProviderName": "CustomObjectDynamicSelectionV2:y_rentals",
  "Columns": ""
}
```

## Using the dynamic archive provider to search for ExtraTable information

By using the [Dynamic Archive][5] it's possible to search for data directly from the ExtraTables. The below example has an ExtraTable y_log, and builds up an [OData query][6] to select the fields and filter the request by the x_ticket field.

```http!
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/archive/dynamic?$select=y_log.id,y_log.x_ticket&$filter=y_log.x_ticket eq 1 HTTP/1.1
Authorization: Bearer {{access_token}}
Accept: application/json
```

This example can also be expanded by including JOINS to another ExtraTable, y_log_message. The sample below uses [RIGHT JOIN][7]

```http!
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/archive/dynamic?$select=y_log.id,y_log.x_ticket,y_log.(y_log_message->x_log).id,y_log.(y_log_message->x_log).x_message&$filter=y_log.(y_log_message->x_log).id eq 1 HTTP/1.1
Authorization: Bearer {{access_token}}
Accept: application/json
```

Using the Dynamic Archive can be seen as an preferred alternative to using the [SearchEngine][9] in [CRMScripts][10], which historically have been used to search for information with the dot syntax.

> [!NOTE]
>This is an efficient way of searching for data in ExtraTables, but should NOT be used where it already exists an Archive provider for the same information, for instance the [Contact Archive][8].

<!-- Referenced links -->
[1]: rest-get-custom-object-row.md
[2]: rest-add-custom-object-row.md
[3]: rest-update-custom-object-row.md
[4]: rest-delete-custom-object-row.md
[5]: ../../../archive-providers/reference/dynamic.md
[6]: ../../../search/odata/dynamic-provider.md
[7]: ../../../search/odata/dynamic-provider.md#right-join-category-to-contact
[8]: ../../../archive-providers/reference/contact.md
[9]: ../../../../automation/crmscript/searchengine/index.md
[10]: ../../../../automation/crmscript/overview/index.md
[11]: ../../../archive-providers/reference/CustomObjectDynamicSelectionV2.md
[12]: ../../../archive-providers/reference/contact.md
