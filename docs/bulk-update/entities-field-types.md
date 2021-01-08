---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: entities_field_types       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Entities and field types # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates
so.date: 06.23.2017
keywords:
so.topic: concept           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Entities and field types

With a general understanding of how [BulkUpdate][1] works, the following table lists all available properties for each entity, details what [operations][2] are allowed one each property, and details what the expected values are for each operation.

* [Appointment Table][3]
* [Contact Table][4]
* [Document Table][5]
* [Person Table][6]
* [Project Table][7]
* [Sale Table][8]
* [Selection Table][9]

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
