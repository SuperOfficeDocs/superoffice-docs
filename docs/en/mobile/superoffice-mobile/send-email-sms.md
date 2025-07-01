---
uid: mobile-crm-send-email-sms
title: Send messages (email or SMS)
description: How to send email and SMS from SuperOffice Mobile CRM.
keywords: mobile, email, SMS, message
author: Bergfrid Dias
date: 06.10.2025
version: 11.1
content_type: howto
platform: mobile
language: en
---

# Send messages (email or SMS)

You can send an SMS or an email to one or more persons from the following places in Mobile CRM:

* The **Task** menu on a person or company.
* The **Task** menu in the **Group** and **Selection** tabs on the main Contacts screen.
* The **Task** menu in the **Participants** list of a follow-up.
* The **Email** action button on a follow-up, project, or sale.

## Steps

1. Tap the email address to send an email, or the mobile number to send an SMS.
1. Write your message in the message field.
1. Tap **Send**.

### Contact screen

* To send an email, tap to select the email address of the contact OR tap <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and select **Send e-mail**.
* To send an SMS message, tap the **SMS** action button.

![Mobile CRM: Send email or SMS from contact -app-screen][img1]

> [!NOTE]
> If the **SMS** or **Send e-mail** option is unavailable, the contact is missing a phone number and/or email address.

### Group and Selection tabs

1. Go to **Contacts** and choose a group or selection.
1. Tap <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> and choose to send an email or SMS to all contacts in the list.

### Follow-up screen

1. Go to the Diary and select a follow-up.
1. Tap <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> to see options to send an email to the owner or attendees of this follow-up.

![Mobile CRM: Send email from a follow-up in the Diary -app-screen][img4]

## Add signature to SMS

To add your professional signature automatically to SMSes sent from Mobile CRM:

1. Go to **Settings** and choose **SMS settings**.
1. Turn on **Add signature** to enable automatic signatures
1. Tap the **Signature** field to enter or update the text that will be added to your message.
1. Save.

## No current email account?

If you see the message "No current email account" when trying to send an email, it means your Mobile CRM app doesn't yet have access to an email account.

Mobile CRM supports two ways to send email. Choose the option that best fits your situation:

### Option 1: System default

Uses your device's existing mail app. This is the fastest way to send emails and requires no setup in SuperOffice.

* Best for quick replies or when you're on the go.
* Works as long as you have any email app configured on your phone.
* Emails are not archived in SuperOffice or linked to CRM records.

When selected, you'll be asked to choose your preferred email app the next time you send an email.

![System default email client -app-screen][img7]

### Option 2: SuperOffice

Uses SuperOffice's built-in email client. This option integrates email into your CRM workflow.

* Emails are automatically archived and linked to contacts, sales, or projects
* Supports attachments, follow-up creation, and full CRM visibility
* Requires setup in the SuperOffice web client

To connect your email account, follow these steps: [Set up your email account in SuperOffice][1]

**Tip:**

* Use *System default* if you just need to send a quick message.
* Use *SuperOffice* if you want to share and archive communication with your team.

## Related content

* [Connect an email client to SuperOffice CRM][2]

<!-- Referenced links -->
[1]: set-up-email.md
[2]: ../../../en/learn/getting-started/connect-email-doc/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/mobile/contact.png
[img4]: ../../../media/loc/en/mobile/send-email-diary.png
[img7]: ../../../media/loc/en/mobile/system-email-application.png
