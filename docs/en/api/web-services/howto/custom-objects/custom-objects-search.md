---
uid: api-custom-objects-search
title: Custom objects search
description: How to use custom objects to search for information
author: Eivind Fasting
date: 09.09.2024
version: 10
keywords: custom object, search, DatabaseTable, TableRecord, extra table
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/api/custom-objects/howto/custom-objects-search
  - /en/api/netserver/web-services/howto/custom-objects/custom-objects-search
---

<!-- markdownlint-disable-file MD013 -->
# How to use custom objects to search for information

While the other sections show examples of how to [Read][1], [Insert][2], [Update][3] and [Delete][4], this section focuses on how to search for companies with existing relations connected to them.

The first example uses the [Contact archive][8], while the other uses the `CustomObjectDynamicSelectionV2` and [Dynamic][6] archives to fetch information from extra tables.

## Get available fields for the Contact archive

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

All extra-table relations in the result are shown as `contactExtra/{ExtraTableName}/{FieldName}`.

When relations exist between extra tables, these will be shown as `contactExtra/y_rentals/x_contact_id/x_equipment/x_name`.

When known, search using either the `GetArchiveListByColumns` or `GetArchiveListByColumns2` archive method.

### Example

The following example searches two extra tables, y_rentals and y_equipment.

`y_equipment` in this case contains different items we are renting out. `y_rentals` is the link table between the available items and the companies, and functions as a registry of which items are rented out to which customer.

The following query can be used to find out which items a specific customer has rented:

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

## Get available fields for the CustomObjectDynamicSelectionV2 archive

The `GetAvailableColumns` archive can also be used to get all the available columns, include relational columns, for an extra table.

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

## Using the dynamic archive provider to search for extra table information

By using the [Dynamic archive][5] it's possible to search for data directly from the extra tables. The below example has an extra table y_log, and builds up an [OData query][6] to select the fields and filter the request by the x_ticket field.

```http!
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/archive/dynamic?$select=y_log.id,y_log.x_ticket&$filter=y_log.x_ticket eq 1 HTTP/1.1
Authorization: Bearer {{access_token}}
Accept: application/json
```

This example can also be expanded by including JOINS to another extra table, y_log_message. The sample below uses [RIGHT JOIN][7].

```http!
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/archive/dynamic?$select=y_log.id,y_log.x_ticket,y_log.(y_log_message->x_log).id,y_log.(y_log_message->x_log).x_message&$filter=y_log.(y_log_message->x_log).id eq 1 HTTP/1.1
Authorization: Bearer {{access_token}}
Accept: application/json
```

Using the Dynamic archive is often the preferred approach compared to leveraging CRMScript's [SearchEngine][9] (which historically have been used to search for information with the dot syntax).

> [!NOTE]
> While this method is efficient for querying data in extra tables, it should NOT be used if an existing archive provider already handles the same information — for example, the [Contact archive][8].

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
