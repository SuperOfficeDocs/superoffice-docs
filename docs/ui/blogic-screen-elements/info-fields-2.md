---
title: blogic_info_fields_2
description: Info Fields v2
author:
so.date:
keywords:
so.topic: reference
---

# Info Fields v2

This element will display a grid of information fields where the values can be ordered in groups. The information is based on a query to the database.

## Configuration

| Setting                     | Description                                                  |
|:----------------------------|:-------------------------------------------------------------|
| columns                     | Number of columns                                            |
| header                      | The header (value or field)                                  |
| headerIsField               | Whether the header is a field (Bool)                         |
| headerChop                  | Max number of characters to shown in the header              |
| width                       | Width of element as HTML style<br>For example 100% or 300px |
| autoBreaks                  | Whether to break columns (Bool)                              |
| autoUrl                     | Whether to create automatic URLs for relevant fields (Bool)  |
| iconUrl                     | Custom icon to use                                           |
| iconHeader                  |                                                              |
| table                       |                                                              |
| showFavourite               |                                                              |
| entityIdField               |                                                              |
| statusMonitorFields.n.id    |                                                              |
| statusMonitorFields.n.label |                                                              |
| column.n.width              |                                                              |

### Where

| Value                | Description |
|:---------------------|:------------|
| where.n.field        |             |
| where.n.operator     |             |
| where.n.value        |             |
| where.n.valueId      |             |
| where.n.rowOperator  |             |
| where.n.critPriority |             |

### Group configuration

| Value                         | Description                     |
|:------------------------------|:--------------------------------|
| groups.n.label                | Label of group n                |
| groups.n.fields               | The number of fields in group n |
| groups.n.fields.i.newColumn   |                                 |
| groups.n.fields.i.label       | Label of item i in group n      |
| groups.n.fields.i.field       |                                 |
| groups.n.fields.i.baseUrl     | The URL of item i in group n    |
| groups.n.fields.i.appendField | The field value to include to ULR of item i in group n |
| groups.n.fields.i.function    |                                 |
| groups.n.fields.i.chop        |                                 |
| groups.n.fields.i.isHeader    |                                 |
| groups.n.fields.i.isBold      |                                 |
| groups.n.fields.i.nowrap      |                                 |

### Fields at root configuration

| Value                | Description |
|:---------------------|:------------|
| fields.n.newColumn   |             |
| fields.n.type        |             |
| fields.n.label       |             |
| fields.n.field       |             |
| fields.n.baseUrl     |             |
| fields.n.appendField |             |
| fields.n.value       |             |
| fields.n.function    |             |
| fields.n.chop        |             |
| fields.n.isHeader    |             |
| fields.n.isBold      |             |
| fields.n.nowrap      |             |

## Example

```crmscript
groups.0.fields.0.appendField = ticket.id
groups.0.fields.0.baseUrl = ?action=listTicket&id=
groups.0.fields.0.field = ticket.title
groups.0.fields.0.label = Tittel
groups.0.fields.1.appendField = ticket.id
groups.0.fields.1.baseUrl = ?action=listTicket&id=
groups.0.fields.1.field = ticket.owned_by.username
groups.0.fields.1.label = Eier
groups.0.fields.length = 2
groups.0.label = Forste
groups.length = 1
header = ticket.title
headerIsField = true
where.0.critPriority = 0
where.0.field = ticket.id
where.0.operator = OperatorEquals
where.0.rowOperator = OperatorAnd
where.0.valueId = true
where.length = 1
width = 100%
```
