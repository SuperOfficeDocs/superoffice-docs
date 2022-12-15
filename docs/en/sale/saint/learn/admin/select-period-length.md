---
uid: help-en-select-period-length
title: Select period length
description: Select period length
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance, sale, SAINT
so.topic: help
language: en
---

# Specify a period length

[!include[Requirement](../includes/note-saint-req.md)]

You can specify the period (duration in days) for the following [counters][1]:

* Number of completed/non-completed activities in period
* Number of completed/non-completed sales in period
* Number of completed/non-completed requests during period (if you are using SuperOffice Service)

[!include[Define counter](../../../includes/def-counter.md)]

You can specify up to three different periods, so that you can choose between shorter or longer periods for the various SAINT criteria. For example: If you set **Period 1** to 30 days and **Period 2** to 90 days, you can for example choose between the SAINT criteria "Number of sales last 30 days" AND "Number of sales last 90 days".

1. Open the **SAINT** screen.

2. Select the **Counters** tab.

3. Under **Counter settings on...** you specify the periods for companies, contacts and projects. The **From** date is displayed next to each period.

    The changes are automatically saved.

> [!NOTE]
> If you have set a period to 30 days, for example, the period will always be 30 days from the last time the counters were regenerated. You should therefore regenerate the counters frequently (preferably each night), so that the counters are as up-to-date as possible. See [Manage status monitors][2].

<!-- Referenced links -->
[1]: ../../../../admin/settings/options/using-search-criteria.md
[2]: manage-status-monitors.md

<!-- Referenced images -->
