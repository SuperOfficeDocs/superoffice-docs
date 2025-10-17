---
uid: help-en-preferences-manage
title: Working with preferences
description: How to add, edit, and delete preference settings.
keywords: preference, setting
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
category: Settings and maintenance
topic: preferences
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /en/admin/preferences/learn/update-preferences
language: en
---

# Working with preferences

## Go to the preference you want to update

1. Click the **Preferences** button (<i class="ph ph-gear" aria-hidden="true"></i>) in the Navigator.
2. Select the required preference group in the list box at the top.
3. Select the required preference from the **Preferences** list.

    The settings already defined for this preference are displayed in the **Active settings** field. If this field is empty, it may be because the options to show different levels are not checked.

> [!TIP]
> Use the **Freetext search** field at the top of the screen to find the preference you want to change. The search results will be displayed in the list below.

## Add preference settings

1. Go to the preference you want to add a new setting for.

1. Click the **Add** button at the bottom of the window.

1. In the **Setting** dialog under **This setting will apply to**, choose [which level][2] the setting will apply to – the whole system, one database, one user group or an individual user.

    * If any of the options are disabled, this setting cannot be applied to them.

1. Choose the name of the required database, group or user, depending on the option you selected above.

    * If you selected **System**, the **Target** field is filled in automatically as there is only one system.

1. The name of the field below **Value** varies depending on the preference involved. Specify the value for the setting by typing into this field, choosing from a predefined list, making a selection in a selection box, and so on, depending on the type of preference.

1. If you chose a higher level than the lowest possible one under **This setting will apply to**, you can check **Remove preferences on lower levels** at the bottom of the dialog to remove the settings for this preference on all lower levels. The new setting will override the settings specified for lower levels.

1. Click **Save**. The setting becomes available to users the next time they log in to SuperOffice.

> [!NOTE]
> Preferences with active individual settings are shown in bold text in the preferences list.

## <a id="edit"></a>Edit preference setting

1. Go to the preference you want to update.

1. Double-click the setting you want to change.

1. Update the fields as required.

1. Click **Save** (or **Cancel** to reject your changes).

    * The setting becomes available to users the next time they log in to SuperOffice.

## <a id="personal"></a>Allow individual settings

1. Go to the preference you want to make available in the **Personal settings** menu.

1. Check **Allow individual settings**. The preference will then be displayed in the **Preferences** dialog, and each person can edit the settings for their own use.

> [!NOTE]
> Settings at the user level are not available for all preferences.

## Delete preference setting

1. Go to the preference you want to delete a setting for.

1. Select one or more settings you want to delete and click **Delete** at the bottom of the window. All selected settings are removed from the list.

<!-- Referenced links -->
[2]: index.md#levels

<!-- Referenced images -->
