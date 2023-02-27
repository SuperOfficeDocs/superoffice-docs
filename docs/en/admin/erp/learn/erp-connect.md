---
uid: help-en-erp-connect
title: Connect to ERP
description: Connect to ERP
author: SuperOffice RnD
so.date: 07.04.2022
keywords: ERP
so.topic: howto
language: en
---

# Connect to ERP

[!include[Requirement](includes/req-integration-server.md)]

You can connect a SuperOffice company to a customer/supplier in the ERP system. Contacts who are registered on the SuperOffice company can then be linked to individuals in the ERP system. Similarly, SuperOffice projects can be linked to projects in the ERP system. Data will then be synchronized between SuperOffice and the ERP system.

1. Go to the **Company** screen, **Contact** screen or **Project** screen, and select the **ERP** tab.

    > [!NOTE]
    > If the **ERP** tab contains company, contact or project information, a connection has already been set up between SuperOffice and the ERP system.

1. Click **Edit**. The options depend on if you are editing a company, a contact, or a project.
1. Company: Click **Customer** or **Supplier**, depending on which ERP actor you want to link the company to. You can choose only one actor per company.
    *Or* Project: Click **Project**.
    *Or* Contact: Click **Contact**.
1. In the **Connect to ERP** dialog, enter text to search for in the search field and click **Search**. You can also click the search button ![icon][img1] to initiate an advanced search (see [Use the Find screen][1]).

    > [!TIP]
    > If you search with a blank search field, all records in the ERP system are displayed.

1. Select an item in the hit list. If you don't get any hits, you can [create a new actor in the ERP system][2] based on data from SuperOffice CRM.
1. Click **Connect**. A dialog appears showing the data that will be synchronized between SuperOffice CRM and the ERP system. What data is displayed here is defined in SuperOffice Settings and maintenance.
1. If the data in the two systems are different, select the data that are correct.
    For example: If the street addresses are different, select the correct one. The other data will be overwritten.
1. Click **Connect**. This takes you back to the **ERP** tab where the synchronized data will now be displayed.
1. Click **Save**.
1. If you wish, click **Sync Now**.

## What would you like to do now?

* [Create an actor in the ERP system][2]
* [Disable synchronization][3]

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[2]: erp-create-new-actor.md
[3]: erp-sync-disconnect.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/search-icon-black.png
