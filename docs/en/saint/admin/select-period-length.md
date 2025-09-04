---
uid: help-en-select-period-length
title: Select period length
description: Select period length
keywords: SAINT, activity monitor, counter
author: SuperOffice RnD
date: 02.22.2023
version: 9
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from: /en/sale/saint/learn/admin/select-period-length
---

# Specify a period length

[!include[Requirement](../includes/note-saint-req.md)]

You can specify the period (duration in days) for the following counters:

* Number of completed/non-completed activities in period
* Number of completed/non-completed sales in period
* Number of completed/non-completed requests during period (if your company has any SuperOffice Service licences)

[!include[Define counter](../includes/def-counter.md)]

You can specify up to three different periods, so that you can choose between shorter or longer periods for the various SAINT criteria. For example: If you set **Period 1** to 30 days and **Period 2** to 90 days, you can for example choose between the SAINT criteria "Number of sales last 30 days" AND "Number of sales last 90 days".

## Steps

1. Open the **SAINT** screen.

2. Select the **Counters** tab.

3. Under **Counter settings on...** you specify the periods for companies, contacts and projects. The **From** date is displayed next to each period.

    ![Edit the counter settings in the Counters tab -screenshot][img1]

    The changes are automatically saved.

> [!NOTE]
> If you have set a period to 30 days, for example, the period will always be 30 days from the last time the counters were regenerated. You should therefore [regenerate the counters frequently][2] (preferably each night), so that the counters are as up-to-date as possible.

<!-- Referenced links -->
[2]: manage-status-monitors.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-counters.png
