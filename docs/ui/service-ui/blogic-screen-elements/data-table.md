---
title: Data table
uid: blogic_data_table
description: Data table
author:
so.date:
keywords:
so.topic: reference
---

# Data table

This is a new version of the old screen element `Table` with additional features.

When giving database fields and criteria, the table is automatically filled with data.

> [!NOTE]
> Please use this element instead of static tables, or similar.

## Configuration

### Fields

| Setting            | Required | Description                                 |
|:-------------------|:--------:|:--------------------------------------------|
| fields.n.label     | x        | The header of column n                      |
| fields.n chop      | x        | The max count of characters in column n     |
| fields.n.footerFunction | x   |                                             |
| fields.n.field     | x        | The database field for column n             |
| fields.n.function  | x        | Used together with fields.n.functionParams  |
| fields.n.functionParams | x   | Used together with fields.n.function        |
| fields.n.hidden    |          | Whether to hide column n (Bool)             |
| fields.n.selectRow |          | Whether to add a checkbox to the row (Bool) |
| fields.length      |          | Count of fields                             |

> [!NOTE]
> It is mandatory to set either `fields.n.field` OR both `fields.n.function` and `fields.n.functionParams`.

### Criteria

Criteria constrain which data to have in the table.

| Value               | Description                                                             |
|:--------------------|:------------------------------------------------------------------------|
| criteria.n.operator | The operator for this criterion                                         |
| criteria.n.field    | The database field for this criterion                                   |
| criteria.n.rowOperator | The operator between this and the next criterion                     |
| criteria.n.indent   | How many parentheses surround this criterion                            |
| criteria.length     | The total number of criteria. Must be given even if there is only 1     |
| criteria.n.value    | The value of criterion n                                                |
| criteria.n.valueId  | Whether to automatically set the value to the screen's `entryId` (Bool) |

> [!NOTE]
> Criteria must contain either `value` or `valueId`. Use one or the other, but not both for the same criteria.

### Sort order and grouping (optional)

| Value                   | Description                                      |
|:------------------------|:-------------------------------------------------|
| orders.n.column         | The database field to sort on                    |
| orders.n.direction      | The sort order<br>0 = ascending, 1 = descending |
| orders.n.orderByInteger |                                                  |
| orders.length           | Number of columns to sort on                     |
| groups.n.column         | The database field to group by                   |
| groups.n.direction      |                                                  |
| groups.n.orderByInteger |                                                  |
| groups.length           | Number of groups                                 |

### Optional config

| Value               | Description                                                                        |
|:--------------------|:-----------------------------------------------------------------------------------|
| maxHeight           | The maximum height of the table in pixels                                          |
| pageSize            | The number of rows to show on a single page. If the result has more rows than pageSize, pagination links are are added. |
| width               | The width of the table (for example, 100%, 150 px)                                 |
| limit               | The maximum count of rows to list                                                  |
| url                 | A URL. Must be the same for the entire row                                         |
| distinct            | The database field that will be distinct in the result                             |
| dbDistinct          | Same as distinct, but the calculation is done by the database.                     |
| orderColumn         | The database field that will have the default order                                |
| orderAsc            | The sort order<br>true = ascending, false = descending                            |
| showTicketStatus    | Whether to visually indicate ticket status                                         |
| showContactColors   | Whether to user text color (Bool)<br>grey = deleted, red/black = stopped          |
| showPersonColors    | Whether to user text color (Bool)<br> grey = retired                              |
| newItemCommandField | Adds a button at the bottom of the table. For the company screen:<br>ticket.cust_id (action add new request to customer )<br>person.contact_id (action add new person to company)                                                      |
| colorField          | Information about the color of the row                                             |
| colorFieldCodes     |                                                                                    |
| profileBaseTable    |                                                                                    |
| table               |                                                                                    |
| linkUrl             |                                                                                    |
| linkAppendField     | The database field to append to the end of the URL. Must be a field in a column    |
| baseUrl             |                                                                                    |
| appendField         |                                                                                    |
| callbackInit        | The name of the function that initializes the SearchEngine<br>Located in Body tab |
| callbackDisplay     | The name of the function that processes the result<br>Located in Body tab         |
| callbackSort        | The name of the function that sorts the result<br>Located in Body tab             |

