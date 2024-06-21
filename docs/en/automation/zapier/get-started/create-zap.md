---
uid: zapier-create-zap
title: Create a Zap
description: How-to guide for making "Zaps" for Superoffice CRM.
author: Philip Yates
date: 08.09.2023
keywords: Zapier, Zap, automation, sale
topic: howto
language: en
client: Zapier
---

# Create a Zap with SuperOffice CRM

As an example, we'll create a Zap that triggers when a sale is marked as sold in SuperOffice.

## Define trigger

1. Click **Make Zap**.

1. For trigger application, select **SuperOffice CRM**.

1. Choose a trigger and click **Save + Continue**.

    For our example, select **Sale Changed**.

    ![Select SuperOffice CRM Trigger -screenshot][img1]

    > [!TIP]
    > Click **Show less common options** to see all available triggers.
    >
    > To see only sales-related triggers, enter "sale" in the search box.

1. Select which tenant (database) you want to link:

    * Select one of the listed accounts.
    * Or, click **Connect An Account** to choose another tenant.

    ![Select SuperOffice CRM Account -screenshot][img2]

1. Click **Save + Continue**.

1. Select the change (event) that should trigger this Zap. The options depend on which trigger you selected earlier.

    ![Set up SuperOffice CRM sale -screenshot][img3]

    For our example, select **Sale Status Changed To Sold**.

    ![Sale Status Changed To Sold -screenshot][img4]

1. Click **Continue**.

1. Choose a sample to use when setting up the Zap and its action.

    * Pull in actual data from the SuperOffice tenant.
    * Or, click **Skip this step** to use a default sample provided by SuperOffice.

    ![Pick A Sample To Set Up Your Zap -screenshot][img5]

    For our example, click **Skip This Step**.

1. Review the selected sample. Click the **arrow** to see more information in the sample text.

    * Continue with the selected sample.
    * Or, try to pull inn a sample from your tenant.

    For our example, click **Continue With Default Sample**.

    ![This step was skipped -screenshot][img6]

You are now finished with the **Trigger** step and can continue to the **Action** step that you have chosen.

## Define action

Choose an **Action** and/or a **Search** step - this means where the updated sale information from SuperOffice CRM should end up.

![Almost finished here! -screenshot][img7]

## Troubleshooting

### Problems when pulling in data samples

![Issue connecting Zapier to SuperOffice -screenshot][img8]

If you are unable to connect and pull data samples from SuperOffice, the likely reason is that the account you are using do not have the necessary administrator access rights (user rights) to use triggers, actions, and search.

Workaround: Try using a different account with more user rights when you connect to a SuperOffice tenant.

Remember that Zaps can do a lot of "damage" to your SuperOffice tenant, for example by adding a lot of duplicate information, and this is something we aim to prevent from happening.

[img1]: media/select-trigger.png
[img2]: media/connect-account.png
[img3]: media/set-up.png
[img4]: media/sale-status.png
[img5]: media/pick-sample.png
[img6]: media/skip-step.png
[img7]: media/action-step.png
[img8]: media/no-connection.png
