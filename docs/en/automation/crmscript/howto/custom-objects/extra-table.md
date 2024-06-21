---
uid: crmscript-extra-tables
title: Third-party tables
description: Working with third-party tables in CRMScript
author: Bergfrid Skaara Dias
date: 02.07.2022
keywords: CRMScript, database, extra table, custom object
topic: concept
---

# Third-party tables

## Add data to a new table

Using [SearchEngine][2] and `addData()`, you set up the row and then do an insert.

This example adds a row to the `y_equipment` table with values for the `x_label` and `x_manufacturer` fields.

```crmscript
SearchEngine se;
se.addData("y_equipment.x_label", "tablet");
se.addData("y_equipment.x_manufacturer", "HP");
se.insert();
```

## Reference

### Table properties

| Property | Description |
|:--|:---|
| Folder         | to organize tables in a hierarchy, optional                 |
| Name           | label                                                       |
| Database table | for the schema, can't be changed after creation             |
| Sort order     | which column the table will be sorted on, and the direction |
| Display field  | for relations                                               |
| SuperOffice CRM access | controls access to the table from web panels<br>no access, read access, or full access |

[Complete list of properties][1]

### Field properties

| Property        | Description                                     |
|:----------------|:------------------------------------------------|
| Name            | label                                           |
| Database field  | for the schema, can't be changed after creation |
| Cannot be empty | makes field mandatory                           |
| Create index    | whether to index the field                      |
| Show in table   | whether to as a column when listing entries     |
| Default value   | used if not set explicitly                      |
| Update null values now | whether to replace all empty fields with the default value |

In addition, each type has its own set of properties. For example, items for a list box and decimals in a number, or units for a time span.

[Complete list of properties][3].

<!-- Referenced links -->
[1]: ../../../../custom-objects/admin/create-extra-table.md
[3]: ../../../../custom-objects/admin/create-extra-field.md
[2]: ../../searchengine/index.md
