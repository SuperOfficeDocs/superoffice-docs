---
uid: help-en-define-settings-for-mailings
title: define settings for mailings
description: define settings for mailings
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: en
---

# Define settings for mailings

> [!NOTE]
> This function is only available to users with sufficient user rights.

When you are in the **Mailings** screen, you can click the **Settings** button (in the lower right corner) to access settings for e-mail and SMS.

## The Settings tab ![icon](../../media/OnPremises.png)

The following settings are available for e-mail mailings:

* **Max number of e-mails sent per SMTP connection for all simultaneous threads**: Here you set the maximum number of e-mails to be distributed among the SMTP threads set below. Be aware that a high figure here may impose a very high load on your e-mail server. <!-- Fix reuse ID=a1 -->
    **Max number of e-mails...**: 100

    **SMTP Threads**: 5

    If 1000 e-mails is scheduled to be sent, SuperOffice sets up 5 processes (threads) on the SMTP server. Every process is assigned 20 e-mails (100 e-mails / 5 threads) in a queue.

    As soon as a process is complete, a new process is initiated and assigned another 20 e-mails.
* **SMTP threads**: Here you can enter the number of concurrent background processes that will send out the e-mails in a mailing. By increasing this number, you can get a higher throughput, but it will also increase the load on the server and the mail server.
* **Default From address**: The e-mail address which is to be the system's default sender address. This address will normally be overridden by the addresses entered into mailboxes. This must be an e-mail address that is imported into SuperOffice Service, e.g. support@company.com.

* **Host**: The IP address or host name of the e-mail server used to send e-mail. The server must be accessible from the SMTP port that the SuperOffice applications run on.
* **Port**: Here you specify which SMTP port the SuperOffice applications run on. The default port is 25.
* **User name** / **Password**: Enter the user name and password for the server.
* **Use SSL**: Check this option to use secure socket layer when logging on.
* **Check SMTP connection**: If you check here, the system will try to send an e-mail to an address at SuperOffice AS. The purpose of this is to establish if the SMTP server allows you to send out e-mail from your own domain. If you do not check here, no check will be made.

## The SMS tab

The following settings are available for SMS mailings:

* **Module**: In this list box, you can select the SMS provider you have a contract with for sending SMS from SuperOffice Service.
* **Default country code**: Here you need to enter a default country code for the country you are in, e.g. +44 for the UK. This country code is used for mobile telephony. It is used for outbound SMS (for example, when you don't enter the country code of the mobile phone number you are sending to) and inbound SMS (so that SuperOffice Service can recognise the customer).
* **Sender**: Here you enter the sender of the SMS messages. This text will appear on the recipient's mobile phone.
* **Plugin configuration**: Here you must enter (or paste in) the configuration for the selected module (received from your SMS provider).

## Testing the SMS settings

To test the settings, enter a mobile phone number and some text, and then click **Send test**.

![icon](../../media/OnPremises.png) For information about additional modules, see [SMS](../../Service/topics/admin.editInfo.sms.md).
