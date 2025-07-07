---
uid: help-en-erp-connect-actor
title: Connect to ERP
description: Connect to ERP
keywords: connect to ERP, connect company to ERP, connect contact to ERP, connect project to ERP, can't find match in ERP, create in ERP, create actor, ERP actor, ERP
author: SuperOffice RnD
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/admin/erp/learn/erp-connect
  - /en/admin/erp/learn/erp-create-new-actor
---

# Connect to ERP

[!include[Requirement](../../includes/req-dev-tools.md)]

You can connect a SuperOffice company to a customer/supplier in the ERP system. Contacts who are registered on the SuperOffice company can then be linked to individuals in the ERP system. Similarly, SuperOffice projects can be linked to projects in the ERP system. Data will then be synchronized between SuperOffice and the ERP system.

1. Go to the Company screen, Contact screen or Project screen, and select the **ERP** tab.

    If the **ERP** tab contains company, contact or project information, a connection has already been set up between SuperOffice and the ERP system.

1. Click **Edit**. The options depend on if you are editing a company, a contact, or a project.
1. Company: Click **Customer** or **Supplier**, depending on which ERP actor you want to link the company to. You can choose only one actor per company.
    *Or* Project: Click **Project**.
    *Or* Contact: Click **Contact**.
1. In the **Connect to ERP** dialog, enter text to search for in the search field and click **Search**. You can also click the search button (<i class="ph ph-magnifying-glass" aria-hidden="true"></i>) to initiate an [advanced search][1].

    If you search with a blank search field, all records in the ERP system are displayed.

1. Select an item in the hit list. If you do not get any hits, you can [create a new actor in the ERP system](#create-actor) based on data from SuperOffice CRM.
1. Click **Connect**. A dialog appears showing the data that will be synchronized between SuperOffice CRM and the ERP system. What data is displayed here is defined in SuperOffice Settings and maintenance.
1. If the data in the two systems are different, select the data that are correct.
    For example: If the street addresses are different, select the correct one. The other data will be overwritten.
1. Click **Connect**. This takes you back to the **ERP** tab where the synchronized data will now be displayed.
1. Click **Save**.

## <a id="create-actor"></a>Create an actor in the ERP system

If for example customer does not exist in the ERP system, you can create the customer in the ERP system based on the data from SuperOffice.

> [!NOTE]
> The **Create** button is disabled if SuperOffice is not allowed to create actors in the ERP system.

1. In the **Connect to ERP** dialog, select **Can't find match in ERP** at the bottom and click **Create**. The **Create in ERP** dialog appears.
1. Enter the values as required.
1. Click **Create**. This takes you back to the **ERP** tab where the synchronized data will now be displayed.
1. Click **Save**.

## Related content

* [Disable synchronization][3]

<!-- Referenced links -->
[1]: ../../search-options/learn/find-screen.md
[3]: disconnect.md

<!-- Referenced images -->
