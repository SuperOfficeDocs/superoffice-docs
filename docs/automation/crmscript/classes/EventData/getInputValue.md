---
title: crmscript_ref_EventData_getInputValue_String_inputValue
description: EventData.getInputValue(String inputValue)
intellisense: EventData.getInputValue
sortOrder: 291
keywords: getInputValue(String)
so.topic: reference
---

# String getInputValue(String inputValue)

This method returns the value of a specified input field (for example "ContactEntity.Department").

```crmscript
EventData ed = getEventData();
Integer projectId = ed.getInputValue("ProjectEntity.ProjectId").toInteger();
Bool isCompleted = ed.getInputValue("ProjectEntity.Completed").toBool();
```

> [!TIP]
> Use **Trace** to discover the name of the input value you want to fetch.

## Example: get the value of a user-defined list item

```crmscript
EventData ed = getEventData();

String listId = ed.getInputValue("SaleEntity.UserDefinedFields.SuperOffice:1").after(":").before("]");
if(listId != ""){
  NSMDOAgent agent;
  NSMDOListItem item = agent.GetListItem("udlist99", listId.toInteger());
  String listName = item.GetName();
}
```
