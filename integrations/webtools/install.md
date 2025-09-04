---
uid: webtools-install
title: Install WebTools
description: How to install WebTools per user.
keywords: WebTools, TrayApp, Mail Link, Web Extensions, macOS
author: Hans Oluf Waaler, Bergfrid Dias, Kirsti Aakerholt
date: 05.19.2023
content_type: howto
category: integration
topic: WebTools
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from: 
  - /en/document/webtools/install
  - /en/document/webtools/learn/install
  - /da/document/webtools/learn/install
  - /de/document/webtools/learn/install
  - /nl/document/webtools/learn/install
  - /no/document/webtools/learn/install
  - /sv/document/webtools/learn/install
  - /en/document/webtools/learn/install-mac
  - /da/document/webtools/learn/install-mac
  - /de/document/webtools/learn/install-mac
  - /nl/document/webtools/learn/install-mac
  - /no/document/webtools/learn/install-mac
  - /sv/document/webtools/learn/install-mac
index: true
---

# Install WebTools

SuperOffice WebTools lets you integrate documents (and email) with SuperOffice CRM. Choose your platform below to view the installation steps.

> [!NOTE]
> On Windows, WebTools consists of two components: Mail Link and Web Extensions.
>
> For macOS, WebTools consists of only one component: WebTools. To integrate your email, please [configure your SuperOffice Inbox][1].

Watch this video or follow the guide below to learn how to install WebTools on Windows:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/PGh6An9o8mA]
(video length - 3:00)

## Pre-requisites

* You might need administrative rights to SuperOffice CRM to make systems connections (depends on your organization's security settings).
* For Microsoft 365 connections, check your rights in the Microsoft 365 environment.
* If you are using a Citrix connection, your IT team must set up the connections for you.
* For MacOS, you need the Office package to have documents integrated. SuperOffice provides integration for Microsoft 365 document applications only, and not for Apple applications Pages, Numbers, and Keynote.

## Steps

<!-- markdownlint-disable MD051 -->
### [Windows](#tab/win)

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar.
1. Select **Download** > **SuperOffice WebTools**.

    ![Download WebTools -screenshot][img2]

1. In the SuperOffice WebTools wizard, select **Personal Computer** > **SuperOffice**, and click **Download** to download the installation file.

    ![WebTools installation -screenshot][img3]

    ![WebTools installation -screenshot][img4]

1. Click **Next** and **Close** to close the WebTools wizard.
1. Click the downloaded **SuperOffice.Web.Tools.exe** file in the downloads section in your browser.
1. Click **Continue**.
1. Click **Install**.
1. If you are asked for your user name and password to install, enter them and click **Install Software**.
1. When the message "The installation was successful" is displayed, close the dialog.
1. Finally, log out of SuperOffice CRM, close the browser window. Then reopen your browser window to log in again.

With WebTools installed, you can start creating documents from inside SuperOffice.

### [MacOS](#tab/mac)

1. Go to <i class="ph ph-list" aria-label="Main menu"></i> in the top bar and select **Download** > **SuperOffice WebTools**.

1. Open the file in **DiskImage** and drag the app-file into the *Application* folder on your Mac.

    ![Drag and drop the SuperOffice icon to the Applications folder -screenshot][img6]

1. You are good to go.

#### Optional setting for default start-up

Add "SuperOffice WebTools" to your users' "Login Items" for it to start together with your Mac.

![Add SuperOffice WebTools into your Login Items to make the application appear automatically -screenshot][img7]

#### Preferences

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

![Set the preferences to fit your needs -screenshot][img8]

***
<!-- markdownlint-restore -->

## Upgrade

We are always working to improve our programs, including WebTools. When a new version of WebTools is available, you will get a notification when logging in. To install the new version, just follow the guide that appears on your screen.

## Technical information for administrators

WebTools currently uses .NET Framework 4.7.2, which will be installed if it is not detected on the system.

Administrative privileges are not required for the user. If you are not the administrator, you get WebTools installed in *c:\users\\\<yourname>\appdata\local\SuperOffice*.

### How configuration is passed in the file name

1. When you download WebTools from a SuperOffice installation, the downloaded file has a name in form of `SuperOffice.Web.Tools--u=https%3a%2f%2fsuperoffice%3a443%2fSuperOffice%2f&cn=SuperOffice&un=souser-­-.exe`.  The contents after `--` is the configuration directive.

2. The WebTools installer executes the command (without brackets):

    `SuperOffice.TrayApp.Client.exe /autoconfig:[installer_name]`

**Example:**

This example configures the WebTools installation to connect to `https://superoffice/superoffice/`.

The full command given to *SuperOffice.TrayApp.Client.exe* in this example is:

`SuperOffice.TrayApp.Client.exe /autoconfig:"SuperOffice.Web.Tools--u=https%3a%2f%2fsuperoffice%3a443%2fSuperOffice%2f&cn=SuperOffic­e&un=souser--.exe"`

## Related content

* [Connect your email, document and diary][2]

<!-- Referenced links -->
[1]: ../../docs/en/email/inbox/learn/setup.md
[2]: ../../docs/en/learn/getting-started/connect-email-doc/index.md

<!-- Referenced images -->
[img2]: ../../docs/media/loc/en/webtools/download-webtools.png
[img3]: ../../docs/media/loc/en/webtools/webtools-pc.png
[img4]: ../../docs/media/loc/en/webtools/webtools-email-client.png
[img6]: ../../docs/media/loc/en/webtools/webtools-mac-install.jpg
[img7]: ../../docs/media/loc/en/webtools/webtools-mac-login-items.jpg
[img8]: ../../docs/media/loc/en/webtools/webtools-mac-preferences.jpg
