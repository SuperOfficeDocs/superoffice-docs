---
uid: help-en-privacy
title: privacy
description: privacy
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Privacy

The **Privacy** feature in SuperOffice will assist you in protecting the data privacy of your customers and complying with the EU'sGeneral Data Protection Regulation (GDPR).

You must have the consent (permission) of a person to (among other things)

* store and process their data (in order to sell to and/or provide services to a person)
* send them e-marketing material

These are two different purposes for obtaining a person's consent. In SuperOffice, these purposes are called **Sales and service** and **E-marketing**. There may also be other purposes relevant for you business.

In the **Consent** tab in the **Privacy** screen (![icon][img1]) you can create and edit purposes. See [Add purpose][2].

For each purpose, a legal basis and source of consent must be documented (this is done during import or in SuperOffice CRM for individual or multiple users). See [Privacy - Legal basis][3] and [Privacy - Source][4].

[Click here to learn more about GDPR, privacy and consent management in SuperOffice][1]

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

* [Add purpose][2]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/learning/best-practices-tips/gdpr/how-to-set-up-privacy-settings-for-gdpr-in-superoffice-crm/
[2]: add-consent-purpose.md
[3]: ../lists/privacy-legal-base.md
[4]: ../lists/privacy-source.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/knapp-privacy-small.png
