---
uid: api-custom-objects
title: Custom objects
description: Introduction to custom objects
keywords: custom object
author: Eivind Fasting
so.date: 04.24.2024
so.version: 10
so.topic: concept
so.audience: api
so.audience.tooltip: SuperOffice APIs and database
---

# Introduction to custom objects

Custom objects are how a customer can either create new entities or extend existing entities inside SuperOffice, and are available in most search areas inside SuperOffice, including the API.

When an extra table is created, and has a field relation to a standard entity (Company, Contact, Sale, Project, Ticket), the new entity and all of its fields are available in the standard archives as available entities and columns. This makes it possible to create search selections for data stored in both built-in entity tables and extra tables, and combine them when relational fields exist. When an extra tables is marked as `Visible in archive` and contains a field pointing to a built-in entity, it is included as a top-level node in selections.

The [learn section][1] contains additional conceptual information and instructions for working with extra tables and custom fields in Settings and maintenance.

This section will focus on how to work with Custom Objects, and explain how to use the API methods [ReadRow][2], [InsertRow][3], [UpsertRow][4], [DeleteRow][5] to perform operations on an ExtraTable custom object. The [Search][6] documentation contains more details about how to perform searches based on these relations with an example.

> [!TIP]
> Explore code examples on [GitHub][10]!

## Related content

* [How to work with and search for data based on user-defined fields][9]

<!-- Referenced links -->
[1]: ../../../../custom-objects/reference/index.md
[2]: custom-objects-read-row.md
[3]: custom-objects-insert-row.md
[4]: custom-objects-update-row.md
[5]: custom-objects-delete-row.md
[6]: custom-objects-search.md
[9]: ../udef-fields/index.md
[10]: https://github.com/SuperOffice/RESTful-HTTP-Queries/blob/environmentSettings/src/CustomObjects.http

<!-- Referenced images -->