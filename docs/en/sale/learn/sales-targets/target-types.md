---
uid: help-en-sales-target-types
title: Set up a sale target type with sub-types
description: Staying on top of your sales targets can be stressful. But if you define parameters and dimensions of your sales targets – managing your goals becomes much easier.
keywords: sales target, dimension
author: SuperOffice Product and Engineering
date: 09.19.2025
version: 10.5
content_type: howto
license: salespremium, Unlimited sales targets
functional_right: Targets administrator
deployment: online
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Set up a sale target type with sub-types

Staying on top of your sales targets can be stressful. But if you define parameters and dimensions of your sales targets – managing your goals becomes much easier.

By default, SuperOffice includes one target type: **All sales – Amount**. You can add custom target types based on sales data, company details, or user-defined fields.

## Requirements

You must have the functional right **Targets administrator** to add, edit, or delete target types.

> [!NOTE]
> To add target types, you need the Unlimited sales targets license in addition to the Sales Premium license.

## Available target types

A **target type** defines what you want to measure. You can choose from the following system-defined dimensions:

* All sales
* Sale type
* Sale source
* Sale credited
* Sale competitor
* Company category
* Company business
* Company country

You can also use your own user-defined fields, if they contain list values.

**Each dimension can only be used once to prevent duplicates.**

## Add a new target type

1. Click <i class="ph ph-list" aria-label="Main menu"></i> and select **Targets**.

1. In the **Targets** screen, click **Add new target type** to define a custom sales dimension. You can also click <i class="ph ph-gear" aria-label="Gear"></i> (**Configure target**) on an existing tab to edit it.

    ![Targets screen with Add new target type button -screenshot][img4]

1. Click **Target type** to select the dimension to track, such as **Sale source** or **Company category**.

    ![Target settings dialog for creating a new target type -screenshot][img1]

1. Click **Measurement unit** to choose how results are calculated:

    * **Amount:** Total value of sales
    * **Count:** Number of sales
    * **Profit:** Profit margin

    The options depend on the selected target type.

1. Under **Separate targets**, choose specific sub-types to track separately. The options depend on the selected target type.

    For Example, if the target type is **Category**, the sub-types are your company categories.

1. Select the checkbox **Available on company level and group level only** if this target type should not be available at the user level.

1. Click **Save**. The target type is added as a tab. You can now [add groups and users to your sales target][3].

## Remove a target type

To delete a target type:

1. Open **Target settings** from the relevant tab.
2. Click **Delete**.

> [!WARNING]
> Deleting a target type permanently removes all related data for all years - previous, current, and future. You cannot delete the default type **All sales – Amount**.

## Tips and troubleshooting

* After saving, the target type and measurement unit cannot be changed. To adjust these settings, create a new target type and delete the old one.

* You can edit the **Separate targets** list and the **Available on company level and group level only** checkbox after saving.

    > [!NOTE]
    > If you enable company/group-only availability after entering values on the user level, a warning appears. Saving this change will delete the user-level targets.

## Related content

* [Add groups and users to your sales target][3]
* [Using sales targets in dashboard tiles][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md
[3]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/target-settings.png
[img4]: ../../../../media/loc/en/sale/add-new-target-type-button.png
