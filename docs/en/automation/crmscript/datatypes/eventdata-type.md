---
uid: crmscript_eventdata
title: EventData
description: EventData gives you access to contextual information in an event handler.
keywords: crmscript, eventdata, event handler, CGI
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: concept
---

# EventData

**EventData** gives you access to contextual information in an **event handler**. For example, the name of a created company or the amount of a sale.

You can also check `EventData` properties after the event handler has run, to for example display a message or prevent an entity from being saved.

## Example

Check if a sale has a high enough value. Return a message and block the sale for values < 100. Set for the event "Before save sale".

```crmscript
EventData ed = getEventData();

if (ed.getInputValue("SaleEntity.Amount").toInteger() < 100)
{
  ed.setBlockExecution(true); // Prevents save
  ed.setMessage("Amount too low");
}
```

## Fetch variables used in the current context

```crmscript
EventData ed = getEventData();
```

> [!NOTE]
> EventData doesn't work with manually run scripts!

## Type

The types of events that can occur pertain to either [Service screen events][1] (`beforeSetFromCgi`, `afterSetFromCgi`, `beforePrint`) or triggers.

* Integer [getType()][4]

## Input values

**Input values** are for getting available data - a **read** operation. You can either fetch a specific value or a Map with all values.

* String [getInputValue(String inputValue)][5]
* Map [getInputValues()][6]

## Output values

**Output values** are for setting (or changing) data - a **write** operation. They are frequently set on a  *before save* trigger to get better data quality.

* Void [setOutputValue(String name, String value)][7]

## Custom values

In addition to the built-in input and output values, you can also set and get **custom values**. These are also called **state values** and work just like setting and getting the standard values. The only difference is that **naming** the custom variables is up to you.

| Method         | Description        | Equivalent to  |
|:---------------|:-------------------|:---------------|
| getStateValue  | Get specific value | getInputValue  |
| getStateValues | Get all values     | getInputValues |
| setStateValue  | Set specific value | setOutputValue |

After you set a custom value, it can be accessed - also by other `EventData` objects in the same script.

> [!NOTE]
> From version 10.5.2, we support listening for a command in StateValue to close Ticket tabs from CRMScript triggers in the Sales client.

This can be done by adding a StateValue **command:ticket.tab.close**, read more details [here][16].

## Open dialog to handle user interaction

> [!NOTE]
> From version 10.1.9 we support generating a dialog from CRMScript triggers in Sales client.

In certain scenarios, it can be necessary to ask the user for input or confirmation before completing process, using this method we allow for creating a simple dialog which will return input back to CRMScript trigger. Use this to construct a useful workflow.

* Void [showDialog(EventDataDialogDefinition dialog)][15]

## Messages

* String [getMessage()][8]
* Void [setMessage(String message)][9]

## Validation and blocking actions

* Bool [getBlockExecution()][10]
* Void [setBlockExecution(Bool value)][11]
* Void [setValidationMessage(String message)][12]

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

* String [getNavigateTo()][13]
* Void [setNavigateTo(String url)][14]
<!-- Referenced links -->
[1]: ../../../ui/blogic/screen-events.md
[2]: ../../../ui/soprotocol/index.md
[3]: ../../../ui/blogic/url-parameters.md
[4]:  <xref:CRMScript.Native.EventData.getType()>
[5]:  <xref:CRMScript.Native.EventData.getInputValue(String)>
[6]:  <xref:CRMScript.Native.EventData.getInputValues()>
[7]:  <xref:CRMScript.Native.EventData.setOutputValue(String,String)>
[8]:  <xref:CRMScript.Native.EventData.getMessage()>
[9]:  <xref:CRMScript.Native.EventData.setMessage(String)>
[10]: <xref:CRMScript.Native.EventData.getBlockExecution()>
[11]: <xref:CRMScript.Native.EventData.setBlockExecution(Bool)>
[12]: <xref:CRMScript.Native.EventData.setValidationMessage(String)>
[13]: <xref:CRMScript.Native.EventData.getNavigateTo()>
[14]: <xref:CRMScript.Native.EventData.setNavigateTo(String)>
[15]: <xref:CRMScript.Native.EventData.showDialog(EventDataDialogDefinition)>
[16]: ../tutorials/closing-request-tabs-in-triggers.md
