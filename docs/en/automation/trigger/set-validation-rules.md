---
title: Set validation rule
uid: set_validation_rules_in_trigger
description: What if I want to specify what to validate?
author: Simen Mostuen Iversen
date: 06.06.2019
keywords: automation,validate,contact
topic: howto
---

# What if I want to specify what to validate?

In this example, I will only write a script as a macro is falling a bit short when you need more specific validation.

Let's use the organization number validation example and build upon that.

We want it to only contain numbers, and it has to be 9 digits. The code we will write will be something like this:

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
}// If the orgNr field has letters or is not 9 digits
else if(!orgNr.isDigit() || orgNr.getLength() != 9)
{
  ed.setMessage("Please type in a valid Org.Nr (9 digits)");
  blockExecution = true;
}
ed.setBlockExecution(blockExecution);
```

Now we will first check if it is empty, then check if it consists of 9 digits, the script can give two different messages based on which case it hits.
