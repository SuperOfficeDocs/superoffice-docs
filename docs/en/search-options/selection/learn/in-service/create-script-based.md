---
uid: help-en-selections-script-based-create-service
title: Create a script-based selection
description: How to create a script-based selection in Service.
author: SuperOffice RnD
so.date: 06.29.2022
keywords: selection, CRMScript
so.topic: howto
language: en
---

# Create a script-based selection

[!include[Requirement](../../../../learn/includes/req-expander-services.md)]

In a script-based selection, you define a data selection using a [CRMScript][1], which offers almost unlimited possibilities for advanced calculations and criteria for defining the selection. You can order a script tailored to your company's needs from SuperOffice or a SuperOffice partner. You can also create a CRMScript yourself.

Assuming you already have a script to use as a basis, a script-based selection is created as follows:

1. Select **Selections** > **New selection**. This takes you to the **New selection** screen.

2. In the **Source table** field, select which type of records you want to include in the selection. For instance, to create a selection of requests, select **Request**.

3. Check **Script-based selection**.

4. Click **Continue**. This takes you to the **Edit selection** screen.

5. In the **General info** tab, enter the following:

    [!include[Contents of Selection General info tab](includes/selection-general-info.md)]

6. In the **Selection** tab, paste the script into the text field.

7. In the **Profile** tab, specify how the selection should be presented:

    [!include[Contents of Selection Profile tab](includes/selection-profile-tab.md)]

8. Click **Execute** to display the result of the script-based selection in the **Result** tab.

9. Click **OK**. The selection is saved, and you are returned to the **List selections** screen.

## What would you like to do now?

* [Update a selection][2]
* [View selections][3]
* [Edit a selection][4]

<!-- Referenced links -->
[1]: ../../../../automation/crmscript/index.yml
[2]: update.md
[3]: list.md
[4]: edit.md

<!-- Referenced images -->
