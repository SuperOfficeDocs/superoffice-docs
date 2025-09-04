---
uid: help-en-email-inbox-setup
title: Set up SuperOffice Inbox
description: Learn how to set up and log in to the SuperOffice Inbox. This feature is an alternative to WebTools for connecting your email account to SuperOffice CRM.
keywords: SuperOffice Inbox, set up inbox, email setup, IMAP, email connection
author: Bergfrid Dias
date: 05.28.2025
version: 10.5
content_type: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Set up SuperOffice Inbox

The SuperOffice Inbox is an alternative method for connecting your email account to SuperOffice CRM. It is designed for users who cannot use [WebTools][9]. The inbox supports IMAP accounts only.

> [!NOTE]
> SuperOffice Inbox supports only **one** email account per user. If WebTools is installed and connected to your email, the Inbox feature is not available.

## Before you begin

* Check that **SuperOffice CRM** is selected as your [preferred email client][8] in **Local settings**.

* Ensure that **IMAP is enabled** in your email client.

* Confirm that the **email address** you intend to use matches the primary email address registered on your [contact card][1] in SuperOffice.

## Connect your email account

1. Click <i class="ph ph-at" aria-hidden="true"></i> **Inbox** in the navigator.

    The first time you open the inbox, the **Set up email account** dialog appears.

    ![Set up email account dialog showing email field and Next button -screenshot][img1]

1. In the **E-mail account** field, enter the email address you want to use.

1. Click **Next**.

    * SuperOffice will try to detect your email provider and redirect you to sign in.
    * If your password is saved with the provider, authentication may complete automatically.
    * If not, you will be prompted to enter your password directly with the provider (for example, Microsoft or Google).
    * After successful authentication, you are returned to SuperOffice and the inbox opens.

1. If authentication fails or the provider cannot be detected, the **Advanced settings** dialog appears. You can then enter server settings manually.

## Configure advanced settings

If automatic setup fails, you must enter your email server details manually. All required fields must be filled in to ensure that email can be received and sent using SuperOffice Inbox.

1. Enter incoming email settings:

    * **Incoming e-mail server:** Your IMAP server address
    * **User name:** Usually your full email address
    * **Password:** Your email account password
    * **SSL:** Turn on or off depending on your provider's requirements

1. Enter outgoing email settings:

    * **Outgoing e-mail server:** Your SMTP server address
    * **User name**, **Password**, and **SSL**: similar to incoming.

1. Click **Save** to connect your account.

![Advanced settings for email account -screenshot][img4]

## Disconnect or change your email account

You can disconnect your current email account and optionally update it by reconnecting.

1. Click <i class="ph ph-user-circle" aria-label="Personal settings"></i> in the top bar and select **Email options**.

1. Go to the **E-mail account** tab.

    ![Email account tab with Edit/remove button -screenshot][img6]

1. Click **Edit/remove** to disconnect the current email account.

    * This opens the same setup dialog used when first connecting your email account.
    * To remove the connection, simply close the dialog.
    * To reconnect, enter a new email address and follow the setup steps.

> [!NOTE]
> Removing the email account does **not** delete your actual email account (for example, your Gmail or Outlook account). It only disconnects it from SuperOffice.

## Troubleshooting tips

* The SuperOffice Inbox does not support **POP3** email accounts. Only IMAP is supported.

* If your inbox is not updating, your email provider may be blocking the connection.
  * Check your email account for a message about a blocked or unauthorized login attempt.
  * Follow the instructions to allow SuperOffice to access your account.

* **Gmail users:** As of January 2025, IMAP is permanently enabled by default. If you are asked for a password, use an **app password** instead of your regular Gmail password.

> [!TIP]
> To adjust layout, font, or behavior for messages, go to <i class="ph ph-user-circle" aria-hidden="true"></i> **Personal settings** > **Email options** > **General** tab.

## Related content

* [How to enable IMAP on Office 365 account][11] - FAQ
* [How to generate a Google app password to use 2-step verification with SuperOffice Inbox][12] - FAQ
* [Change default email client in SuperOffice][8]

<!-- Referenced links -->
[1]: ../../../contact/learn/index.md
[8]: ../../learn/change-default-mail-client.md
[9]: ../../../../../integrations/webtools/index.md
[11]: https://learn.microsoft.com/en-au/exchange/troubleshoot/user-and-shared-mailboxes/pop3-imap-owa-activesync-office-365
[12]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-generate-a-googleapp-password-to-use-2-step-verification-with-superoffice-inbox/

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/inbox-setup-dialog.png
[img4]: ../../../../media/loc/en/email/so-inbox-advanced-settings.png
[img6]: ../../../../media/loc/en/email/email-options-account.png
<!-- Prev YT video tag QoAanZgQs5A -->
