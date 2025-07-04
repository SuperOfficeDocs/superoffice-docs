---
title: Preview what will be synced
uid: preview_scim_sync
description: Preview what will be synced
author: SuperOffice Product and Engineering
date: 01.15.2024
keywords: SCIM, Microsoft Entra, ME-ID, AAD
content_type: howto
deployment: online
platform: web
index: true
---

# Preview what will be synced

Use the **Preview** tab to review the result of the current SCIM rule set.

Previewing synchronization is useful when you are defining your rules to explore the effect of a rule. It also gives you a clear view of how the provisioned users will appear in SuperOffice CRM Online.

## Pre-requisites

* You are [signed in to the SuperOffice Identity Manager][1]

## Preview all users

Open the **Preview** tab.

* At the top, you can see the total number of users received from Microsoft Entra ID (formerly AAD) and how many of those will be synced to SuperOffice.

* The table shows the result of applying the mapping currently set in the **User sync rules** pane.

You can filter, sort, and reorder the information shown in the table.

![Preview screen -screenshot][img1]

### Info from Microsoft Entra ID

* Name
* Username

### Info mapped by SCIM rules

* User plan
* Owner company
* Primary group
* Secondary group
* Role
* Confidential

## Sort and reorder preview

* To reorder the columns, select a column and then drag it to its new position.

* To sort the table, click on the column heading you want to sort it by. Clicking the same column multiple times will toggle between ascending and descending sort order.

![sort preview -screenshot][img2]

## Filter users in preview

If you have a lot of users, possibly extending multiple pages, or you want to drill down into 1 specific mapping, you can apply 1 or more filters.

A filter consists of a string and an operator and is located directly below the column header.

![Preview filter -screenshot][img3]

### Available operators

* Is (not) equal to
* Contains / Does not contain
* Starts / Ends with
* Is (not) null
* Is (not) empty

### To set a filter

1. Type at least 1 character in the text field.
2. Click the funnel icon and select an operator.

### To clear a filter

1. Click the stroked-through funnel icon.

<!-- Referenced links -->
[1]: ../sign-in-to-scim.md

<!-- Referenced images -->
[img1]: media/scim-preview-sync-company.png
[img2]: media/scim-preview-sort.png
[img3]: media/scim-preview-filter.png
