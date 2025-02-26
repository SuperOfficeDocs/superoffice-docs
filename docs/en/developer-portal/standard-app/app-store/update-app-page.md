---
uid: dp-update-app-info
title: Update app-specific page
description: How to update your app-specific page in the SuperOffice Developer Portal.
keywords: Developer Portal, App Store listing
author: Bergfrid Dias
date: 02.26.2025
version: 2.0
version_devportal: 2.0
topic: howto
envir: cloud
---

# Update app-specific page

The information shown on your app-specific product pages in the App Store comes from:

* Application settings
* App Store information

![App Store information for an application -screenshot][img1]

> [!TIP]
> For details about each field, see the [app settings reference section][11].

## Update application settings

1. In your application page, select **Settings** from the left menu or click the **Edit** button.

1. To update the technical contact person, click **Clear** and choose another contact by email address.

    [!include[User sources](../../partner/includes/note-users-collection.md)]

1. To receive error emails at different or additional email addresses, scroll to the bottom and add one or more addresses in the **Error reporting emails** field. Press Enter after each address to add it to the list.

    ![Application settings, error reporting emails -screenshot][img5]

1. To receive requests to uninstall an application at different or additional email addresses, update the **Uninstall reporting emails** field.

    > [!TIP]
    > The uninstall reporting emails can also be updated in the partner settings.

1. Click **Save Settings**.

## Update App Store information

> [!TIP]
> When you release a new version of your application, your App Store listing can include a **What's new** entry and we can help boost visibility.
>
> Optionally include new images, such as screenshots from your application.

1. In the Developer Portal, go to your application page.
1. Select **App Store information** from the left menu.
1. [Create a new version.][3]
1. Go through each tab and fill in the information.

    * [Details][9]
    * [Media][2]
    * [Description][5]

        > [!TIP]
        > Use an online counter to [count the number of characters or words][6].

    * [Prices and terms][7]
    * [How to install][8]
    * [SEO][1]

1. Click **Save Settings**.

### Required information

Most fields are mandatory and must be filled out before you click **Request to Publish**. However, the App Store information can be edited and saved incrementally. Missing information is highlighted and color coded:

* Red - mandatory and must be filled before saving.
* Orange - mandatory for the published version but can be omitted when saving a draft.

![Warning Links field is blank -screenshot][img4]

When you click **Save Settings**, the confirmation dialog lists the fields needing attention.

![Warning when saving while mandatory info is missing -screenshot][img3]

## Verify your changes

1. Review your listing in the SOD App Store.

    > [!TIP]
    > Click the eye icon on a version to preview the published app store information in the [SOD App Store][10]. This is a shortcut to `https://appstore-sod.superoffice.com/PARTNER-NAME/APP-NAME`.

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
[7]: prices-and-terms.md
[8]: user-guide.md#how-to-install
[9]: user-guide.md#links
[3]: ../../create-app/versioning.md
[4]: ../../create-app/request-to-publish.md
[5]: ../requirements/marketing.md#application-description
[6]: https://www.charactercountonline.com
[10]: https://appstore-sod.superoffice.com/
[11]: app-settings.md

<!-- Referenced images -->
[img1]: media/app-store-listing.png
[img3]: media/warn-mandatory-missing.png
[img4]: media/warn-no-links.png
[img2]: ../../media/request-to-publish.png
[img5]: ../../media/error-reporting-emails.png
