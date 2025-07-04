---
uid: help-en-udef-edit
title: Edit user-defined field
description: Edit user-defined field
keywords: udef, user-defiend field, custom field, field type
author: Bergfrid Dias
date: 01.16.2024
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
---

# Edit user-defined field

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Double-click the required field in the **Fields** list.

1. Make the necessary changes in the various fields. (See the list of [field properties][1]).

    Use the **Type** drop-down to choose a new type. You will see only the compatible field types. That is, where existing data can be converted to fit the new field type.

1. Click **Save**.

1. Click **Publish** to make the changes available to SuperOffice users.

> [!NOTE]
> You must publish the changes for user-defined fields before you [define page 1 fields][2] for the various user groups and save (not publish).

## Convert field type

Not all conversions are possible because different types of user-defined field values are stored in different tables in the database and use different base data types.

| Field type | Number | Decimal | Short text | Long text | Date | Unlimited date | Checkbox | List |
|:--|:-:|:-:|:-:|:-:|:-:|:-:|:-:|:-:|
| Number | x | x | x | | | | | |
| Decimal | x | x | x | | | | | |
| Short text | x | | x | | | | | |
| Long text | | | | x | | | | |
| Date | | | x | | x | x | | |
| Unlimited date | | | x | | | x | | |
| Checkbox | | | x | | | | x | |
| List | | | x | | | | | x |

**How to read the table:**

The field types in the left column are compatible with and can be converted to the types marked with an x. For example, a number can be converted to a decimal and a short text. (And it is obviously compatible with itself.)

<!-- Referenced links -->
[1]: add-udef.md#properties
[2]: edit-udef-layout.md#page-1

<!-- Referenced images -->
