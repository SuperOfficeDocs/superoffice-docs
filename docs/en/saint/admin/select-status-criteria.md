---
uid: help-en-select-status-criteria
title: Select status criteria
description: Select status criteria
keywords: SAINT, activity monitor
author: SuperOffice RnD
date: 02.22.2023
version: 9
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Specify status criteria

[!include[Requirement](../includes/note-saint-req.md)]

A status is active only for companies, contacts, or projects that fulfil all the criteria specified for the status. You must specify one or more criteria for each status you create.

Spend some time to set up the correct status criteria, as you need to make sure that these criteria accurately filter the group of companies (contacts or projects) that you want to monitor.

## Steps

1. [!include[Open SAINT](includes/open-saint-select-tab.md)]

1. Select the required status in the status list on the left of the screen.

1. Click **Add** in the list in the bottom-right (under the **Description** tab and **Create follow-up** tab). A new line is added to the list.

1. Click <i class="ph ph-caret-down" aria-label="Chevron"></i> next to the empty field, and [select the required search criterion][1].

1. Repeat steps 4 and 5 for each criterion you want to add.

    > [!NOTE]
    > You can add only one instance of each criteria type for each status. For example, you cannot add the **Postcode** criterion twice.

1. Check that you have selected the criteria you want to use for this status.

1. Click <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Regenerate selected status monitor** to update the status with the criteria you added. After the status is regenerated, no red cross is shown by the status name.

## What would you like to do now?

* [Manage status monitors][2]

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: manage-status-monitors.md
