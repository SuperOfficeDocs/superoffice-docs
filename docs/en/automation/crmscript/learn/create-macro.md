---
uid: help-en-automation-macro-create
title: Create a macro - example from SuperOffice
description: Example of how to create a macro in SuperOffice.
author: SuperOffice RnD
date: 03.16.2023
keywords: script, macro
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Create a macro - example from SuperOffice

Many companies often receive requests relating to invoicing. Such requests should go straight to the accounts department. Instead of editing every request and changing category and owner, we can create a macro that performs all these actions. The macro can be assigned to **Task** button in the Request screen. Invoice questions can thus be delegated to the accounts department with just one click.

> [!TIP]
> To fully automate this process, you can create an email filter to look for the word "invoice" in email subjects, and then run the macro to assign the request to the correct department.

We will now create a macro based on the example above.

## Steps

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Select <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** and the tab for **Macros and script**. Do one of the following:
    * To create a new macro: Click **New macro**.
    * To edit an existing macro: Click the macro name.

1. In the **Information** tab, enter "Send request to Accounts Dept." in the **Name** field and enter a description in the field below.

1. Check on the **New menu** option to make the macro available from the **Task** button in the Company screen, Contact screen, or Request screen, or the **Message** tab.

1. Go to the **Actions** tab and select **Choose action type** > **Change a request**.

1. Check **Category** and select a category in the list (for instance *Accounting*).

1. Check **Owner** and select a user.

    > [!TIP]
    > Alternatively, you can select **Automatically assigned** to allow the system to distribute the request according to current distribution rules.

1. Check **Internal message** and write a brief standard message to the accounts department about why they received this request.

1. Click **OK** when you are done.

## Related content

* [Learn more about advanced macro functions and triggers][1]

<!-- Referenced links -->
[1]: trigger.md
