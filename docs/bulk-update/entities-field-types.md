---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: entities_field_types       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Entities and field types # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates             # Your GitHub alias.
so.date: 23 Jun 2017
keywords:
so.topic: concept           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Entities and field types

With a general understanding of how BulkUpdate works, the following table lists all available properties for each entity, details what operations are allowed one each property, and details what the expected values are for each operation.

* Appointment Table
* Contact Table
* Document Table
* Person Table
* Project Table
* Sale Table
* Selection Table

## Operations and User-Defined and Extra Fields

All user-defined and extra fields (UDFs) are accessible and updatable using BulkUpdate. The user performing the update must have the data right to write to these fields, or possess the AllowReadonlyOverride functional right.

When updating a UDF, the `FieldValueInfo.Key` property must be the UDF **progid**. Extra field keys are the field name.

* User-Defined FIelds
* Extra Fields
