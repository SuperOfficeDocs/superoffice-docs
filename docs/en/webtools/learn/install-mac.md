---
uid: help-en-webtools-install-mac
title: Install WebTools for Mac
description: If you are using macOS, you need WebTools for Mac to integrate your Microsoft 365 document applications with SuperOffice CRM.
author: Kirsti Aakerholt
so.date: 05.19.2023
keywords: WebTools, Mac, macOS, document, contact
so.topic: howto
language: en
---

# Install WebTools for Mac

This procedure connects Microsoft 365 and SuperOffice CRM so that you can open and edit Microsoft 365 documents directly in SuperOffice CRM on your Mac.

> [!NOTE]
> For macOS, WebTools consists of only one component: WebTools.
>
> To integrate your email, please [configure your SuperOffice Inbox][1].

## Pre-requisites

[!include[Requirements](includes/pre-req.md)]

> [!NOTE]
> SuperOffice provides integration for Microsoft 365 document applications only, and not for Apple applications Pages, Numbers, and Keynote. You need the Office package to have documents integrated.

## Steps

1. Go to the Main menu in SuperOffice and select **Download** > **SuperOffice WebTools**.

1. Open the file in **DiskImage** and drag the app-file into the *Application* folder on your Mac.

    ![Drag and drop the SuperOffice icon to the Applications folder -screenshot][img2]

1. You are good to go.

## Optional setting for default start-up

Add "SuperOffice WebTools" to your users' "Login Items" for it to start together with your Mac.

![Add SuperOffice WebTools into your Login Items to make the application appear automatically -screenshot][img3]

## Preferences

Set the preferences to fit your needs:

* Open and edit document directly from SuperOffice
  * Ask to check-in when done editing
  * Only upload on document close
* Show alarms for follow-up in SuperOffice
* Copy activities to iCal
  * Copy activities every [x minutes]
  * Copy participants to Address Book
* Copy contacts to Address Book
  * Copy contacts every [x hours]
  * Copy contacts from one specific selection in SuperOffice

![Set the preferences to fit your needs -screenshot][img4]

## Related content

* [Connect your email, document and diary][2]

<!-- Referenced links -->
[1]: ../../email/inbox/learn/setup.md
[2]: ../../learn/getting-started/connect-email-doc/index.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/webtools/webtools-mac-install.jpg
[img3]: ../../../media/loc/en/webtools/webtools-mac-login-items.jpg
[img4]: ../../../media/loc/en/webtools/webtools-mac-preferences.jpg
