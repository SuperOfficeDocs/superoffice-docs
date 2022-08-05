---
uid: help-en-erp-connect
title: ERP connect
description: ERP connect
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: help
language: en
---

# Connect to ERP

[!include[Requirement](../includes/req-integration-server.md)]

You can connect a SuperOffice company to a customer/supplier in the ERP system. Contacts who are registered on the SuperOffice company can then be linked to individuals in the ERP system. Similarly, SuperOffice projects can be linked to projects in the ERP system. Data will then be synchronised between SuperOffice and the ERP system.

[!include[To do this](../../includes/to-do-this.md)]

1. Go to the **Company** screen, **Contact** screen or **Project** screen, and select the **ERP** tab.

> [!NOTE]
> If the **ERP** tab contains company, contact or project information, a connection has already been set up between SuperOffice and the ERP system.

1. Click **Edit**. Which options are displayed here depends on whether you are editing a company, a contact or a project.
2. Company: Click **Customer** or **Supplier**, depending on which ERP actor you want to link the company to. You can only choose one actor per company.  
    *Or* Project: Click **Project**.
    *Or* Contact: Click **Contact**.
    The **Connect to ERP** dialog opens.
3. Enter text to search for in the search field and click **Search**. You can also click the search button ![icon][img1] to initiate an advanced search (see [Use the Find screen][1]).

> [!TIP]
> If you search with a blank search field, all records in the ERP system will be displayed.

1. Select an item in the hitlist. If you don't get any hits, you can create a new "actor" in the ERP system based on data from SuperOffice CRM. See [Create an actor in the ERP system][2].
2. Click **Connect**. A dialog appears showing the data that will be synchronised between SuperOffice CRM and the ERP system. What data is displayed here is defined in SuperOffice Settings and maintenance.
3. If the data in the two systems are different, select the data that are correct.  
    For example: If the street addresses are different, select the correct one. The other data will be overwritten.
4. Click **Connect**. This takes you back to the **ERP** tab where the synchronised data will now be displayed.
5. Click **Save**.
6. If you wish, click **Sync Now**.

## What would you like to do now?

* [Create an actor in the ERP system][2]
* [Disable synchronisation][3]

<!-- Referenced links -->
[1]: ../getting-started/Find-dialog.md
[2]: ERP-create-new-actor.md
[3]: ERP-sync-disconnect.md

<!-- Referenced images -->
[img1]: ../../../media/icons/globalmenu-search.png
