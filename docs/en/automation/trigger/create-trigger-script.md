---
title: Creating a trigger - Script
uid: create_trigger_script
description: Creating a trigger - Script
author: Simen Mostuen Iversen
date: 06.06.2019
keywords: automation
topic: howto
---

# Creating a trigger :: Script

Regardless of which type of trigger you want to create, there’s one piece of code that you’ll need to know:

```crmscript
EventData ed = getEventData();
```

This code will allow you to fetch variables being used in the current context.

Let’s create a trigger that will stop the user from saving a company unless the organization number is filled out.

1. Click the **New trigger (script)** in the trigger pane. In the search box, type **Before saving company** and click the trigger.

2. The **Description** field should contain a short description of what your trigger is doing, in this case, I’ll write **Validate OrgNr**.
    * If you want this trigger to be enabled, remember to click the toggle box on the right side.

3. In the textbox below, we can write whatever we want, although if you insert code that is not supported by CRMScript, it will give you an error message when clicking the **OK** button.

4. The full code for preventing a save unless the organization number is filled out, could look something like this:

```crmscript
// Get the variables in the current context
EventData ed = getEventData();

// Get the input value from the current company
String orgNr = ed.getInputValue("ContactEntity.OrgNr");

// If the orgNr field is empty, block save with a message
if(orgNr.isEmpty())
{
  ed.setMessage("Please type in a Org.Nr");
  ed.setBlockExecution(true);
}
```

You will now receive an error message unless you enter something in the **Org.nr** field.

> [!TIP]
> You can also [create this trigger using a macro][1].

## What if I don’t know the name of the input value I want to fetch?

My preferred way of finding out which fields I’ve got access to is by using the Trace function.

1. Save your script by clicking **OK** (Verify that you don’t get any error messages)

2. In the button row above the script, click on the **Trace script** button.

3. Verify that the **Description** field is not empty and the **Enabled** checkbox is checked, use the User filter if you want a user-specific trace, and click **OK**.

    Now you’ve activated tracing on the script that you’ve just created, and this enables you to go through the script step-by-step to see which variables you’ve got access to. For easy access, keep this tab open for now.

4. In Sales (in a new tab), go to a company card, click **Edit** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>), and then click **Save** so that the trigger will run the script.

5. Go back to the tab where you have the trace, and click **Refresh**. You should be able to find a new row in the trace of the trigger you’ve just created, click the row.

    *On the left side, you’ve got the script, with a blue line displaying which row you’re tracing. The right side displays all available variables, with a … which you can click to expand.

    * If you have the `EventData ed = getEventData();` code you should be able to see an `ed …` on the right side, and if you click this you should be able to see `inputValues …` – expand this as well.

Now you can see all the various input values available for you in the current context.

In this scenario, we wanted to know the input value for the organization number, which in SuperOffice is called OrgNr: `ContactEntity.OrgNr`.

Click **Return** in the button row, and then click **Trigger** to go back to the script that you've started and click **Edit**.

<!-- Referenced links -->
[1]: create-trigger-macro.md
