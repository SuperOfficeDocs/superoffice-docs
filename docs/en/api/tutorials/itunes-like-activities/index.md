---
uid: tutorial-itunes-like-activities
title: Tutorial - iTunes-like client for activities
description: In this tutorial, you will learn how to create a Windows application that retrieves a list of activities for the past 6 months of the logged-in user using the ActivityArchiveProvider.
keywords: iTunes, ActivityArchiveProvider
date: 03.21.2022
version: 10
content_type: tutorial
language: en
---

# Tutorial - iTunes-like client for activities

## Step 1: Introduction

This Windows application retrieves a list of activities for the past 6 months of the logged-in user. It also supports filtering the activities based on user input.

Steps 2 and 3 explain how to retrieve activity information using the Activity Archive Provider and convert the retrieved information into a format that can be displayed in a data grid.

The code segments use the **SuperOffice.CRM.ArchiveLists.ActivityArchiveProvider** to retrieve the activities.

## Step 2: Prepare parameters

[!include[Content: prepare parameters](includes/steps/prepare-parameters.md)]

## Step 3: Convert

[!include[Content: convert](includes/steps/convert.md)]

## Step 4: Filter the grid

[!include[Content: filtering the grid](includes/steps/filter-grid.md)]

## Step 5: Summary

When we're done, it should look like this:

![iTunes tutorial result -screenshot][img1]

## See also

* [SuperOffice iCal Feed][1]

<!-- Referenced links -->
[1]: ../so-ical-feed/index.md

<!-- Referenced images -->
[img1]: media/image023.jpg
