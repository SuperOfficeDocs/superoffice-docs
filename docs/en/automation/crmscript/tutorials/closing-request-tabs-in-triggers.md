---
uid: crmscript-closing-request-tabs-tutorial
title: Closing request tabs
description: Closing request tabs
author: kronicz
date: 24.01.2025
keywords: CRMScript, Automation, Triggers
topic: tutorial
---

# Closing request tabs using Triggers or Task menu

Managing requests efficiently is crucial for maintaining smooth operations and ensuring excellent customer support. In this tutorial, we’ll explore how you can streamline your workflow by using a Trigger or a Task Menu Item to automatically close a request tab after certain action in your system.

Whether you're looking to enhance productivity, reduce manual steps, or enforce specific business rules, this guide will provide you with the knowledge to implement a simple but effective automation. By the end, you’ll understand how to configure and apply these tools to create a more seamless ticket management process.

> [!NOTE]
> This requires version 10.5.2 or newer.

Let’s dive into a scenario:

1. Customer receives alot of spam and asks for an automation to quickly be able to process these requests with least amount of human interaction.
2. Proposed solution is to add a button to Request screen, that automatically will set request status to closed and close request tab in one operation.

## Implementation

We will start by creating a new CRMScript which will be used together with Task menu item.

* In Sales, click the burger menu in the top right corner and click **Settings and maintenance**. Then in the left menu, you can find CRMScript.
* In Service, click the cogwheel in the top right corner, click **System design** and then **CRMScript**.

1. Click the **New script** in the Macros and scripts pane.

2. In the Information pane fill out;

- **Name** : Mark as Spam (Friendly name of your script)
- **Description** : (Optional) Description of what this script does
- **Include name** : markAsSpam (Single word description of your script)

![script-information -screenshot][img1]
3. Change to Script pane

- In the textbox is where we will add our CRMScript code.

4. Save script by confirming with OK or Apply.

### Step 1: Adding CRMScript code

To accomplish this we will start by adding CRMScript below:

```crmscript
#setLanguageLevel 4;

EventData ed = getEventData();
String ticketId = ed.getInputValue("ActiveTicketId");

//Find default closed status 
NSListAgent listAgent;
NSTicketStatusEntity[] statuses = listAgent.GetTicketStatuses();
NSTicketStatusEntity requestStatus;

for(Integer i = 0; i < statuses.length();i++)
{
    if(statuses[i].GetStatus() == 2 && statuses[i].GetIsDefault() == true)
    {   
        requestStatus = statuses[i];
        break;
    }
}

NSTicketAgent agent;
NSTicketEntity request = agent.GetTicketEntity(ticketId.toInteger());
request.SetStatus(requestStatus);
agent.SaveTicketEntity(request);

ed.setStateValue("command:ticket.tab.close", ticketId);
```

### Step 2: Adding Task menu item

Now that we have created our script that will perform needed actions we need to create a Task menu item to trigger this script. This is done by navigating to Lists in **Settings and maintenance**.

1. Under lists you can find Task menu. To create a new item click **Add**
2. In dialog fill out:

- **Name:** Name of item in Task menu
- **Task menu:** Where you want to show this item
- Select CRMScript and choose script created above
- Check "Show in SuperOffice CRM"

![task-settings -screenshot][img2]
3. Confirm by clicking **Save**

Last action is to navigate back to main client and perform a flush by appending ?flush to URL. After this when opening a request you should see this new Task menu item in menu.

![task-settings -screenshot][img3]

When user is selecting this from Task menu it should automatically close request and close request tab in one operation.

Hopefully this has given a good overview of how to utilize this to automate tasks.

<!-- Referenced links -->
[img1]: media/tut-information-properties.png
[img2]: media/tut-add-task-menu-item.png
[img3]: media/tut-request-task-menu.png