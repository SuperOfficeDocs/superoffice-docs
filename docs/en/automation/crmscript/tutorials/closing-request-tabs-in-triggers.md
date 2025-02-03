---
uid: crmscript-mark-request-as-spam-tutorial
title: Task menu - Mark request as spam
description: Closing Request tabs using triggers or Task menu
keywords: CRMScript, automation, trigger, Request tab, mark as spam
author: kronicz
date: 02.11.2025
version: 10.5.2
topic: tutorial
audience: settings
audience_tooltip: Settings and maintenance
---

# Task menu - Mark request as spam

Managing support requests efficiently is crucial for maintaining smooth operations and delivering excellent customer support. In this tutorial, we'll explore how you can streamline your workflow by using a trigger or a Task menu item to automatically close a Request tab after certain action in your system.

With this automation, you can reduce manual steps, improve productivity, and enforce specific business rules. By the end, you'll be able to:

* Automatically mark a request as closed.
* Instantly close the Request tab after processing.
* Improve efficiency for handling repetitive tasks, such as spam requests.

> [!NOTE]
> This functionality requires SuperOffice version 10.5.2 or newer.

## Scenario: Automating spam request handling

A company receives a high volume of spam requests and wants an automation that allows agents to close these requests with minimal manual effort.

### Proposed solution

We will add a button to the Request screen that:

1. Automatically sets the request status to "Closed".
1. Closes the active **Request** tab in the SuperOffice interface.

## <a id="implementation"></a>Step 1: Creating the CRMScript

We start by creating a CRMScript, which will be triggered via a Task menu item in SuperOffice.

1. Click <i class="ph ph-list" aria-label="Main menu"></i> on the top bar and select **Settings and maintenance**.

1. In the navigator, click <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** and go to the **Macros and scripts** tab.

1. Click the **New script** button.

1. Fill in the following details in the **Information** tab:

    | Field | Value | Description |
    |---|---|---|
    | **Name** | Mark as Spam | Friendly name for the script |
    | **Description** | Automatically closes a request and request tab | What this script does |
    | **Include name** | markAsSpam | Unique single-word identifier for the script |

    ![script-information -screenshot][img1]

1. Go to the **Script** tab. This is where we will add our CRMScript code.

1. Click **OK** or **Apply** to save.

## Step 2: Adding CRMScript code

Copy and paste the following code into the **Script** tab:

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

### Code explanation

* Retrieve the active request ID.
* Find the default "Closed" status in SuperOffice.
* Update the request status to "Closed".
* Close the Request tab in the user interface.

Click **OK** to save your script.

## Step 3: Creating a Task menu item

Now that our script is ready, we need to add a **Task menu item** to trigger it.

1. In **Settings and maintenance**, go to <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lists**.

1. Find **Task menu** and click **Add** to create a new item.

1. Fill in the following details:

    | Field | Value | Description |
    |---|---|---|
    | **Name** | Mark as Spam | Name of item in Task menu |
    | **Task menu** | Request screen | Where you want to show this item |
    | **Type** | CRMScript | |
    | **Script** | Mark as Spam | Choose the script created earlier |
    | **Show in SuperOffice CRM** | <i class="ph ph-check" aria-hidden="true"></i> (Checked) | |

    ![Task menu settings -screenshot][img2]

1. Click **Save** to confirm.

## Step 4: Activating the changes

To ensure the new menu item appears, refresh the SuperOffice client:

1. Open SuperOffice CRM in a web browser.
2. Append `?flush` to the URL and press **Enter**.

## Step 5: Testing the automation

1. Open a **Request** in SuperOffice.
1. Click the **Task menu** button (<i class="ph ph-list" aria-hidden="true"></i>) and select **Mark as Spam**.
1. The request should:
    * Be marked as **Closed**.
    * The **Request** tab should close automatically.

![Task menu item -screenshot][img3]

## Summary

* We created a **CRMScript** to automate request closures.
* We added a **Task menu item** to trigger the script.
* We refreshed the system and tested the automation.

### Troubleshooting

* If the option does not appear in the **Task** menu, ensure you performed a flush (?flush).
* If the request does not close, verify the script is assigned correctly in the Task menu.

Now you can easily automate request management and enhance productivity!

<!-- Referenced links -->
[img1]: media/tut-information-properties.png
[img2]: media/tut-add-task-menu-item.png
[img3]: media/tut-request-task-menu.png
