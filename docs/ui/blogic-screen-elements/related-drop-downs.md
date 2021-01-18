---
title: blogic_related_dropdowns
description: Related dropdowns
author:
so.date:
keywords:
so.topic: reference
---

# Related dropdowns

This element is useful where the options in one drop-down menu depend on the value in another menu.

A typical scenario is the selection of fields in related extra tables.

> [!NOTE]
> If the drop-down menus are populated by values from different tables, the IDs will probably be the same in both tables. Therefore, the **IDs of the nodes must have a prefix** to insure that they are unique in all drop-downs.

## Configuration

| Setting          | Description                                                   |
|:-----------------|:--------------------------------------------------------------|
| label            | The UI label of the set                                       |
| labels.n.label   | The UI label of the nth list                                  |
| labels.length    | The number of labels                                          |
| notEmptyDropdown | The last menu that can't be empty. Numbering starts at 0      |
| printDownwards   | How to list drop-down menus<br>true = list one per row<br>false = list all in one row |
| selectFromTree   | Whether to show drop-down menus as a tree chooser (Bool)      |

> [!NOTE]
> Setting `selectFromTree = true` turns on tree mode and printDownwards, labels.length, and labels.n.length are ignored.

## Example

### List-mode

```crmscript
label = Related
labels.0.label = Ticket
labels.1.label = Customer
labels.2.label = Email
labels.length = 3
notEmptyDropdown = 0
printDownwards = true
selectFromTree = false
```

### Tree-mode

```crmscript
label = Related
notEmptyDropdown = 0
selectFromTree = true
```

### Creation script

```crmscript
HtmlElement e;
Map m;

SearchEngine se;
se.addFields("ticket","id,title");
se.addCriteria("ticket.status", "OperatorLt", "4", "OperatorAnd", 0);
se.addOrder("ticket.id", true);

for (se.execute(); !se.eof(); se.next()) {
  m.insert("id", se.getField(0));
  m.insert("value",  se.getField(1));
  m.insert("isFolder", "0");
  e.setFieldValue("addNode", m);
}
```

Then you repeat the query and loop for each additional list. To complete the example with customer and email, you can use these queries:

```crmscript
SearchEngine cust;
cust.addFields("ticket_customers","ticket_id,customer_id.display_name,customer_id");
cust.addCriteria("ticket_customers.ticket_id.status", "OperatorLt", "4", "OperatorAnd", 0);

SearchEngine email;
email.addFields("cust_email","cust_id,email");
```

## Functions

### getFieldValue(String field)

Returns all IDs of the resulting drop-down menus in a comma-separated string.

### setFieldValue(String action, Map values)

| Action   | Map keys                             | Description                               |
|:---------|:-------------------------------------|:------------------------------------------|
| addNode  | id<br>parent<br>value<br>isFolder | Adds node to the drop-down.<br>If parent is set, place node in the menu to the right of the parent<br>If no parent, place node in the 1st menu |
| addLabel | label                                |                                           |
| set      | notEmptyDropdown<br>printDownwards  |                                           |

```crmscript
Map map;
map.insert("notEmptyDropdown", "0");
map.insert("printDownwards", "true");
e.setFieldValue("set", map);
```

### toString()

Returns all IDs of the resulting drop-down menus in a comma-separated string.
