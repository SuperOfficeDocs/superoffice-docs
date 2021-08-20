---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 17.08.2021
keywords:
---

# SalesBeforeSaveProject (1009)

Called before a project is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[ProjectEntity input values](includes/project-var.md)]

## Sample code

```crmscript
// Get the variables in the current context
EventData ed = getEventData();

if(ed.getInputValue("IsNew") == "true")
{
    //If project is new make sure Description is not empty
    Bool blockExecution = false;
    String description = ed.getInputValue("ProjectEntity.Description");

    // If the length of description field is less than 2 chars, block save with a message
    if(description.getLength() <= 2)
    {
      ed.setMessage("Please type in a description");
      blockExecution = true;
    }
    ed.setBlockExecution(blockExecution);
}
```
