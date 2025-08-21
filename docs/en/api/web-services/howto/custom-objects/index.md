---
uid: api-custom-objects
title: Introduction to custom objects and fields
description: Introduction to custom objects and fields
keywords: custom object, custom field, extra table, extra field, udef, user-defined field
author: Eivind Fasting
date: 04.24.2024
version: 10
content_type: concept
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/api/custom-objects/index
  - /en/custom-objects/udef/howto/services/index
  - /en/api/netserver/web-services/howto/custom-objects/index
---

# Introduction to custom objects and fields

Custom objects are how a customer can either create new entities or extend existing entities inside SuperOffice, and are available in most search areas inside SuperOffice, including the API.

When an extra table is created, and has a field relation to a standard entity (Company, Contact, Sale, Project, Ticket), the new entity and all of its fields are available in the standard archives as available entities and columns. This makes it possible to create search selections for data stored in both built-in entity tables and extra tables, and combine them when relational fields exist. When an extra tables is marked as `Visible in archive` and contains a field pointing to a built-in entity, it is included as a top-level node in selections.

The [learn section][1] contains additional conceptual information and instructions for working with extra tables and custom fields in Settings and maintenance.

## Available samples

### How to manage user-defined fields

* [Get all user-defined fields][14]
* [Create a user-defined field][15]
* [Update a user-defined field][16]
* [Delete a user-defined field][17]

### How to work with user-defined field values

* [Set udef list-item value][11]
* [Get udef list and values][12]
* [Find contact by udef][13]

### CRUD operations on rows in extra tables

* [Read row][2]
* [Insert row][3]
* [Upsert row][4]
* [Delete row][5]
* [Search][6] (based on relations)

## Related content

* [Explore custom-object code examples on GitHub][10]

<!-- Referenced links -->
[1]: ../../../../custom-objects/reference/index.md
[2]: rest-get-custom-object-row.md
[3]: rest-add-custom-object-row.md
[4]: rest-update-custom-object-row.md
[5]: rest-delete-custom-object-row.md
[6]: custom-objects-search.md
[10]: https://github.com/SuperOffice/RESTful-HTTP-Queries/blob/environmentSettings/src/CustomObjects.http

[11]: set-udef-listitem-value.md
[12]: get-udef-list-and-values.md
[13]: find-contact-by-udef.md
[14]: rest-get-all-udef-fields.md
[15]: rest-create-udef-field.md
[16]: rest-update-udef-field.md
[17]: rest-delete-udef-field.md

<!-- Referenced images -->
