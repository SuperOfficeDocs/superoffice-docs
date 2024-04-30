---
uid: api-custom-objects-index
title: Custom Objects
description: Introduction to the Custom Objects
author: Eivind Fasting
so.date: 04.24.2024
keywords: custom objects
so.topic: concept
---

# Introduction to the Custom Objects

Custom Objects are how a customer can either create new entities or extend existing entities inside SuperOffice, and are available in most search areas inside SuperOffice, including the API. When an ExtraTable is created, and has a field relation to a standard Entity (Company, Contact, Sale, Project, Ticket), the new entity and all of its' fields are available in the standard archives as available entities and columns. This makes it possible to create search selections for data stored in both built-in entity tables and extra tables, and combine them when relational fields exist. When an extra tables is marked as `Visible in archive` and contains a field pointing to a built-in entity, it is included as a “top-level” node in selections.

The [learn][1] section contains more information about Custom Objects, and how you can work with Extra Tables and Extra Fields in SuperOffice. Learn also contains information about the [Extra fields][7] and how they are different from [User Defined fields][6]. The Learn reference section also provides instructions for creating an ExtraTable and ExtraFields.

There also exists a section how to work with and search for data based on user defined fields in the [web services][10] documentation.

This section will focus on how to work with Custom Objects, and explain how to use the API methods [ReadRow][2], [InsertRow][3], [UpsertRow][4], [DeleteRow][5] to perform operations on an ExtraTable custom object.

> [!NOTE]
> Code-examples can also be found on [git][9]

The [Search][8] documentation contains more details about how to perform searches based on these relations with an example.

<!-- Referenced links -->
[1]: ../../custom-objects/overview.md
[2]: ./howto/custom-objects-ReadRow.md
[3]: ./howto/custom-objects-InsertRow.md
[4]: ./howto/custom-objects-Update.md
[5]: ./howto/custom-objects-DeleteRow.md
[6]: ../../custom-objects/learn/udef.md
[7]: ../../custom-objects/extra-field/index.md
[8]: ./howto/custom-objects-Search.md
[9]: https://github.com/SuperOffice/RESTful-HTTP-Queries/blob/environmentSettings/src/CustomObjects.http
[10]: ../web-services/howto/custom-objects/index.md

<!-- Referenced images -->