---
uid: crmscript-task-menu-open-external-company
title: Task menu - Open external system in new tab
description: Create a task menu item that opens an external system using CRMScript
keywords: CRMScript, task menu, external URL, browser tab
author: Eivind Fasting, David Hollegien
date: 06.02.2025
version: 10.5
content_type: tutorial
audience: settings
audience_tooltip: Settings and maintenance
---

# Task menu - Open external system in new tab

This tutorial explains how to create a Task menu item that opens a new browser tab linking to an external system, using a CRMScript to generate the URL dynamically.

By the end of this guide, you will have:

* Created a CRMScript that builds a URL with a contact's external ID.
* Configured a Task menu item to open this script result in a new tab.
* Verified that the Task menu opens the external page correctly.

This solution is especially useful when you want to integrate SuperOffice CRM with a third-party system and link entities via a shared ID.

> [!NOTE]
> In the SuperOffice data model, a **contact** refers to a **company**. Individuals associated with a contact are referred to as **persons**. This tutorial targets the `Contact` entity and the script uses the `contactId`, which refers to the company.

## Step 1: Create the CRMScript

We start by creating a CRMScript, which will be triggered via a Task menu item in SuperOffice.

1. Click <i class="ph ph-list" aria-label="Main menu"></i> on the top bar and select **Settings and maintenance**.

1. In the navigator, click <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** and go to the **Macros and scripts** tab.

1. Click **New script**, then fill in the **Information** tab:

    | Field | Value | Description |
    |---|---|---|
    | **Name** | Open contact external | Friendly name for the script |
    | **Description** | Opens an external customer page for the current contact | What this script does |
    | **Include name** | openContactExternal | Unique single-word identifier for the script |

1. Go to the **Script** tab and paste in the following code:

    ```crmscript
    #setLanguageLevel 4;

    Integer contactId = getCgiVariable("contactId").toInteger();

    if (contactId.isNull() == true || contactId < 1)
    {
        exitWithMessage("No contactId given");
    }

    NSContactAgent contactAgent;
    NSContactEntity contactEntity = contactAgent.GetContactEntity(contactId);
    Map contactCustomFields = contactEntity.GetCustomFields();

    String externalContactId = decodeDBValue(contactCustomFields.get("x_extra_field"));

    setVariable("url", "https://portal.mysystem.com/customers?customerId=" + externalContactId);
    ```

1. Click **OK** to save the script.

### Code explanation

* Read the current contact ID.
* Look up a custom field (`x_extra_field`) from the contact.
* Builds a URL to an external system.

## Step 2: Add a task menu item

Now that our script is ready, we need to add a **Task menu item** to trigger it.

1. In **Settings and maintenance**, go to <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lists**.

1. Find **Task menu** in the list selector and click **Add** to create a new item.

1. Fill out the dialog with these values:

    | Field | Value | Description |
    |---|---|---|
    | **Name** | Open contact external | Name of item in Task menu |
    | **Task menu** | Company | Where you want to show this item |
    | **Type** | URL | |
    | **URL** | `<csbl>?_sf=4&action=doScript&includeId=openContactExternal&contactId=<cuid>` | The `<cuid>` variable is automatically replaced with the current company's contact ID. This is passed to the script as `contactId`. |
    | **Show in SuperOffice CRM** | <i class="ph ph-check" aria-hidden="true"></i> (Checked) | |

    > [!NOTE]
    > Make sure to select the **URL** type. Choosing **CRMScript**, and therefore executing the script directly, will not open in a new tab.

1. Enable any other visibility settings as needed.

1. Click **Save**.

![Edit list item dialog with task menu URL set -screenshot][img1]

## Step 3: Use the task menu item

1. Open a **Company** card in SuperOffice CRM.

1. Click the **Task** menu button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>).

1. Select **Open contact external**.

![Task menu showing custom item -screenshot][img2]

The system should open a new browser tab with a URL like: `https://portal.mysystem.com/customers?customerId=12345`

## Summary

* We created a CRMScript that outputs a URL based on the contact's external ID.
* We configured a **Task menu item** to open this URL in a new tab.
* We tested the menu and confirmed it works as expected.

## Troubleshooting

* **Nothing happens when clicking the task menu item:**

    Make sure the **include name** is set correctly and the script is saved. The script must be saved with an include name that **exactly matches** what you use in the `includeId` parameter of the URL.

* **The script fails with "No contactId given":**

    Confirm that you are using `<cuid>` in the Task menu URL and that it resolves correctly. In this scenario, `<cuid>` will be passed as `contactId` to our script, which expects this value on line 3.

* **The external ID is empty:**

    Ensure that the `x_extra_field` value is populated for the contact you are testing.

## Related content

* [How to create a CRMScript][1]
* [How to create a Task menu item][2]
* [Template variables from Service][3]
* [Template variables from the Company card][4]

<!-- Reference links -->
[1]: ../../../automation/crmscript/overview/envir-and-tools.md
[2]: ../../../customization/admin/add-items-to-task-menu.md
[3]: ../../../document/templates/variables/for-service.md
[4]: ../../../document/templates/variables/from-company-card.md

<!-- Referenced images -->
[img1]: media/tut-add-task-menu-item-url.png
[img2]: media/tut-task-menu-openexternal-on-company.png
