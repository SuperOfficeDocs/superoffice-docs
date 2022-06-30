---
uid: help-en-blogic-listeventhandler
title: blogic listEventHandler
description: blogic listEventHandler
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Triggers

Triggers are scripts that are executed for specific events in the system, such as when a new sale is created or a request gets closed. Triggers can react silently to what happens, or block the operation and show an explanation back to the user.

CRMScript can make your working day more efficient by automating various tasks. You can define that a certain event in the system will set in motion (trigger) one or more predefined actions. No knowledge of scripting is required to get this to work.

**Example from SuperOffice Service**: When a request is closed, the customer must be notified of this by e-mail. We can create a macro that contains a series of actionsto create and send this e-mail notification. This macro is run automatically when a request is closed. The actions in the macro will load the relevant request, fetch the right reply template and send an e-mail to the customer that the request is closed.

> [!TIP]
> This is an example of a very simple trigger. You can for instance add conditions to the actions in a trigger, by changing the default **Always** setting.

## Create a trigger

We will now create a series of actions based on the example above.

Do as follows:

1. In SuperOffice Service: Select ![icon](../media/globalmenu-settings-small.png)**System settings** &gt; **System design** &gt; **CRMScript** and go to the **Triggers** tab.  
    In SuperOffice Settings and maintenance: Click **CRMScript** in the navigator and go to the **Triggers** tab.
2. Click the **New trigger (macro)** button. The **Choose trigger** screen displays the available triggers. These are events in the system that can be used to set off actions/macros. In our example we select **Request closed**, so that the macro is run when a request is closed in SuperOffice Service.
3. Type "request" in the search field and select the trigger called **Request closed**.
4. Enter a description of the trigger in the **Description** field.
5. Select **Enabled**.
6. Select **Change a request** under **Choose action type** below. This takes you to the **Change a request** tab.  
    This will be the first action in the macro. The main purpose of this action is to fetch the request, so that the various values (ID, title, contact name and so on) can be used in the next actions we will create.
7. Optional: Check **Internal message**, and enter, for example: "Request closed and confirmation sent to customer."
8. Click **Apply**.
9. Click **New action** next to the **Change a request** tab.
10. Select **Load a reply template for merging**. We will now fetch the reply template to be used.
11. Click the **Reply template** field, and select an existing reply template from the list shown, such as "Request closed".
12. Click **Apply**.
13. Click **New action**, and select **Send an e-mail or SMS**. We will now adapt the e-mail that will be sent to the customer.
14. Check **Subject**.
15. Click the parameter icon ( ![icon](../media/btn-workflow.png) ) to the right, and then click the **Choose parameter** field.
16. Select **Change a request** &gt; **Title**. This will put the request title in the subject of the e-mail.
17. Check **From** and select **Change a request** &gt; **Owner**.
18. Check **To** and select **Change a request** &gt; **Contact: E-mail address**.
19. Check **HTML message** and select **Load a reply template for merging** &gt; **HTML text**.
20. Click **Apply**.

You have now created a macro that sends an e-mail with "Request closed" to the customer when a request is closed. This trigger will be active immediately if you checked **Enabled** at the top.
