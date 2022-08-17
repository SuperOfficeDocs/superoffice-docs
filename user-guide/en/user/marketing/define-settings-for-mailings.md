---
uid: help-en-define-settings-for-mailings
title: define settings for mailings
description: define settings for mailings
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
so.envir: onsite
---

# Define settings for mailings

> [!NOTE]
> This function is only available to users with sufficient user rights.

When you are in the **Mailings** screen, you can click the **Settings** button (in the lower right corner) to access settings for e-mail and SMS.

## The Settings tab

The following settings are available for e-mail mailings:

* **Max number of e-mails sent per SMTP connection for all simultaneous threads**: Here you set the maximum number of e-mails to be distributed among the SMTP threads set below. Be aware that a high figure here may impose a very high load on your e-mail server. <!-- Fix reuse ID=a1 -->
    **Max number of e-mails...**: 100

    **SMTP Threads**: 5

    If 1000 e-mails is scheduled to be sent, SuperOffice sets up 5 processes (threads) on the SMTP server. Every process is assigned 20 e-mails (100 e-mails / 5 threads) in a queue.

    As soon as a process is complete, a new process is initiated and assigned another 20 e-mails.
* **SMTP threads**: Here you can enter the number of concurrent background processes that will send out the e-mails in a mailing. By increasing this number, you can get a higher throughput, but it will also increase the load on the server and the mail server.
* **Default From address**: The e-mail address which is to be the system's default sender address. This address will normally be overridden by the addresses entered into mailboxes. This must be an e-mail address that is imported into SuperOffice Service, e.g. support@company.com.

[!include[List of fields for mailings](../includes/mailing-smtp-fields.md)]

## The SMS tab

The following settings are available for SMS mailings:

[!include[Settings for mailings - SMS](../includes/mailing-settings-sms.md)]

## Testing the SMS settings

To test the settings, enter a mobile phone number and some text, and then click **Send test**.

For information about additional modules, see [SMS][1].

<!-- Referenced links -->
[1]: ../service/admin/editInfo.sms.md

<!-- Referenced images -->
