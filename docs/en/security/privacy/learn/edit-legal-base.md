---
uid: help-en-edit-legal-base
title: Edit legal base
description: In this how-to guide, you will learn about the GDPR features in SuperOffice Marketing that help you ensure that your marketing efforts are GDPR-compliant.
author: SuperOffice RnD
so.date: 02.21.2023
keywords: privacy, consent, legal basis
so.topic: howto
language: en
---

# Edit privacy settings for a contact

> [!NOTE]
> This feature requires functional rights. Without the proper functional rights, you can only set **E-marketing** to on or off.

As a company, you collect, store and handle people's personal data. Under the GDPR, you now need to have a lawful reason for why you want to store this information.

SuperOffice CRM has a feature called Consent management, that is designed to help you document when, how and why you want to register certain personal data in your CRM solution.

Every time a person is registered in your SuperOffice CRM database, the consent they gave to save their details is also registered. This allows you to manage and track exactly which consent you have received from which person, at all times.

[!include[Need concent](includes/why-consent.md)]

## Definitions

* **Consent**: You must get the permission from a person to store and process their personal data.

* **Purpose**: Why you are storing and processing a person's data. Examples: **Sales and service** and ***E-marketing**. For each purpose you must document the following:

  * **Legal basis**: The legal basis for storing and processing a person's data.
  * **Source**: How and where you obtained the person's consent.

## Available purposes

* **Sales and service**: This purpose *must* have a legal basis and source, because you need a person's consent to lawfully process and store their personal data in SuperOffice.

* **E-marketing**: You need a person's permission to send them e-marketing material. This purpose can also be set by using the **E-marketing** button in the **Interests** tab.

* Additional purposes can be added from Settings and maintenance.

## How to edit the privacy settings for a contact

> [!TIP]
> To edit these settings for multiple contacts, use [Bulk update][2].

1. Go to the contact in the Contact screen.
    At the bottom of the contact card, you can see whether a legal basis is set for the purpose **Sales and service**.

2. Click **Legal basis** at the bottom of the contact card.

    ![At the bottom of the Contact card you can open a person's privacy page by clicking the Legal basis: Legitimate interest button -screenshot][img1]

3. In the **Privacy** dialog, double-click a purpose where the **Legal basis** and **Source** columns are empty.

    ![The Privacy page will show you all the consents you have registered for a contact -screenshot][img2]

4. In the **Edit legal basis** dialog in the **Legal basis** list, select the applicable legal basis. Example: If the person has signed a service agreement, you can select **Contract**.

5. In the **Source** list, select how consent was given by the person.

6. Add an additional comment in the **Comment** field, for example if the source is unknown.

7. Click **Save**.

8. Repeat steps 3-7 to edit another purpose.

9. Click **Close** when you are done.

## Related content

* [Learn more about GDPR, privacy and consent management in SuperOffice][1]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/learning/best-practices-tips/#gdpr
[2]: ../../../learn/basics/bulk-update.md

<!-- Referenced images -->
[img1]: media/legal-basisi.png
[img2]: media/legal-bases-registered-consent.png
