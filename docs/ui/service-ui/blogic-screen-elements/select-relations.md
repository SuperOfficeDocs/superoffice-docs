---
title: blogic_select_multiple relations
description: Select multiple relations
author:
so.date:
keywords:
so.topic: reference
---

# Select multiple relations

This element is used for selecting the primary ID from multiple tables.

It is similar to [Select relation][1]. However, it is used when **more than 1 relation** is required, and displays these in a **grid**.

## Configuration

| Setting             | Description                                                                                |
|:--------------------|:-------------------------------------------------------------------------------------------|
| idField             | The field containing the ID of the relation                                                |
| limit               | Limits the search results<br>Default is 25                                                |
| FlagRadioForPrimary | Whether to add a left-most column with radio buttons for selecting the primary entry       |
| FlagCheckbox        | Whether to add a left-most column with checkboxes for each row                             |
| FlagOnlyOne         | Restricts the control to 1 entry (use this control instead of *Select relation*). (v. 4.0) |
| FlagNotEmpty        | Whether an empty relation is allowed (v. 4.0)                                              |
| FlagNoNewButton     | Whether a **New** button is added (v. 4.2.21)                                              |

### Fields

| Value                 | Description                                           |
|:----------------------|:------------------------------------------------------|
| column.length         |                                                       |
| column.n.label        | The header for this column                            |
| column.n.displayField | The database field to display in this column          |
| column.n.searchField  | The database field to search for this column's values |
| column.n.operator     | The operator used when searching this column<br>For example, OperatorBeginsWith, OperatorEquals, OperatorContains |

### Criteria

Criteria constrain which data to have in the grid.

| Value                  | Description                                                         |
|:-----------------------|:--------------------------------------------------------------------|
| criteria.n.operator    | The operator for this criterion<br>For example,OperatorEquals      |
| criteria.n.field       | The database field for this criterion                               |
| criteria.n.rowOperator | The operator between this and the next criterion                    |
| criteria.n.indent      | How many parentheses surround this criterion                        |
| criteria.length        | The total number of criteria. Must be given even if there is only 1 |
| criteria.n.value       | The value of criterion n                                            |

### Sort order (optional)

| Value         | Description                                      |
|:--------------|:-------------------------------------------------|
| order.n.field | The database field to sort on                    |
| order.n.desc  | The sort order<br>0 = ascending, 1 = descending |
| order.length  | Number of columns to sort on                     |

## Example

You can fetch result set from CRMScript given with the keyword `ejScriptIncludeId = myScriptIncludeId`.

A very simple example script:

```crmscript
#setLanguageLevel 2;

print("<results overflow='false'>\n");

String idField = "category.id";
for (Integer i = 0; i < 20; i++) {
  print("  <result>\n");
  String idField = i.toString();
  idField = idField.xmlEncode();
  print("    <id-field>" + idField + "</id-field>\n");
  print("    <display-fields>\n");
  print("    <display-field>" + idField + "-1" + "</display-field>\n");
  print("    <display-field>" + idField + "-2" + "</display-field>\n");
  print("    <display-field>" + idField + "-3" + "</display-field>\n");
  print("    </display-fields>\n");
  print("  </result>\n");
}
print("</results>\n");
```

You also have access to the configuration settings in the script:

```crmscript
getVariable("displayField.length");
getVariable("displayField." + X);
getVariable("whereField.length");
getVariable("whereField." + X);
getVariable("whereValue." + X);
getVariable("rowOperator." + X);
getVariable("whereField." + X);
getVariable("whereIndent." + X);
getVariable("orderField.length");
getVariable("orderField." + X);
getVariable("orderDirection." + X);
getVariable("limit." + X);
```

## Functions

### getFieldValue(String field)

| Field       | Description                                              |
|:------------|:---------------------------------------------------------|
| primaryId   | The ID of the selected row if FlagRadioForPrimary is set |
| rows        | The number of rows                                       |
| columns     | The number of columns                                    |
| row.n.id    | The ID of row n                                          |
| row.n.m     | The contents of row n, column m                          |
| checkedRows | The IDs of checked rows as a comma-separated list        |

### setFieldValue(String action, Map values)

| Action          | Map keys                              | Description                                                               |
|:----------------|:--------------------------------------|:--------------------------------------------------------------------------|
| addId           | id<br>checked                        | Adds a row to the table with the entry with the given ID.<br>The rest of the values are looked up in the database. |
| addRow          | id<br>checked<br>hidden<br>field.n | Adds a row to the table with n ranging from 0 to the number of columns -1 |
| addCriteria     | field<br>operator<br>value<br>rowOperator<br>indent | Adds a criteria                                         |
| addColumn       | displayField<br>searchField<br>operator<br>label     | Adds a column                                           |
| clearCheckedIds |                                       | Clears the checked rows (v. 4.2.21)                                       |

<!-- Referenced links -->
[1]: select-relation.md
