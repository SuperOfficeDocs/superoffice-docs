---
uid: mail-link-install
title: Install Mail Link
description: Learn how to download, install, and configure SuperOffice Mail Link with Microsoft Outlook.
keywords: install Mail Link, connect Outlook to SuperOffice, configure Mail Link
author: digitaldiina
date: 05.04.2026
content_type: howto
category: integration
topic: Mail Link
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/email/mail-link/learn/install
  - /da/email/mail-link/learn/install
  - /de/email/mail-link/learn/install
  - /nl/email/mail-link/learn/install
  - /no/email/mail-link/learn/install
  - /sv/email/mail-link/learn/install
index: true
---

# Install Mail Link

Mail Link connects Microsoft Outlook to SuperOffice CRM. It is a stand-alone installer and is not part of SuperOffice WebTools.

> [!NOTE]
> From **SuperOffice Online 11.13**, SuperOffice CRM does not use Mail Link to send emails or invitations when the new email connectivity has been enabled in your tenant — even if Mail Link is installed. This rollout started for new online customers in 11.11 and continues gradually for all online customers from 11.13. Onsite installations are not affected.

## Download and install

<!-- markdownlint-disable-next-line MD044 -->
1. Go to [downloadservice.superoffice.com][8] and download the Mail Link installer (`SuperOffice.MailLink.Setup.exe`).

1. Run the installer and follow the on-screen instructions.

1. When the installation is complete, restart Outlook.

## Configure in SuperOffice CRM

1. Click the **Personal settings** icon in the upper-right corner and select **Local settings**.

    ![Personal settings menu in SuperOffice CRM -screenshot][img1]

1. In the **E-mail client** field, select **Microsoft Outlook**.

    ![Local settings dialog with Microsoft Outlook selected -screenshot][img2]

1. Click **OK**.

## Configure in Outlook

1. In the SuperOffice ribbon in Outlook, click the arrow next to the **SuperOffice** button to open the options dialog.

    ![SuperOffice ribbon in Outlook -screenshot][img3]

1. Expand **Advanced settings** and paste your SuperOffice CRM URL in the **URL for SuperOffice CRM** field.

    ![Advanced settings with URL for SuperOffice CRM field -screenshot][img4]

1. In the **User name** field, enter your SuperOffice user name and click **Test connection**.

    ![User name field and Test connection button -screenshot][img5]

1. If prompted, authenticate via your browser and click **OK**.

    ![Browser authentication dialog -screenshot][img6]

1. When you see **Connection succeeded**, click **Close**, then **OK**.

    ![Connection succeeded confirmation dialog -screenshot][img7]

> [!NOTE]
> These steps also apply if Mail Link loses its configuration after a computer environment change, such as an OS update, new browser, or new computer.

## Related content

* [Connect email, documents and diary][5]
* [SuperOffice for Outlook][1] - the recommended Outlook integration

<!-- Referenced links -->
[1]: ../superoffice-for-outlook/get.md
[5]: ../../docs/en/learn/getting-started/connect-email-doc/index.md
[8]: https://downloadservice.superoffice.com/

<!-- Referenced images -->
[img1]: media/install-personal-settings-screenshot.png
[img2]: media/install-local-settings-screenshot.png
[img3]: media/install-outlook-ribbon-screenshot.png
[img4]: media/install-advanced-settings-url-screenshot.png
[img5]: media/install-test-connection-screenshot.png
[img6]: media/install-browser-auth-screenshot.png
[img7]: media/install-connection-succeeded-screenshot.png
