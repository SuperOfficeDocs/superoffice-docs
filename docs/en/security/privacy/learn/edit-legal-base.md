---
uid: help-en-edit-legal-base
title: Edit legal base for a contact
description: In this how-to guide, you will learn about the GDPR features in SuperOffice Marketing that help you ensure that your marketing efforts are GDPR-compliant.
keywords: edit privacy settings, edit legal base
author: SuperOffice Product and Engineering
date: 10.08.2024
version: 10.3.10
content_type: howto
functional_right: Can update consent for contact
category: privacy
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Edit legal base for a contact

> [!NOTE]
> This feature requires functional rights. Without the proper functional rights, you can only set **E-marketing** to on or off.

As a company, you collect, store and handle people's personal data. Under the GDPR, you now need to have a lawful reason for why you want to store this information.

SuperOffice CRM has a feature called Consent management, that is designed to help you document when, how and why you want to register certain personal data in your CRM solution.

Every time a person is registered in your SuperOffice CRM database, the consent they gave to save their details is also registered. This allows you to manage and track exactly which consent you have received from which person, at all times.

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

## <a id="bulk"></a>How to set privacy settings of many contacts all at once

If you import or store a lot of data in your SuperOffice CRM, you can do a bulk update to help you get this data GDPR-ready.

In the following example, we create a selection of all contacts registered today and then fill the *Purpose* field.

1. Click **Find** (1) and select **Find Contact** (2) to start your search.

    ![Find screen -screenshot][img8]

1. In the **Criteria** tab, choose how to identify the contacts that need to get updated. In our example, select the field **Registered date** (1) and choose **Today** (2).

    ![Find contacts -screenshot][img9]

    When you are happy with your search setup click **Find** (3) to get a list of these contacts.

1. Click **Save as selection** at the bottom of the list (1). Then choose **Dynamic (or Static) selection** (2), and click **Save** (3).

    ![Save as dynamic selection -screenshot][img3]

1. Fill in the name of the selection (1), choose a **Category** from the drop-down list (2), and click **Save** (3).

    ![Choose category for selection -screenshot][img4]

1. Click the **Task** button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) at the bottom of the screen (1) and choose **Bulk update** (2).

    ![Bulk update option in the Task menu -screenshot][img5]

1. Go to the **Contact** tab (1) to choose fields and values:

    1. Click **+Add** (2) to include a new field.
    1. Click **Legal Basis** (3) and choose an action **Add/Update** (4).
    1. Click **Click here to add legal base for purpose** and set up preferred values in the fields (5).
    1. Click **Update** (6) to initiate the change.

    ![Bulk update add legal base for purpose -screenshot][img6]

1. Click **Yes** to start the update.

    ![Confirm bulk update -screenshot][img7]

> [!NOTE]
> **Bulk updates cannot be undone.** That is why we recommend [creating a database backup][3] before making any large data updates ONSITE. Backups of SuperOffice CRM ONLINE are created automatically.

## Related content

* [Learn more about GDPR, privacy and consent management in SuperOffice][1]

<!-- Referenced links -->
[1]: ../../../../en/security/privacy/index.md
[2]: ../../../learn/basics/bulk-update.md
[3]: https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=111362

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/security/legal-basisi.png
[img2]: ../../../../media/loc/en/security/legal-bases-registered-consent.png
[img3]: ../../../../media/loc/en/security/dynamic-selection.png
[img4]: ../../../../media/loc/en/security/category-save.png
[img5]: ../../../../media/loc/en/security/bulk-update.png
[img6]: ../../../../media/loc/en/security/legal-basis.png
[img7]: ../../../../media/loc/en/security/yes.png
[img8]: ../../../../media/loc/en/security/find-fields.png
[img9]: ../../../../media/loc/en/security/find-contact.png