**A word about ticket status:**
If your table contains a column ticket.status and showTicketStatus is set, each ticket will have an icon showing its status. Urgent tickets are also highlighted.

## Example

In this example, the data table contains requests with ID less than 50.
The table lists the title, the owner's username, and the status.
The ID is a hidden field.

```crmscript
fields.0.field = ticket.title
fields.0.label = Title
fields.1.field = ticket.owned_by.username
fields.1.label = Owner
fields.2.field = ticket.id
fields.2.hidden = true
fields.3.field = ticket.status
fields.3.label = Status
fields.length = 4

criteria.0.field = ticket.id
criteria.0.indent = 0
criteria.0.operator = OperatorLt
criteria.0.rowOperator = OperatorAnd
criteria.0.value = 50
criteria.length = 1

showTicketStatus = true
url = ticket.exe?action=listTicket&ticketId=
```

### Using callbacks

* Add hidden fields to pass additional values to the functions
* In the **Body** tab, write 2 functions, one for init and one for display
* In the **Simple values** tab, set `callbackInit` and `callbackDisplay` to the function names.

```crmscript
callbackInit = init
callbackDisplay = formatDisplayField
```

[Learn more about callbacks][1] in the CRMScript documentation

## Functions

### getFieldValue(string)

| Value                      | Description                    |
|:---------------------------|:-------------------------------|
| numRows                    | The number of rows in the grid |
| pageSize                   | The size of a page             |
| flags                      | The flags for the grid         |
| maxHeight                  | The maximum height             |
| width                      | The width of the grid          |
| allRowsCount               | Whether to count all rows      |
| header.n.label             | The label for header n         |
| header.n.flags             | The flags for header n         |
| header.n.chop              | The max amount of characters shown for cells in column n |
| row.n.id                   | The IF for row n               |
| row.n.url                  | The url for the row            |
| row.n.flags                | The flags for the row          |
| row.n.selected             | Whether the row is selected    |
| row.n.numCells             | The number of cells in the row |
| row.n.cell.m.label         | The label of cell m in row n   |
| row.n.cell.m.m_sortString  | The sort string                |
| row.n.cell.m.m_sortInteger | The sort number                |
| row.n.cell.m.m_flags       | The flags                      |

> [!TIP]
> You can also use `rowid.n.<field>` where n is the ID of the row instead of its number.

### setFieldValue(String action, Map values)

| Action               | Map keys             | Description                                    |
|:---------------------|:---------------------|:-----------------------------------------------|
| addHeader            | label<br>flags<br>chop<br>width | Adds a header                   |
| addRow               | id<br>url<br>target<br>flags<br>color<br>toolTip<br>selected | Adds a row |
| addRowUnique         | same as addRow       | Adds a row with a unique ID                    |
| addCell              | label<br>sort<br>url<br>target<br>flags<br>toolTip | Adds a cell |
| deleteSelectedRows   |                      | Deletes the selected rows                      |
| clearSelectedRows    |                      | Removes selected mark on the selected rows     |
| deleteRows           |                      | Deletes all rows                               |
| set                  | pageSize<br>flags<br>maxHeight<br>width<br>allRowsCount<br>selectedRows | Sets various fields |
| defaultOrder         | column<br>direction | Sets the column that by default orders the rows<br>"asc" or "desc" |
| setDropDownOptions.n |                      | Sets the drop-down options for column n        |
| addCommand           | title<br>url<br>returnUrl<br>idString<br>menuIndex<br>commandIndex | Adds a menu command with parameters (v. 4.5) |
| addCommandMenu       | label<br>title<br>iconUrl<br>idString<br>/url(v. 7.1) | Adds a menu (for commands) with parameters (v. 4.5)  |
| deleteCommand        | idString            | Deletes commands (v. 4.5)                       |
| deleteCommandMenu    | idString            | Deletes menus (v. 4.5)                          |
| addGroup             | column<br>order    | Adds groups (v. 8.4R07)<br>descending or ascending (default) |

menuIndex and commandIndex are optional zero-based indexes for placement.

**Flags** are the same as described for [StaticGrid][2].

<!-- Referenced links -->
[1]: ../custom-screens/view-elements.md
[2]: static-grid.md
