---
uid: help-en-sync-configure-default-values
title: sync configure default values
description: sync configure default values
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Configure default values for synchronization

By defining default values for fields that typically only have one relevant value, you save users a lot of time. You save them having to check a box that should always be checked or to enter a number into a field that should always contain "30". This is particularly useful when having to enter large quantities of data.

[!include[Go to sync](../includes/goto-sync.md)]

1. Select the ERP connection, and click the **Defaults** button at the bottom. The **Configure Sync Default Values** dialog displays the tabs for the available actors in the ERP system.

1. Select the tab for the actor you want to configure default values for.

1. Click **Add** at the bottom of the dialog. The **Add sync default value** dialog appears.

1. **ERP Field**: here you select which field in the ERP system you want to define a default value for.

1. **Set default value**: Check here to set a default value for the ERP field you selected above. Once you have checked here, you set the default value underneath.

1. **Ask user for value**: check here to allow the user to enter a value.

1. **Mandatory - User must fill in value**: check here to require the user to enter a value in the field. If the selected ERP field is mandatory, this field is checked by default.

1. Click **OK**.

1. Repeat steps 5-10 to add more default values.
