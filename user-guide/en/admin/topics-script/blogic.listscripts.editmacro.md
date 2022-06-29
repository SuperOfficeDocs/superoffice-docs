---
uid: help-en-blogic-listscripts-editmacro
title: blogic listScripts editMacro
description: blogic listScripts editMacro
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Create a macro

Macros have a number of functions in SuperOffice. They can be linked to specific [triggers](blogic.listEventHandler.md) in the system (such as escalations or new message on request in SuperOffice Service) or be assigned to buttons in defined screens, so that users can click a button to perform a set of actions that are often repeated. This makes request management faster and users avoid unnecessary clicking.

For example, you can use macros

* as a task/function in a menu point (such as in ![icon](../media/btn-Menu.png)**Actions** in the **Request** screen)
* when a request is escalated via the warning levels for priority
* as a planned task
* when they are activated by an e-mail filter
* when a recipient clicks a tracked link in a mailing

**Example from SuperOffice Service:** Many companies often receive requests relating to invoicing. Such requests should go straight to the accounts department. Instead of editing every request and changing category and owner, we can create a macro that performs all these actions. The macro can be assigned to ![icon](../media/btn-Menu.png) **Actions** in the **Request** screen. Invoice questions can thus be delegated to the accounts department with just one click.

> [!TIP]
> To fully automate this process, you can create an e-mail filter to look for the word "invoice" in e-mail subjects, and then run the macro to assign the request to the correct department.

We will now create a macro based on the example above.

1. In SuperOffice Service: Select ![icon](../media/globalmenu-settings-small.png)**System settings** &gt; **System design** &gt; **CRMScript** and go to the **Macros and scripts** tab.  
    In SuperOffice Settings and maintenance: Click **CRMScript** in the navigator and go to the **Macros and scripts** tab.

2. Do one of the following:
    * To create a new macro: Click **New macro**.
    * To edit an existing macro: Click the macro name. See [View a script/macro](View-script-macro.md).

3. In the **Information** tab, enter "Send request to Accounts Dept." in the **Name** field and enter a description in the field below.

4. Select the **New menu** option to make the macro available from the **Actions** button (![icon](../media/btn-Menu.png)) in the **Company** screen, **Contact** screen or **Request** screen, or **Message** tab.

5. Go to the **Actions** tab and select **Change a request** under **Choose action type**.

6. Check **Category** and select a category in the list (for instance *Accounting*).

7. Check **Owner** and select a user.

    > [!TIP]
    > Alternatively, you can select **Automatically assigned** to allow the system to distribute the request according to current distribution rules.

8. Check **Internal message** and write a brief standard message to the accounts department about why they have received this request.

9. Click **OK** when you are done.

Some of the more advanced macro functions are described in [Triggers](blogic.listEventHandler.md).
