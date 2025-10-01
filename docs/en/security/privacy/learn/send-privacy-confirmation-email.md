---
uid: help-en-send-privacy-confirmation-email
title: Send privacy confirmation email
description: Send privacy confirmation email
keywords: privacy confirmation email, email confirmations
author: SuperOffice Product and Engineering
date: 02.21.2023
version: 10.3
content_type: howto
category: privacy
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Send privacy confirmation email

In the new GDPR world, individuals have the "Right to be Informed". This means that they are entitled to know either in advance or within 30 days after their details have been collected. The GDPR stipulates that individuals are entitled to be informed (a) that an organization intends to store their personal data and (b) what the organization intends to use their data for.

## Collect their consent upfront through forms

By using integrated forms available in your CRM solution, you can collect a person's consent at the same time they complete a web form and give you their personal details. This consent is automatically documented inside SuperOffice CRM using the Consent Management features.

This video will show you how to create a basic web form and add it to your web page (video length - 7:49):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/18m6Dx1t9wI]

## Send automatic email confirmations

SuperOffice CRM lets you automatically send a privacy confirmation email to individuals who are registered in your database. The email is sent automatically to a contact when they are first registered in SuperOffice, without you having to do anything.

Not only is this a polite way of following up on your initial contact with a customer, but it also offers your contact an easy way to let you know if they have any questions or objections to you storing their information.

You can configure the system to also include a link which will lead to a personal subscription page. In this link, your contacts can select what kind of communication they want to receive.

## How to resend a privacy email confirmation

From the Contact screen, you can send or resend the privacy confirmation email to a contact.

[!include[Go to Contact screen](../../../learn/includes/goto-contact.md)]

1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and select **Send privacy confirmation email**.

    ![Send a confirmation email to inform the contacts about their information being stored in your CRM database -screenshot][img2]

1. In the dialog that opens, fill in the following fields:
    * **Send to**: Use the default email address or select another address.
    * **Use template**: Select an email template.
    * **Language**: Use the default language or select one of the available languages.
    * **Subject**: If relevant, edit the default subject of the email.

1. Click **Send**.

The confirmation email is sent to the contact. The email is archived in the **Activities** section tab.

## What does this email contain?

The privacy confirmation email will normally inform the contact of the following:

* Their information was stored in SuperOffice
* What type of information was stored
* What the information is used for (purpose)
* That they can withdraw consent whenever they like
* That the information is secure and will not be shared

The email can also contain a link to a customer centre where the contact can manage subscriptions and consent. The link is valid for 21 days by default.

## Related content

* [Edit the privacy confirmation email in Settings and maintenance][1]

<!-- Referenced links -->
[1]: ../admin/edit-privacy-confirmation-email.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/security/confirmation-email.png
