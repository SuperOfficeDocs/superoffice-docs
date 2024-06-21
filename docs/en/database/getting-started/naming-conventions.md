---
title: Naming conventions
uid: naming_conventions
description: SuperOffice database naming conventions
author: {github-id}
keywords: database
topic: reference
# envir:
# client:
---

# Naming conventions

## Database conventions and table descriptions

This section describes all of the available tables and standard conventions used in the SuperOffice database.

The explanations of the naming convention, the data types, and the key codes in use throughout the database are covered first.

Next, the available tables are listed. For each table, a short description is then provided against the table's name. Then each field (or column) in that table is explained in turn.

## Conventions used throughout the SuperOffice Database

All tables have a primary key as their first column, called `<tablename>_id`. This uniquely identifies each record entered in the table. This value will stay unchanged for the life of the database. There is one exception to this rule, and that is new records created in a Travel database. Their IDs will change when updating the parent database.

All fields referring to other records (foreign keys in relations) also have names ending with the extension **\_id**.

All fields selecting an entry from any one of the special lists for business, company interest, and so on have names ending with the extension **\_idx** (rather than \_id). This used to be the list text table in earlier versions of SuperOffice.

### Inconsistencies

Some other things to note – areas where consistency has suffered due to the way the schema was defined in earlier versions of the product.

* Email and URL have separate fields that point to `contact_id`

While on the other hand:

* Address and Phone have a general `owner_id` and use a `type_idx` to indicate table and role. There may be 2 different `type_idx` values that indicate the same table.

Sometime in the future, this will probably be sorted out by a major upgrade to SuperOffice which creates a completely new database schema. For the time being, we are stuck with these little annoyances and inconsistencies.

## Standard data types in use

| Name | Size | Description |
|---|---|---|
| short | 2 | 16-bit signed integer |
| long | 4 | 32-bit signed integer |
| date_d | 4 | 32-bit unsigned integer, number of seconds since January 1, 1970.  Time part is = midnight. |
| date_t | 4 | 32-bit unsigned integer, number of seconds since January 1, 1970 |
| longid | 4 | 32-bit unsigned integer, record ID |
| string | \<256 | Fixed-size array of bytes terminated by zero-byte, length includes zero-byte |
| lvstring | \<4k | as string, length specifies maximum length. |
| float | 8 | floating-point, same as double |
| double | 8 | floating-point |
