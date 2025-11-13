---
uid: help-en-lead-admin
title: Set up lead management
description: Learn how to enable, configure, and extend lead management in SuperOffice CRM.
keywords: lead management, lead setup, lead status, potential customer, sales process
author: digitaldiina
date: 12.11.2025
version: 11.6
content_type: overview
category: sale
topic: lead
license: salesessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: en
---

# Set up lead management

Lead management in SuperOffice CRM helps you track potential customers from first contact through qualification and into the sales process. To get started, administrators must configure which company categories use **Lead status**, review the available status values, and optionally extend tracking with marketing data.

> [!NOTE]
> The standard *Lead*, *Marketing qualified lead*, *Opportunity*, and *Lost opportunity* categories are included only in new databases.
> Existing customers must add or update categories manually to enable lead status.

## Step 1: Enable lead status on a company category

Lead status can only be used for categories that belong to the **Potential customer** group. Ensure that at least one category is set up this way before activating lead management.

1. Go to **Settings and maintenance** > **Lists** > **Company – Category**.
1. Either create a new category or edit an existing one.
1. Set the **Category group** to *Potential customer*.
1. Select **Enable lead status for this category**.
1. Click **OK** to save your changes.

![Enabling lead status for a category in the Company – Category list, with the Potential Customer group selected. -screenshot][img1]

For details, see [Company category and category group][1].

## Step 2: Customize the lead status list

The **Contact – Lead status** list defines the qualification stages used by your organization. By default, SuperOffice includes statuses such as *Open*, *Contacting*, *Qualified*, *Disqualified*, and *Re-nurture*.

1. Go to **Settings and maintenance** > **Lists** > **Contact – Lead status**.
1. Review the predefined items.
1. Add, edit, or remove statuses to match your own lead qualification process.

    For example, you may want to add more detailed disqualification reasons, such as "Not interested", "Not an ICP", or "Bad timing".

For detailed steps, see [Manage lead statuses][2].

## Step 3: (Optional) Extend with Marketing Premium

If you use Marketing Premium, you can leverage additional tracking and automation features in your lead process:

* **UTM tracking:** Capture the source of new leads from online forms.
  See [Track form UTM data][3].

* **Lead nurturing flow:** Distribute new leads automatically to associates.
  See [Distribute new leads][4].

## Related content

* [Lead management overview][5]
* [Company category and category group][1]
* [Manage lead statuses][2]

<!-- Referenced links -->
[1]: add-company-category.md
[2]: add-lead-status.md
[3]: ../learn/index.md
[5]: ../../marketing/utm/admin/set-up.md
[4]: ../../marketing/flows/learn/define-flow-actions.md#distribute

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/enable-lead-status.png
