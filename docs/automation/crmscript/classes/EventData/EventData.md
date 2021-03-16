---
title: crmscript_eventdata
description: EventData
author:
so.date:
keywords:
so.topic:
---

# EventData

**EventData** gives you access to contextual information in an **event handler**. For example, the name of a created company or the amount of a sale.

You can also check `EventData` properties after the event handler has run, to for example display a message or prevent an entity from being saved.

## Fetch variables used in the current context

```crmscript
EventData ed = getEventData();
```

> [!NOTE]
> EventData doesn't work with manually run scripts!

## Type

The types of events that can occur pertain to either [Service screen events][1] (`beforeSetFromCgi`, `afterSetFromCgi`, `beforePrint`) or triggers.

### Integer getType()

```crmscript
EventData ed = getEventData();
printLine(ed.getType().toString());
```

## Input values

**Input values** are for getting available data - a **read** operation. You can either fetch a specific value or a Map with all values.

### String getInputValue(String inputValue)

```crmscript
EventData ed = getEventData();
Integer projectId = ed.getInputValue("ProjectEntity.ProjectId").toInteger();
Bool isCompleted = ed.getInputValue("ProjectEntity.Completed").toBool();
```

> [!TIP]
> Use **Trace** to discover the name of the input value you want to fetch.

**Example: get the value of a user-defined list item:**

```crmscript
EventData ed = getEventData();

String listId = ed.getInputValue("SaleEntity.UserDefinedFields.SuperOffice:1").after(":").before("]");
if(listId != ""){
  NSMDOAgent agent;
  NSMDOListItem item = agent.GetListItem("udlist99", listId.toInteger());
  String listName = item.GetName();
}
```

### Map getInputValues()

```crmscript
EventData ed = getEventData();
Map m = ed.getInputValues();

m.first();
while (!m.eof()){
  printLine(m.getKey() + " = " + m.getVal());
  m.next();
}
```

## Output values

**Output values** are for setting (or changing) data - a **write** operation. They are frequently set on a  *before save* trigger to get better data quality.

### Void setOutputValue(String name, String value)

```crmscript
Integer newOrgNr = 987654321;
EventData ed = getEventData();
ed.setOutputValue("ContactEntity.OrgNr", newOrgNr);
```

**Example: summarize all sales connected to a project, then update a user-defined field on the current project:**

```crmscript
EventData ed = getEventData();
String projectId = ed.getInputValue("ProjectEntity.ProjectId");

SearchEngine se;
se.bypassNetServer(true);
se.addField("sale.amount", "sum");
se.addCriteria("sale.project_id", "Equals", projectId);

if(se.select() > 0) {
  ed.setOutputValue("ProjectEntity.UserDefinedFields.SuperOffice:1", "[F:" + se.getField(0) + "]");
}
```

## Custom values

In addition to the built-in input and output values, you can also set and get **custom values**. These are also called **state values** and work just like setting and getting the standard values. The only difference is that **naming** the custom variables is up to you.

| Method         | Description        | Equivalent to  |
|:---------------|:-------------------|:---------------|
| getStateValue  | Get specific value | getInputValue  |
| getStateValues | Get all values     | getInputValues |
| setStateValue  | Set specific value | setOutputValue |

After you set a custom value, it can be accessed - also by other `EventData` objects in the same script.

## Messages

### String getMessage()

Returns the message set in an `EventData` object.

```crmscript
EventData ed = getEventData();
printLine(ed.getMessage());
```

### Void setMessage(String message)

Displays a dialog box containing the specified message.

```crmscript
EventData ed = getEventData();
String orgNr = ed.getInputValue("ContactEntity.OrgNr");
if(orgNr.isEmpty()) {
  ed.setMessage("Please type an Org.Nr");
}
```

> [!NOTE]
> Service screens are not compatible with the message box!

## Validation and blocking actions

### Bool getBlockExecution()

Used to check whether the current event action has been blocked.

### Void setBlockExecution(Bool value)

Used to prevent the current event action from being executed.

### Void setValidationMessage(String message)

A shorthand for calling `setBlockExecution(true)` and `setMessage(message)`.

### Example: check if a field is empty, and block execution

```crmscript
EventData ed = getEventData();
if(ed.getInputValue("x_invoice_no.value") == "") {
  getHtmlElement("x_invoice_no").setErrorMessage("Error");
  ed.setBlockExecution(true);
}

String orgNr = ed.getInputValue("ContactEntity.OrgNr");
if(orgNr.isEmpty()) {
  ed.setValidationMessage("Please type in a Org.Nr");
}
else if(!orgNr.isDigit() || orgNr.getLength() != 9) {
  // ...
}
```

### Setting criteria with a Map instead of multiple OR conditions in an if statement

```crmscript
Map sourceIds;
sourceIds.insert("11", "");
sourceIds.insert("128", "");
sourceIds.insert("135", "");

if (sourceIds.exists(sourceId.toString())){
  // ...
}
```

## Navigation

Navigation uses [SOProtocol][2] and [URL parameters][3].

### String getNavigateTo()

Returns the location `EventData` has navigated to.

### Void setNavigateTo(String url)

Sets which page to load next.

```crmscript
EventData ed = getEventData();
ed.setNavigateTo("soprotocol:sale.document?document_id=0");
```

<!-- Referenced links -->
[1]: screen-events.md
[2]: soprotocol/index.md
[3]: url-parameters.md
