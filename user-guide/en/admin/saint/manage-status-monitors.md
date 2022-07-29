---
uid: help-en-manage-status-monitors
title: Manage status monitors
description: Manage status monitors
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance, sale, SAINT
so.topic: help
language: en
---

# Manage status monitors

[!include[Requirement](../includes/note-saint-req.md)]

The sections below contain information about how to enable and disable status monitors and how to regenerate statuses and counters. [!include[Define counter](../includes/def-counter.md)] See also **Counter fields** in [Use search criteria][1]).

## General information about updating and regenerating statuses and counters

At the bottom of the **Status monitors** tab, indicators (text which shows the date of the most recent generation, if the selected status or counter has never been generated, or whether the selected status should be regenerated because of changes) are displayed for the regeneration of statuses or counters.

You should regenerate statuses and/or counters if the indicators show that it is a long time since the last generation, or that the statuses and/or counters have never been generated. The same applies if statuses are amended. Statuses and counters that are not updated, will still be enabled and utilisable in SuperOffice CRM, but the dates returned will not necessarily be correct. The sections below described how to regenerate statuses and counters.

<details><summary>How to tell if it is updated?</summary>

If an item is not updated, it is shown as ![icon][img1] (statuses) and ![icon][img3] / ![icon][img4] / ![icon][img5] (counters) in SuperOffice CRM.
</details>

## Regenerate statuses

When you have added, edited or deleted a criterion (see [Select status criteria][2]), or if, for example, you have edited an intention for a task in SuperOffice CRM, a red cross ( ![icon][img6] ) is displayed in the status list to the left of the status(es) in question. Statuses marked with a red cross are not enabled.

You must then regenerate these statuses by clicking one of these buttons:

![icon][img2] **Regenerate selected status monitor** (bottom of the **Company**, **Contact** or **Project** tab): Click here to regenerate the selected status.

![icon][img2] **Regenerate all status monitors** (bottom of the **Status** tab): Click here to regenerate all statuses.

## Regenerate counter values

![icon][img2] **Regenerate all counters**: Click here to regenerate all counters.

<!-- Referenced links -->
[1]: ../options/using-search-criteria.md
[2]: select-status-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/status-inaktiv.bmp
[img2]: ../../../media/icons/pil-hoeyre.bmp
[img3]: ../../../media/icons/admin/saint-counter-company-dis.bmp
[img4]: ../../../media/icons/admin/saint-counter-project-dis.bmp
[img5]: ../../../media/icons/admin/saint-counter-sale-disabled.bmp
[img6]: ../../../media/icons/admin/roedt-kryss.bmp
