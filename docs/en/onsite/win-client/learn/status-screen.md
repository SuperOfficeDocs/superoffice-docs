---
uid: help-en-status-screen
title: Status screen
description: Status screen
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client settings
topic: help
language: en
client: win
envir: onsite
---

# The Status screen

Updated information about the system is displayed in the **Status** screen. The **Status** screen is divided into the following main sections:

## Database

Shows the database owner, serial number and type, which are specified on installation. It also shows if it is a central database or a satellite database. You can see the next expiry date (when the licence needs to be renewed) and the name of the user currently logged in.

**Table admin: Local database user**: Specify the user name and password of the database user (it does not have to be a SuperOffice CRM user) which will automatically be used by the system to create and delete database tables. This user does not need to have any other rights.

> [!NOTE]
> For Oracle databases, this must be the same user who owns the tables, and who is used as a prefix in **SuperOffice.ini**.

## Statistics

Shows how many users are currently logged in, when the last prototype was generated, and the number of active Travel users.
