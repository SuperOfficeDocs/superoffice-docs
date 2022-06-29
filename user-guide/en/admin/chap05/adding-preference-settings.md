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

1. Click the **Preferences** button in the Navigator ( ![icon](../media/Knapp-Preferanser-liten.bmp) ).

2. Select the required preference group in the list box at the top.

3. Select the required preference from the **Preferences** list. The settings already defined for this preference are displayed in the **Active settings** field.

    > [!TIP]
    > If this field is empty, it may be because the options to show different levels are not checked (see [Display different levels](Displaying-different-levels.md)).

4. Click the **Add** button at the bottom of the window. The **Setting** dialog opens. This is where you specify criteria for the new setting.

5. Under **This setting will apply to**, choose which level the setting will apply to – the whole system, one database, one user group or an individual user (see [Levels for preference settings](Levels-for-preference-settings.md)).

    > [!NOTE]
    > If any of the options are disabled, this setting cannot be applied to them.

6. You then choose the name of the required database, group or user, depending on the option you selected above.

    > [!NOTE]
    > If you selected **System**, the **Target** field is filled in automatically as there is only one system.

7. The name of the field below **Value** varies depending on the preference involved. Specify the value for the setting by typing into this field, choosing from a predefined list, making a selection in a selection box, and so on, depending on the type of preference.

8. If you chose a higher level than the lowest possible one under **This setting will apply to**, you can check **Remove preferences on lower levels** at the bottom of the dialog to remove the settings for this preference on all lower levels. The new setting will override the settings specified for lower levels.

9. Click **Save** to save the new setting in Settings and maintenance. The setting becomes available to users the next time they log in to SuperOffice CRM.

> [!NOTE]
>Preferences with active individual settings are shown in bold text in the preferences list.

For information on how to edit and delete settings, see [Edit preference settings](Editing-preference-settings.md) and [Delete preference settings](Deleting-preference-settings.md).
