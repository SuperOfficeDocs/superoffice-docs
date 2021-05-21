---
title: Select relation
uid: blogic_select_relation
description: Select relation
author:
so.date:
keywords:
so.topic: reference
---

# Select relation

This element is a general element used to select a relation to a table. That is, **the primary key of a row in a table**.

It can be used to select, for example, a customer, a user, an entry from an extra table, or a ticket. Selecting the element is done by searching a column in the table with the supplied value. The name of the columns in the query are given with the [line-based query syntax]().

## Configuration

| Setting              | Description                                                     |
|:---------------------|:----------------------------------------------------------------|
| idField              | The column with the ID<br>For example, ticket.id, customer.id) |
| displayValueColumn   | Which column in the display fields that should be displayed when the search dialog box is closed, and the element is minimized |
| orderField           | The field to use for sorting the search results                 |
| orderDesc            | The sort order<br>true = descending                            |
| limit                | Limits the search result (v.3.1.8)                              |
| searchEmpty          |                                                                 |
| displayField         | The control may contain 1 or more displayFields (columns displayed from the search result) |
| displayField.length  | Used for more than 1 display field                              |
| displayField.n.field | Used for more than 1 display field                              |

### Criteria

Criteria constrain which data to have in the grid. This adds **where clauses**:

| Value               | Description                                                         |
|:--------------------|:--------------------------------------------------------------------|
| criteria.n.operator | The operator for this criterion<br>For example, OperatorEquals     |
| criteria.n.field    | The database field for this criterion                               |
| criteria.length     | The total number of criteria. Must be given even if there is only 1 |
| criteria.n.value    | The value of criterion n                                            |

## Functions

### setFieldValue()

| Action          | Map keys | Description                                                           |
|:----------------|:---------|:----------------------------------------------------------------------|
| addCriteria     | field<br>operator<br>values | Adds a criteria                                  |
| addDisplayField | field    | Adds a new display field                                              |
| limit           |          | Set time limit of the returned hits (v. 3.1.8)                        |
| setId           | id       | Set the id of the entry you want to be loaded as default (v. 3.1.8.8) |
| clear           |          | Clears the selected value of the element (v. 4.2.21)                  |

<!-- Referenced links -->
[1]: ../custom-screens/blogic_query_syntax.md
