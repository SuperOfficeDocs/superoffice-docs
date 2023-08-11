---
uid: help-en-manage-status-monitors
title: Manage status monitors
description: Manage status monitors
author: SuperOffice RnD
so.date: 02.22.2023
keywords: sale, SAINT
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Manage status monitors

[!include[Requirement](../includes/note-saint-req.md)]

When you set up multiple status monitors and different periods/counters, it is important to have a regular check on them to make sure that the counters and statuses are regenerated and updated, and the [criteria][1] are correct on the different statuses.

The sections below contain information about how to enable and disable status monitors and how to regenerate statuses and counters. [!include[Define counter](../../../learn/includes/def-counter.md)]

## General information about updating and regenerating statuses and counters

At the bottom of the **Status monitors** tab, indicators (text which shows the date of the most recent generation, if the selected status or counter has never been generated, or if the selected status should be regenerated because of changes) are displayed for the regeneration of statuses or counters.

You should regenerate statuses and/or counters if the indicators show that the last generation was a long time ago, or that the statuses and/or counters have never been generated. The same applies if statuses are amended. Statuses and counters that are not updated, will still be enabled and useable in SuperOffice CRM, but the dates returned will not necessarily be correct. The sections below described how to regenerate statuses and counters.

### How to tell if it is updated

If an item is not updated, it is shown as ![icon][img1] (statuses) and ![icon][img3] / ![icon][img4] / ![icon][img5] (counters) in SuperOffice CRM.

## Regenerate statuses

When you have [added, edited, or deleted a criterion][2], or if, for example, you have edited an intention for a task in SuperOffice CRM, a red cross ( ![icon][img6] ) is displayed in the status list to the left of the status(es) in question. Statuses marked with a red cross are not enabled.

You must then regenerate these statuses by clicking one of these buttons:

| Icon | Name | Description | Location
|---|---|---|---|
| ![icon][img2] | Regenerate selected status monitor | Select to regenerate the selected status | Bottom of the **Company**, **Contact**, or **Project** tab |
| ![icon][img2] | Regenerate all status monitors | Select to regenerate all statuses | Bottom of the **Status** tab |

## Regenerate counter values

| Icon | Name | Description |
|---|---|---|
| ![icon][img2] | Regenerate all counters | Select to regenerate all counters |

<!-- Referenced links -->
[1]: ../../../../search-options/learn/search-criteria.md
[2]: select-status-criteria.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/admin/status-inactive.png
[img2]: ../../../../../media/icons/arrow-right.png
[img3]: ../../../../../media/icons/admin/saint-counter-company-dis.png
[img4]: ../../../../../media/icons/admin/saint-counter-project-dis.png
[img5]: ../../../../../media/icons/admin/saint-counter-sale-disabled.png
[img6]: ../../../../../media/icons/admin/red-x.png
