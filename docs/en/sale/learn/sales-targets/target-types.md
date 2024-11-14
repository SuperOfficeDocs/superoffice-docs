---
uid: help-en-sales-target-types
title: Set up a sale target type with sub-types
description: Staying on top of your sales targets can be stressful. But if you define parameters and dimensions of your sales targets – managing your goals becomes much easier.
author: SuperOffice RnD
date: 02.16.2023
keywords: sale
topic: howto
language: en
---

# Set up a sale target type with sub-types

Staying on top of your sales targets can be stressful. But if you define parameters and dimensions of your sales targets – managing your goals becomes much easier.

You can add new target types (dimensions) in addition to the default target type **All sales - Amount**.

> [!NOTE]
> You will need Sales Premium license together with the Unlimited sales targets license to add more than one user group and target type. If you only have Sales Premium license you are able to add one group for the target type All sales - Amount.

You need to have the functional right Targets administrator for your role to add, edit and remove target types.

## Set target type

To define the parameters and dimensions you need to set up a target type, first.

You can set up a target type for both users and groups, as well as set other target parameters: Target type, Measurement unit, Separate targets. You can also define if it only should be available on the company and group level (and not on the user level).

![Overview of the different target types and sub-types for a sale target -screenshot][img1]

## Add new target type

1. Click **Add new target type**. Or click <i class="ph ph-gear" aria-label="Gear"></i> (**Configure target**) on the tab to edit an existing target type.

2. Click **Target type** to select the target type (dimension) you want to use.

3. Click **Measurement unit** to select the relevant unit. The available units will depend on the selected target type. If you selected **Category** as target type, you can for instance select to measure by amount or count (number of sales in a category).

4. In the next list, you can select specific elements of the target type you have selected. If you do not select any, all will be included. Example: If you selected **Category** as target type, you can select the company categories for which you want to create targets.

5. Select **Available on company level and group level only** if this target type should not be available on a user level, only for group/team level and company level.

6. Click **Save**. The new target type is added as a tab. You can now add targets as described above.

> [!NOTE]
> Target type and measurement unit cannot be changed in an existing target type. You can alternatively create a new target type with the required settings, and then delete the old one.

### Target types (parameters)

* All sales
* Sale type
* Sale source
* Sale credited
* Sale competitor
* Company category
* Company business
* Company country

You can also set targets for any of your own user-defined fields that contain lists. After a target type is selected, it is not possible to select that type of target again, to avoid creating duplicates.

### Measurement unit

You can measure a sale in different ways. Choose your preferred unit depending on what units your company use.

* Amount
* Count
* Profit

### Separate targets sub-types (dimensions)

The list available will depend on the target type selected. For example:

* If the Target type is set to Sale type, the target sub-types will show the list for sale types defined by your company.
* If the target type is set to Source, the target sub-types will show the list for sale sources defined by your company.

At the bottom of the dialogue is a checkbox for Available on company and group level only. When you mark this checkbox, the target type will only be added on the company and group level, and the different users will not appear in your target list.

> [!NOTE]
> When you have saved your new target, you can still go to Settings and change the Separate targets list and the checkbox for Available on company and group level only. Be aware that if you select Available on company and group level only after you have added numbers on the user level, you get a warning that the user numbers will be deleted when saved.

When the new target type is saved, it is time to [add groups and users to your sales target][3].

![You will find the Add groups and users button in the Sales target overview -screenshot][img2]

## Filter target types

When it comes to the target types with the target sub-type list, you can click the Filter button and filter on the different list items.

![Click the filter button to filter on target sub-type -screenshot][img3]

## Remove target types

To delete a target type, click on the Target settings and click the Delete button. Please, keep in mind that deleting a target type is a non-reversible action, and it will delete all data for the target type on previous, current and future years. The default target type All sales - Amount is not possible to delete.

## Related topics

* [Using sales targets in dashboard tiles][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md
[3]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/user-targets-new-target-type.png
[img2]: ../../../../media/loc/en/sale/user-targets-add-groups-users.png
[img3]: ../../../../media/loc/en/sale/user-targets-filter-type.png
