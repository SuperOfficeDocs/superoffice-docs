---
uid: help-en-adding-preference-settings
title: Adding preference settings
description: Adding preference settings
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add preference settings

You can add new settings for each of the preferences in the **Preferences** list.

1. [!include[Open preferences](../includes/open-preferences.md)]

[!include[Select group and reference](includes/select-group-and-reference.md)]

1. Click the **Add** button at the bottom of the window.

1. In the **Setting** dialog under **This setting will apply to**, choose [which level][2] the setting will apply to – the whole system, one database, one user group or an individual user.

    > [!NOTE]
    > If any of the options are disabled, this setting cannot be applied to them.

1. You then choose the name of the required database, group or user, depending on the option you selected above.

    > [!NOTE]
    > If you selected **System**, the **Target** field is filled in automatically as there is only one system.

1. The name of the field below **Value** varies depending on the preference involved. Specify the value for the setting by typing into this field, choosing from a predefined list, making a selection in a selection box, and so on, depending on the type of preference.

1. If you chose a higher level than the lowest possible one under **This setting will apply to**, you can check **Remove preferences on lower levels** at the bottom of the dialog to remove the settings for this preference on all lower levels. The new setting will override the settings specified for lower levels.

1. Click **Save**. The setting becomes available to users the next time they log in to SuperOffice CRM.

[!include[Note](includes/note-individual-settings.md)]

For information on how to edit and delete settings, see [Edit preference settings][3] and [Delete preference settings][4].

<!-- Referenced links -->
[2]: levels-for-preference-settings.md
[3]: editing-preference-settings.md
[4]: deleting-preference-settings.md

<!-- Referenced images -->
