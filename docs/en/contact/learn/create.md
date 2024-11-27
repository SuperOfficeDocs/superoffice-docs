---
uid: help-en-contact-create
title: Create contact
description: How to create contact in SuperOffice.
author: SuperOffice RnD
date: 12.15.2022
keywords: person, contact
topic: howto
language: en
---

# Create new contact

There are many ways you can add contacts to SuperOffice CRM:

* Add a contact from the top bar **or** the Company screen - see steps below.
* [Scan a business card][1] with the SuperOffice Mobile CRM app.
* [Bulk import][2] larger numbers of contacts (requires Administrator rights).

![You can add a contact from the company card in two steps -screenshot][img1]

## Steps

1. Open the Contact screen.

    * Click **New** on the Top bar and select **Contact**.
    * Or, go to the required company in the Company screen, select the **Contacts** section tab, and click the **Add** button below the section tab.

2. In the top section of the tab, you enter the following information:

    * Contact's first name and/or last name. Mandatory: You must enter either a first name or a last name.
    * Salutation (***Mr/Ms***)
    * Company. Select a company in the list or start typing a company name to search. If the contact should not be connected to a company, select **(No Selection)**.
    * Contact image. You can add a photo by dragging the image file from Windows Explorer and dropping it on the image field at the upper left of the tab.

    You can also add a picture by right-clicking the picture field at the upper left of the tab. Click the link and browse to the picture you require and click **Open** to add the picture.

3. Enter contact information in the **Contact** tab.

    <details><summary>What goes in the various fields?</summary>

    [!include[Steps to populate company fields](includes/contact-fields.md)]

    </details>

4. Go to the **Details** tab. Here you can enter additional information for the contact.

    <details><summary>What goes in the various fields?</summary>

    [!include[Steps to populate company details](includes/contact-details.md)]

    </details>

5. Go to the **More** tab. This tab contains user-defined fields for the contact.

6. Go to the **Interests** tab. Here you can set interests and e-marketing/subscription options for the contact.

7. Go to the **Note** tab. Here you can enter information of any kind.

8. Go to the **www** tab. See details below.

9. Click **Legal basis** at the bottom of the contact card.

    In the **Privacy** dialog, [review and edit the consent][7] information as necessary. Click **Close** when you are done.

10. Check **Former employee** (at the bottom of the contact card) if this contact left the company. A contact who is recorded as a former employee is not normally displayed in the lists of contacts or project members.

11. After entering the necessary information, click the **Save** button.

    The contact information is then saved in the database and displayed in the contact card. If you linked the contact to a company, the contact will be displayed in the **Contacts** tab in the Company screen.

12. Go to the **Relations** section tab. Here you can [add relations][8] between this contact and another contact or company.

## <a id="more-tab"></a>The More tab (Contact screen)

The **More** tab contains user-defined fields for contacts. If, for example, your organization sells IT products and needs fields for each contact's hardware and software, you can specify in Settings and maintenance that these fields are to be inserted here.

Other examples: Year employed, ERP IDs, user type, CXM info.

## <a id="interests-tab"></a>The Interests tab (Contact screen)

In the **Interests** tab you have the following options:

* **Interests:** Here you select what interests a contact has. Interests are used to create selections for mailings and similar. [!include[SM](../../learn/includes/are-defined-sm.md)]

    > [!TIP]
    > Interests can be useful for defining selections. If, for example, you have defined *reference account* as an interest, you can create a selection that contains all your reference accounts. This makes it easy to produce a marketing campaign aimed at this customer group.

* **E-marketing/subscriptions:** If the contact has agreed (given consent) to receive e-marketing (mailings), you can click **E-marketing**. By activating the **E-marketing** option for a contact, you also set the legal basis for the **E-marketing** purpose. It is changed to **Legitimate interest**.

    You can also specify which types of e-marketing they should receive (also called subscription types). These settings may have been adjusted by the customers themselves via a customer portal.

## The www tab (Contact screen)

[!include[About the www tab](../../learn/includes/www-tab.md)]

## The ERP tab (Contact screen)

[!include[About the ERP tab](../../learn/includes/erp-tab.md)]

## The Note tab (Contact screen)

[!include[About the Note tab](../../learn/includes/about-note-tab.md)]

[!include[Tip](../../learn/includes/tip-open-website.md)]

## Related content

* [Add contact as a favorite][4]

<!-- Referenced links -->
[1]: ../../../en/mobile/superoffice-mobile/company-contact/scan-business-card.md
[2]: ../../admin/import/learn/index.md
[4]: ../../learn/basics/fav.md
[7]: ../../security/privacy/learn/edit-legal-base.md
[8]: add-relation.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/add-contact-from-company-card.png
