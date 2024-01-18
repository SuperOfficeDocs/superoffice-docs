---
uid: help-en-extra-field-display
title: Add extra field to the Details tab
description: Add extra field to the Details tab
author: Bergfrid Dias
so.date: 01.18.2024
keywords: extra field, custom field, request
so.topic: howto
language: en
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Add extra field to the Details tab

Scenario: you've added an extra field to a company (`contact` table) conveying whether or not it has a support contract and you want to display that info when viewing a request.

## Display extra field on new Requests screen

1. In **Settings and maintenance**, click **Screen designer** > **Requests**.
1. Click **Edit layout** at the bottom of the screen.
1. Locate the **Fields** setting.
1. Select your field.
1. Optionally, select the appropriate styling options.
1. Click **Save** to save the settings.

> [!TIP]
> You can also group fields, add headers for groups, and change the sizes of columns.

### Display extra field for role in Service

To make the field visible to others than yourself in Service, you need to create a profile.

1. In **Settings and maintenance**, click **System design** and select **Profile**.

1. Select **System screens**, then click **View ticket**, point the cursor to **ticketinfo**, and then click **New common profile**.

1. In the **Edit element profile** dialog, do steps 3-6 of *Display extra field for you*.

1. Click the hamburger menu again and select **Roles**.

1. Select a role (who should be able to see the field in the request screen).

1. In the **Edit role screen**, select the **Profile** tab.

1. From the **New element profile** list, select the profile you just created.

1. Click **OK** to save the settings.

All users who have this role will now be able to see the extra field in the **Details** tab in all their requests.

<!-- Referenced links -->
