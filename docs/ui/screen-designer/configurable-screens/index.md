---
uid: configurable-screens
title: Configurable screens
description: Configurable screens
author: Bergfrid Dias
so.date: 10.04.2022
keywords: ui, screen, customization
so.topic: concept
so.version: 10
so.envir:
so.client:
---

# Configurable screens

[!include[Requirement](../../../../common/includes/req-dev-tools.md)]

**Configurable screens** gives CRM Administrators a unified way of customizing the SuperOffice CRM user interface.

## Which screens can I configure?

* Company
* Contact
* Sale
* Project

## What can I customize?

* Modify the default (system) layout of one or more screens for all users to fit the specific needs of your organization.

* Add personalized views for user groups to make them more effective.
* Design layouts optimized for specific project types and sales types.
* Hide fields that are never used.
* Give easy access to important custom fields.
* Add custom buttons and links. For example, to run a CRMScript.
* Organize custom fields in the **More** tab.
* Add tabs for fields related to a specific area.
* Remove unused tabs.

## Layouts

The default (system) layout applies to all users unless you have created and assigned custom layouts to some users.

In addition, you can [add custom layouts][2] and assign them to a user group. Layouts in the **Sales** screen can alternatively be assigned to a **sales type**. Layouts in the **Project** screen can alternatively be assigned to a **project type**.

Layouts have status *published* or *draft*.


![Screen Designer draft layout -screenshot][img1]

![Screen Designer published layout -screenshot][img2]

## More tab

The **More** tab has all custom fields ordered by rank. You probably want to go through and organize these. You can add important custom fields other places.

User-defined fields (udef) and extra fields are created as before.

<!-- Referenced links -->
[2]: add-layout.md

<!-- Referenced images -->
[img1]: media/status-draft.png
[img2]: media/status-published.png