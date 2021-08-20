---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 17.08.2021
keywords:
---

# SalesBeforeSaveContact (1005)

Called before a contact is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[ContactEntity input values](includes/contact-var.md)]

## Sample code

```crmscript
// Get the variables in the current context
EventData ed = getEventData();

// Get the input value from the current company
String orgNr = ed.getInputValue("ContactEntity.OrgNr");
Bool blockExecution = false;

// If the orgNr field is empty, block save with a message
if(orgNr.isEmpty())
{
  ed.setMessage("Please type in a Org.Nr");
  blockExecution = true;
}// If the orgNr field has letters or is not 9 digits
else if(!orgNr.isDigit() || orgNr.getLength() != 9)
{
  ed.setMessage("Please type in a valid Org.Nr (9 digits)");
  blockExecution = true;
}
ed.setBlockExecution(blockExecution);
```
