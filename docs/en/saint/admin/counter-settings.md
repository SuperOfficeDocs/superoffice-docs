---
uid: help-en-saint-counters
title: Counters and counter settings
description: Define and configure counters for SAINT
keywords: SAINT, activity monitor, counter, period
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from:
  - /en/sale/saint/learn/admin/select-period-length
  - /en/saint/admin/select-period-length
---

# Counters and counter settings

[!include[Requirement](../includes/note-saint-req.md)]

A **counter** is a value such as the number of sales in a period or the date of the last completed sale. Counters can be used as search criteria to find companies, contacts, or projects.

You can specify the period (duration in days) for the following counters:

* Activities (completed or open)
* Sales (completed or open)
* Requests (completed or open, if your company has SuperOffice Service)

You can define up to three different periods. This lets you create SAINT criteria for shorter or longer time spans. For example, if you set **Period 1** to 30 days and **Period 2** to 90 days, you can use the criteria *Number of sales last 30 days* or *Number of sales last 90 days*.

## Steps

1. Open the **SAINT** screen in Settings and maintenance.

1. Select the **Counters** tab.

1. Under **Counter settings on…**, enter the period values for companies, contacts, and projects. The **From** date is displayed next to each period.

    ![Edit the SAINT counter settings in the Counters tab -screenshot][img1]

    The changes are saved automatically.

> [!NOTE]
> A period is always calculated from the last time the counters were regenerated. To keep results accurate, [regenerate counters frequently][2] (preferably nightly).

<!-- Referenced links -->
[2]: update.md#regen

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/counter-settings.png
