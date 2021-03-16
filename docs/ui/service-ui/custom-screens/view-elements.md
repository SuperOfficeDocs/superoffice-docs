---
title: blogic_view_elements
description: View elements
author:
so.date:
keywords:
so.topic: 
---

# View elements

**View elements** display read-only info.

> [!NOTE]
> These elements may **not contain children**!

## Visual components

* [Header][1]: adds a sub-header (can be made into a link)

* [Link row (Anchor line)][2]: adds a horizontal line of clickable URLs (breadcrumbs)

* [BR][3]: adds an HTML line-break (vertical space)

* [HR][4]: adds a horizontal line

## Info fields v2

[Info fields v2][5] adds a grid of information fields.

### Example config

```crmscript
profileBaseTable = contact
profileElementName = view_contact
where.0.field = contact.contact_id
where.0.indent = 0
where.0.operator = OperatorEquals
where.0.rowOperator = OperatorAnd
where.0.valueId = true
where.length = 1
```

### Grouping

The values can be grouped.

```crmscript
groups.0.fields.0.appendField = ticket.id
groups.0.fields.0.baseUrl = ?action=listTicket&id=
groups.0.fields.0.field = ticket.title
groups.0.fields.0.label = Title
groups.0.fields.1.appendField = ticket.id
groups.0.fields.1.baseUrl = ?action=listTicket&id=
groups.0.fields.1.field = ticket.owned_by.username
groups.0.fields.1.label = Owner
groups.0.fields.length = 2
groups.0.label = First
groups.length = 1
```

In this example, there's 1 group with 2 fields.

## HTML text with parser and database

Adds HTML-formatted text, including data from the database as [parser variables][6].

This element also supports AJAX. See examples in the [element reference][7].

## Data table

A [data table][8] adds a dynamic grid (table) **automatically filled with data**. The information is based on a query to the database.

### Example with simple values

```crmscript
criteria.0.field = ticket.(ticket_customers->ticket_id).customer_id.contact_id
criteria.0.indent = 0
criteria.0.operator = OperatorEquals
criteria.0.rowOperator = OperatorAnd
criteria.0.valueId = true
criteria.1.field = ticket.status
criteria.1.indent = 0
criteria.1.operator = OperatorLte
criteria.1.rowOperator = OperatorAnd
criteria.1.value = 3
criteria.length = 2
dbDistinct = true
distinct = ticket.id
profileElementName = ej_viewContact_ticketTable
```

### Example with callback script

In this example, the data table contains requests with ID less than 50. The table lists the title, the owner's username, and the status. The ID is a hidden field.

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

Now, lets **change the colors** of the rows:

* We add a new hidden field to store the value of the colors. You can use any field not already in the table. Remember to update `fields.length`.
* Then we tie in a callback function `formatDisplayField()` to do the magic.

**Config:**

```crmscript
fields.4.hidden = true
fields.4.field = ticket.author
fields.length = 5

colorField = ticket.author
callbackInit = init
callbackDisplay = formatDisplayField
```

**Callback functions (in the Body tab):**

```crmscript
// Set up the SearchEngine
Void init(SearchEngine se) {
  se.addField("ticket.owned_by");
}

// Change the colorfield according to the ticket's status.
// Add a text on the owner's column for the users that have status not present.
// Translate status IDs to text.
String formatDisplayField(SearchEngine se, String field) {
  if(field == "ticket.owned_by.username") {
    User u;
    u.load(se.getField("ticket.owned_by").toInteger());
    if (u.getValue("status") == "2")
      return se.getField(field) + " : Not present";
    else
      return se.getField(field);
  }
  
  else if(field == "ticket.status") {
    if(se.getField("ticket.status").toInteger() == 1)
      return "Open";
    else if (se.getField("ticket.status").toInteger() == 2)
      return "Closed";
    else if (se.getField("ticket.status").toInteger() == 3)
      return "Postponed";
    else if (se.getField("ticket.status").toInteger() == 4)
      return "Deleted";
  }
  else if (field == "ticket.author") {
    if(se.getField("ticket.status").toInteger() == 1)
      return "#8888FF";
    else
      return "#FF8888";
  }
  // default, return the field unchanged
  return se.getField(field);
}
```

## Static grid

[Static grid][9] adds an empty static grid (table). You must add content manually!

## Chart

[Chart][10] adds a chart using the JavaScript **charts** library.

## Context-specific elements

* [Dependency graph][11] (for project)

* [Messages][12]: display the messages for a ticket

* [Recipients][13]: shows email recipients

* [Planner (diary)][14]: shows a day schedule

## Scripts

The [Ejscript element][15] adds a completely custom element to your screen. Use CRMScript to set content and behavior.

### Example: add a heading

```crmscript
print("<b>" + getLanguageVariable("newTicketDesc") + "</b>");
```

Perhaps with some additional styling:

```crmscript
print("<div style='font-size:15pt;'>" + getLanguageVariable("msg1") + "</div>");
```

### Example: close ticket

```crmscript
print("<script>\n");
print("$(document).on('ready', function() { if (top.opener && !top.opener.closed) top.opener.location.reload(true);\n");
print("window.open('', '_self', ''); window.close();});\n");
print("</script>\n");
```

### Example: resize element

```crmscript
String message = "Uninitialized message...";

Void element_printOnLoadSection() {
  print("alert('onload');");
}


Void element_printJavaScriptSection() {
  print("function mySetSizeFunction(width, height) { document.getElementById('myElement').style.width width* 4; document.getElementById('myElement').style.height = height* 4; }\r\n");
}

Void element_printHeadSection() {
  print("<style> .myElementStyleClass { border: black solid 2px; } </style>");
}

Void element_printBodySection() {
  print("<div class='myElementClass' id='myElement'>" + message + "</div>");
}

String element_getSetSizeStatement() {
  return "mySetSizeFunction(";
}

Void element_setValue(String value) {
  message = value;
}

Void element_setFieldValue(String field, Map map) {
  if (field == "setMessage")
    message = map.get("message");
}
```

<!-- Referenced links -->
[1]: ../blogic-screen-elements/header.md
[2]: ../blogic-screen-elements/anchor-line.md
[3]: ../blogic-screen-elements/br.md
[4]: ../blogic-screen-elements/hr.md
[5]: ../blogic-screen-elements/info-fields-2.md
[6]: https://github.com/SuperOfficeDocs/crmscript/blob/main/docs/parser-and-templates/parser.md
[7]: ../blogic-screen-elements/parser-code.md
[8]: ../blogic-screen-elements/data-table.md
[9]: ../blogic-screen-elements/static-grid.md
[10]: ../blogic-screen-elements/chart.md
[11]: ../blogic-screen-elements/dependency-graph.md
[12]: ../blogic-screen-elements/messages.md
[13]: ../blogic-screen-elements/recipients.md
[14]: ../blogic-screen-elements/planner.md
[15]: ../blogic-screen-elements/ejscript-element.md
