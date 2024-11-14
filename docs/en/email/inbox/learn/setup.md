---
uid: help-en-email-inbox-setup
title: Set up SuperOffice Inbox
description: The SuperOffice Inbox is an alternative way to connect your email to your SuperOffice CRM for email clients that cannot be connected via WebTools. Learn how to set it up and log in for the first time.
author: SuperOffice RnD
date: 02.14.2023
keywords: email, inbox
topic: howto
language: en
---

# Set up SuperOffice Inbox

The SuperOffice Inbox is an alternative way to connect your email to your SuperOffice CRM for email clients that cannot be connected via WebTools.

## Before you begin

* Make sure IMAP is enabled in your email client. SuperOffice Inbox supports most of the IMAP email servers.

* To be able to send out emails from SuperOffice CRM, make sure that the email address you are going to use with SuperOffice Inbox is same as the first email registered in your Contact card/screen.

![You can check which email you have registered in your Contact card -screenshot][img2]

## Set up email account

To access email, you must first specify details about your email account.

Watch this video to see how quickly and easily you can set up your SuperOffice Inbox or follow the steps below (video length -1:34):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/QoAanZgQs5A]

### Steps

1. Click on the Inbox icon in the navigator menu. The **Set up email account** screen appears the first time you open your inbox.

1. In the **Email account** field, enter the email address of the account you want to use in SuperOffice.

    ![x -screenshot][img3]

1. To enter information for incoming and outgoing email, click **Advanced settings**. If not, click **Next**. SuperOffice will then try to set up this information for you.

1. In the **Password** field, enter your password.

1. Click **Log in**.

    * If SuperOffice recognizes the email provider (such as Gmail), the server settings are set up automatically and the inbox loads.
    * If it does nnt get the details correct or the email address and password you entered are not correct, the **Advanced settings** dialog opens. Manually enter or check configuration information for incoming and outgoing servers.

## How to manually add server information

### Incoming email settings

To get your emails imported into SuperOffice CRM, enter your IMAP server details found in your email client's settings.

* User name: your full email address
* Password: your email account password
* SSL: On/Off - depends on your email provider's settings (see settings for Outlook and Gmail)

### Outgoing email settings

To send emails from SuperOffice CRM, enter your SMTP server details.

* User name: your full email address
* Password: your email account password
* SSL: depends on your email provider's settings (see settings for Outlook and Gmail)

![Advanced settings - go to Inbox to manually add correct email server information -screenshot][img4]

## Change email configuration in SuperOffice Inbox

1. If you want to edit or remove your associated email account, click on your profile icon in the upper-right corner and choose **Email options**.

    ![Email options -screenshot][img5]

1. Select **Email account** tab and press the **Edit/remove** button.

    ![Email options -screenshot][img6]

## Why is the email list is not updated?

Some email providers, such as Gmail, will block login attempts from unknown apps. Check your inbox to see if your email provider has sent you information about an unauthorized login attempt. Follow the instructions in the email to allow SuperOffice to access your account.

> [!TIP]
> To access the email options, go to <i class="ph ph-user-circle" aria-hidden="true"></i> **Personal settings** > **Email options**.

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/email/getstarted-contact-mycontactcard.png
[img3]: ../../../../media/loc/en/email/getstarted-inbox-login.png
[img4]: ../../../../media/loc/en/email/so-inbox-advanced-settings.png
[img5]: ../../../../media/loc/en/email/email-options-general.png
[img6]: ../../../../media/loc/en/email/email-options-account.png
