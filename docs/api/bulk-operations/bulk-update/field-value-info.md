---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: bulkupdate_field_value_info       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: BulkUpdateSystem FieldValueInfo # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates
so.date: 06.23.2017
keywords:
so.topic: concept            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# BulkUpdateSystem FieldValueInfo

Whether you choose to get a list of entity identities using OSQL, CustomSearch, or leveraging [archive providers][3], we assume that you know how to execute a query that will result in one or more entity identities to update.

With a list of entity identities to iterate over, bulk update operations are performed against the fields of that entity, i.e. `Person.Title` and `Person.Interest`. The way bulk update understands which fields need to be updated is by using a `FieldValueInfo` instance, containing the following information:

* **Key:** the field name.
* **Operation:** the action to be performed.
* **Values:** the parameters that correspond to the operation.

## FieldValueInfo.Key

**FieldValueInfo.Key** refers to an entity field name. While most of the entity field names are the same as seen in the database or API, some are not. See the [listing of all field names][1] and [their affected API properties][2].

## FieldValueInfo.CurrentOperationType

**FieldValueInfo.CurrentOperationType** is the action performed by the bulk update system. Use the **BulkUpdateSystem.OperationTypes** static class, containing all available operation values to set the intended action. Each [operation][1] has a predetermined set of parameters needed to perform successfully.

## FieldValueInfo.Values

**FieldValueInfo.Values** is a string array that is expected to contain the parameters required by the field operation. Each operation has a different number of [values required for each operation type][2].

Continue reading: [Operations and values][1].

<!-- Referenced links -->
[1]: operations-and-values.md
[2]: entities-field-types.md
[3]: ../../archive-providers/index.md
