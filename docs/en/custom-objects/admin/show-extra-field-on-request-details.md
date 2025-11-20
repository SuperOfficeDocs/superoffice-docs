---
uid: help-en-extra-field-display
title: Show extra field to the Details tab
description: Show extra field to the Details tab
keywords: extra field, custom field, request, layout, screen designer, System design
author: digitaldiina
date: 11.20.2025
version: 11.6
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
---

# Show extra field to the Details tab

Scenario: you have added an extra field to company (`contact` table) conveying whether a company has a support contract and you want to display that info when viewing a request.

<!-- markdownlint-disable-file MD051 -->
## Steps

### [In new Requests screen with Screen Designer](#tab/screen-designer)

1. Go to **Settings and maintenance** > **Screen designer** and select the **Requests** tab.
1. Click <i class="ph ph-pencil-simple" aria-label="Edit layout"></i> at the bottom.
1. Locate the **Fields** setting.
1. Select your field.
1. Optionally, select the appropriate styling options.
1. Click **Save** to save the settings.

> [!TIP]
> You can also group fields, add headers for groups, and change the sizes of columns. [Learn more about the Screen Designer][1].

### [In classic Service](#tab/service)

In Service, you need to create a common element profile.

1. Go to **Settings and maintenance** > **System design** and select the **Profile** tab.

1. Select **System screens**. Then click **View ticket**, point the cursor to **ticketinfo**, and click **New common profile**.

1. Enter a **name** for the new profile.

1. Click the **Add criteria** button and do the following:

    1. Enter a UI label for the extra field.
    1. Select which field in the database you want to get data from.
    1. Click **OK**. The new criterion is added below the others.
    1. Optionally, add more criteria.

1. Click **OK**. The new profile is created.

1. Click the hamburger menu again and select **Roles**.

1. Select a role (who should be able to see the field in the request screen).

1. In the dialog, select the **Profile** tab.

1. From the **New element profile** list, select the profile you just created.

1. Click **OK** to save the settings.

All users who have this role will now be able to see the extra field in the **Details** tab in all their requests.

***

<!-- Referenced links -->
[1]: ../../customization/screen-designer/admin/working-with-fields.md
