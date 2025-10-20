---
uid: help-en-mailing-settings
title: Define settings for mailings
description: Define settings for mailings
keywords: Marketing, mailing, sms, settings
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
redirect_from: /en/marketing/mailing/learn/admin/define-settings-for-mailings
language: en
deployment: onsite
index: true
---

# Define settings for mailings

> [!NOTE]
> This function is only available to users with sufficient user rights.

When you are in the **Mailings** screen, you can click the **Settings** button (in the lower right corner) to access settings for email and SMS.

## The Settings tab

The following settings are available for email mailings:

* **Max number of emails sent per SMTP connection for all simultaneous threads**: Here you set the maximum number of emails to be distributed among the SMTP threads set below. Be aware that a high figure here may impose a very high load on your email server. Example:

    **Max number of emails...**: 100

    **SMTP Threads**: 5

    If 1000 emails is scheduled to be sent, SuperOffice sets up 5 processes (threads) on the SMTP server. Every process is assigned 20 emails (100 emails / 5 threads) in a queue.

    As soon as a process is complete, a new process is initiated and assigned another 20 emails.

* **SMTP threads**: Here you can enter the number of concurrent background processes that will send out the emails in a mailing. By increasing this number, you can get a higher throughput, but it will also increase the load on the server and the mail server.

* **Default From address**: The system's default email sender address. This address will normally be overridden by the addresses entered into mailboxes. This must be an email address that is imported into SuperOffice Service. For example, `support@company.com`.

[!include[List of fields for mailings](../../learn/includes/mailing-smtp-fields.md)]

## <a id="sms"></a>The SMS tab

The following settings are available for SMS mailings:

[!include[Settings for mailings - SMS](../../learn/includes/mailing-settings-sms.md)]

## Testing the SMS settings

To test the settings, enter a mobile phone number and some text, and then click **Send test**.

For information about additional modules, see [SMS][1].

<!-- Referenced links -->
[1]: ../../../../en/marketing/sms/it/set-up.md

<!-- Referenced images -->
