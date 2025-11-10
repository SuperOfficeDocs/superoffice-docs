---
uid: zapier-create-zap
title: Create a Zap
description: How-to guide for making "Zaps" for Superoffice CRM.
keywords: Make Zap, create zap, Zapier trigger
author: miguellemos95
date: 11.06.2025
content_type: howto
category: integration
topic: Zapier
platform: Zapier
language: en
redirect_from: /en/automation/zapier/get-started/create-zap
---

# Create a Zap with SuperOffice CRM

This example demonstrates how to create a Zap that triggers when a sale is marked as sold in SuperOffice CRM.

## Define trigger

[!include[create zap step](../howto/includes/create-zap-intro.md)]

1. In the Trigger step, select **SuperOffice CRM** as the trigger application.

1. Choose a trigger and select **Save + Continue**.

    For this example, select **Sale Changed**.

    ![Select SuperOffice CRM Trigger -screenshot][img1]

1. Select the tenant (database) to link:

    * Choose one of the listed accounts, or
    * Select Connect a **Connect a new Account** to link another tenant.

    ![Select SuperOffice CRM Account -screenshot][img2]

1. Select **Save + Continue**.

1. Define the change (event) that should trigger the Zap. The available options depend on the previously selected trigger.

    ![Set up SuperOffice CRM sale -screenshot][img3]

    For this example, select **Sale Status Changed To Sold**.

    ![Sale Status Changed To Sold -screenshot][img4]

1. Select **Continue**.

1. Review the selected record. Select the **record** entry to display additional information.

    ![Selected record details -screenshot][img5]

1. Continue by selecting **Continue With selected record**.

    ![Records found -screenshot][img6]

The **Trigger** step is now complete. Continue to the **Action** step to define the target location for the updated sale information.

## Define action

Select an **Action** step to determine where the updated sale data from SuperOffice CRM will be sent.

![Almost finished here! -screenshot][img7]

## Troubleshooting

### Issues When Retrieving Data Samples

If connecting to SuperOffice and retrieving data samples fails, the issue may be caused by insufficient administrator permissions for the connected account. These permissions are required to use triggers, actions, and searches.

Workaround: Connect using an account with the necessary administrator rights to the SuperOffice tenant.

**Note:** Zaps can modify SuperOffice data extensively. For instance, misconfigured Zaps can create duplicate records. Proper configuration helps prevent such issues.

[img1]: media/all-crm-triggers.png
[img2]: media/pick-account.png
[img3]: media/sale-change-event-options.png
[img4]: media/sale-changed-trigger-when-example.png
[img5]: media/selected-record-details.png
[img6]: media/sale-changed-trigger-record.png
[img7]: media/complete-zap-with-action.png
