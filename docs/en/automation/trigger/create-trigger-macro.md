---
title: Creating a trigger - Macro
uid: create_trigger_macro
description: Creating a trigger - Macro
author: Simen Mostuen Iversen
date: 06.06.2019
keywords: automation
topic: howto
---

# Creating a trigger :: Macro

We'll create the **Before saving company** trigger, by using a macro. You can also [create this trigger using script][1].

1. Click the **New trigger (macro)** in the trigger pane. In the search box, type **Before saving company** and click the trigger.

2. The **Description** field should contain a short description of what your trigger is doing, in this case, I’ll write **Validate OrgNr**.
    * If you want this trigger to be enabled, remember to click the toggle box on the right side.

3. Click **Trigger response**.

4. Set conditions:
    * In the **If** section, select **All conditions are true**.
    * In the list box below, select **Real-time values from the trigger** and search for **Org. number**.
    * In the field to the right, select **Is empty**.

5. In the **Then** section, the **Trigger response** part:
    * Check **Block save**.
    * Check **Show message dialog**
    * Insert a text to the right (for example, "Please type in an Org.Nr").

<!-- Referenced links -->
[1]: create-trigger-script.md
