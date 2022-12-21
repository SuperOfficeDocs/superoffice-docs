---
title: Update app-specific page
uid: dp-update-app-info
description: How to update your app-specific page in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 11.29.2022
keywords: Developer Portal, App Store listing
so.topic: howto
so.dp-version: 1.9
so.envir: cloud
---

# Update app-specific page

The information shown on your app-specific product pages in the App Store comes from:

* Application settings
* App Store information

![App Store information for an application -screenshot][img1]

<!-- markdownlint-disable DOCSMD007 -->
> [!TIP]
> [!include[Link to application settings](../includes/see-app-settings.md)]
<!-- markdownlint-restore -->

## Update App Store information

> [!TIP]
> When you release a new version of your application, your App Store listing can include a **What's new** entry and we can help boost visibility.
>
> Optionally include new images, such as screenshots from your application.

1. In the Developer Portal, go to your application page.
1. Select **App Store information** from the left menu.
1. [Create a new version.][3]
1. Go through each sub-section and fill in the information.

    * [Description][5]

        > [!TIP]
        > Use an online counter to [count the number of characters or words][6].

    * [SEO][1]
    * [Prices and terms][7]
    * [How to install][8]
    * [Links][9]
    * [Image and videos][2]

1. Click **Save Settings**.

### Required information

Most fields are mandatory and must be filled out before you click **Request to Publish**. However, the App Store information can be edited and saved incrementally. Missing information is highlighted and color coded:

* Red - mandatory and must be filled before saving.
* Orange - mandatory for the published version but can be omitted when saving a draft.

![Warning Links field is blank -screenshot][img4]

When you click **Save Settings**, the confirmation dialog lists the fields needing attention.

![Warning when saving while mandatory info is missing -screenshot][img3]

## Update application settings

[!include[Read-only in version 1.5](../includes/note-cannot-edit.md)]

<!--
1. In your application page, select **Settings** from the left menu or click the **Edit** button.
1. Update names and contact persons.
1. Click **Save Settings**.
-->

## Verify your changes

1. Review your listing in the SOD App Store.
2. Fix issues in the Developer Portal if necessary.

## Request to publish

When you are happy with how it looks, return to your partner page in the Developer Portal:

1. Select **Overview** from the left menu.
2. In the **App Store** section, click the **Request to Publish** button.

    ![Request to publish App Store app information -screenshot][img2]

> [!NOTE]
> The App Store information is only the commercial side of releasing an application.
>
> When you list an application for the first time, you must also prepare and request to publish the configuration.

## Read more

* [About versioning][3]
* [Publishing workflow][4]

<!-- Referenced links -->
[1]: seo.md
[2]: images-and-videos.md
[3]: ../versioning.md
[4]: ../howto/request-to-publish.md
[5]: ../../apps/requirements/marketing.md#application-description
[6]: https://www.charactercountonline.com
[7]: prices-and-terms.md
[8]: user-guide.md#how-to-install
[9]: user-guide.md#links

<!-- Referenced images -->
[img1]: media/app-store-listing.png
[img2]: ../media/request-to-publish.png
[img3]: media/warn-mandatory-missing.png
[img4]: media/warn-no-links.png
