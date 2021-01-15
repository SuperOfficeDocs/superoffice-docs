---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: create_trigger_macro       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Creating a trigger - Macro # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Simen Mostuen Iversen
so.date: 06.06.2019
keywords: automation
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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
