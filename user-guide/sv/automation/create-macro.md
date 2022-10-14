---
uid: help-en-automation-macro-create
title: Create a macro
description: Create a macro
author: SuperOffice RnD
so.date: 06.29.2022
keywords: script, macro
so.topic: howto
language: sv
---

# Create a macro

**Example from SuperOffice Service:**

Many companies often receive requests relating to invoicing. Such requests should go straight to the accounts department. Instead of editing every request and changing category and owner, we can create a macro that performs all these actions. The macro can be assigned to ![icon][img1] **Actions** in the **Request** screen. Invoice questions can thus be delegated to the accounts department with just one click.

> [!TIP]
> To fully automate this process, you can create an e-mail filter to look for the word "invoice" in e-mail subjects, and then run the macro to assign the request to the correct department.

We will now create a macro based on the example above.

1. Go to the **Macros and scripts** tab:

    * In SuperOffice Settings and maintenance: Click **CRMScript** in the navigator.
    * In SuperOffice Service: Select ![icon][img2] **System settings** > **System design** > **CRMScript**.

2. Do one of the following:
    * To create a new macro: Click **New macro**.
    * To edit an existing macro: Click the macro name.

3. In the **Information** tab, enter "Send request to Accounts Dept." in the **Name** field and enter a description in the field below.

4. Select the **New menu** option to make the macro available from the **Actions** button (![icon][img1]) in the **Company** screen, **Contact** screen or **Request** screen, or **Message** tab.

5. Go to the **Actions** tab and select **Change a request** under **Choose action type**.

6. Check **Category** and select a category in the list (for instance *Accounting*).

7. Check **Owner** and select a user.

    > [!TIP]
    > Alternatively, you can select **Automatically assigned** to allow the system to distribute the request according to current distribution rules.

8. Check **Internal message** and write a brief standard message to the accounts department about why they have received this request.

9. Click **OK** when you are done.

Some of the more advanced macro functions are described in [Triggers][1].

<!-- Referenced links -->
[1]: trigger.md

<!-- Referenced images -->
[img1]: ../../media/icons/btn-menu.png
[img2]: ../../media/icons/globalmenu-settings-small.png

