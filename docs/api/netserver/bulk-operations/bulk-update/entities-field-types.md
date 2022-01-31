---
title: Entities and field types
uid: entities_field_types
description: Bulk update entities and field types
author: Tony Yates
so.date: 06.23.2017
keywords: bulk update
so.topic: concept
so.envir: cloud
so.client: online
---

# Entities and field types

With a general understanding of how [bulk update][1] works, the following table lists all available properties for each entity, details what [operations][2] are allowed one each property, and details what the expected values are for each operation.

* [appointment table][3]
* [contact table][4]
* [document table][5]
* [person table][6]
* [project table][7]
* [sale table][8]
* [selection table][9]

## Operations and user-defined and extra fields

All user-defined and extra fields (UDFs) are accessible and updatable using BulkUpdate. The user performing the update must have the data right to write to these fields, or possess the *AllowReadonlyOverride* functional right.

When updating a UDF, the `FieldValueInfo.Key` property must be the UDF **progid**. Extra field keys are the field name.

* User-defined fields
* Extra fields

<!-- Referenced links -->
[1]: index.md
[2]: operations-and-values.md
[3]: reference/appointment-table.md
[4]: reference/contact-table.md
[5]: reference/document-table.md
[6]: reference/person-table.md
[7]: reference/project-table.md
[8]: reference/sale-table.md
[9]: reference/selection-table.md
