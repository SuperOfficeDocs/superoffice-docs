---
uid: help-en-privacy
title: privacy
description: privacy
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance, privacy, GDPR
so.topic: help
language: en
---

# Privacy

The **Privacy** feature in SuperOffice will assist you in protecting the data privacy of your customers and complying with the EU'sGeneral Data Protection Regulation (GDPR).

[!include[Need concent](../includes/why-consent.md)]

These are two different purposes for obtaining a person's consent. In SuperOffice, these purposes are called **Sales and service** and **E-marketing**. There may also be other purposes relevant for you business.

In the **Consent** tab in the **Privacy** screen (![icon][img1]) you can [create and edit purposes][2].

For each purpose, a legal basis and source of consent must be documented (this is done during import or in SuperOffice CRM for individual or multiple users).

## Legal basis

You need to document the legal basis for each purpose registered on a contact. In this list you add and maintain the list of legal bases that are used when editing the privacy settings for your contacts.

Example: A person sends you a request via web form and clicks a "Subscribe to newsletter" option (or similar). This means that this person has given their consent to receive e-marketing from your company. So the legal basis will be **Consent** for the purpose E-marketing.

## Source

Where and how did you obtain the consent from a contact? Examples: Email, chat, web form and customer portal.

## Options in the Consent tab

The **Consent** tab contains a list of available purposes.

## Activate or deactivate a purpose

In the **Active** column you can activate or deactivate a purpose. It is recommended to deactivate a purpose instead of deleting it.

## Add a new purpose

Click **Add** below the list of purposes. See [Add purpose][2].

## Set default legal basis

When a person is created in SuperOffice CRM, the legal basis for the purpose **Sales and service** is usually empty. You can select a default legal basis to be used for the purpose **Sales and service** when a person is created. This value will also be the default legal basis for imported contacts, unless a different value is selected during import.

Select the option **Set default legal basis**, and select a legal basis in the list. All new persons will have this legal basis for the purpose **Sales and service**.

[Add items to the Privacy - Legal basis list][3]

## Filter recipients based on e-marketing consent and active subscriptions

If you select this option, only persons who have given their explicit consent to receive e-marketing or who have a subscription, will be added to the recipients list in a mailing.

If you do *not* select this option, only persons with **E-marketing** set to **OFF** and legal basis set to **Withdrawn** will be filtered out of the recipients list. This works the same way as **No mailings**.

## What do you want to do now?

* [Learn more about GDPR, privacy and consent management in SuperOffice][1]
* [Add items to the Privacy - Legal basis list][3]
* [Add items to the Privacy - Source list][4]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/learning/best-practices-tips/gdpr/how-to-set-up-privacy-settings-for-gdpr-in-superoffice-crm/
[2]: add-consent-purpose.md
[3]: privacy-legal-base-add.md
[4]: privacy-source-add.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/nav-admin-privacy-active.png
