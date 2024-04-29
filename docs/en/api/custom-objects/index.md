---
uid: custom-objects
title: custom-objects
description: "Introduction to the Custom Objects"
author: Eivind Fasting
so.date: 04.24.2024
keywords: custom objects
so.topic: concept
---

# Introduction to the Custom Objects

Custom Objects gives you the possibility to extend search capabilities on relation fields. What this means is that if you add an ExtraTable and create a relation to a standard Entity (Company, Contact, Sale, Project, Ticket), the standard entitys archive is now updated to include the related information in the ExtraTable.
This will, for instance, make it possible to create selections/search against Extra tables with fields pointing to known SuperOffice entities.
If any visible Extra table contains field pointing to entity(Company, Contact, Sale, Project, Request, Activity) we include it as a “top” node to select from in selections.

In the [learn][1] section you can learn more about what Custom Objects are, the concept behind it, and how you can work with Extra Tables and Extra Fields through the SuperOffice UI.
It also contains information about the [Extra fields][7] themselves and how they are different from [User Defined fields][6], and should give you the basic building blocks for creating your own ExtraTable and ExtraFields.
We also have an own section on how to work with and search for data based on user defined fields through the webservices [here][10]

This section will focus on the API-part of working with Custom Objects, and help understand how the underlying agents can be used to both [ReadRow][2], [InsertRow][3], [UpsertRow][4], [DeleteRow][5] rows in an ExtraTable.

>Note
>Code-examples can also be found on [git][9]

[Search][8] goes more in detail on how to find search for information based on these relations, and contains an example on how to do so.

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