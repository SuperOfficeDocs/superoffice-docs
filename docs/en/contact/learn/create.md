---
uid: help-en-contact-create
title: Create a new contact
description: How to create contact in SuperOffice.
keywords: create contact, add interest, Interests tab, contact image, preferred language, legal basis, contact, person
author: Bergfrid Dias
date: 11.29.2024
version: 10
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Create a new contact

You can add a contact to SuperOffice CRM in multiple ways:

* From the **top bar** or **Company screen** (steps below).
* [Scan a business card][1] using the SuperOffice Mobile CRM app.
* [Bulk import contacts][2] (requires Administrator rights).

## Steps

1. **Open the Contact screen:**

    * Click **New** on the **top bar** and select **Contact**.
    * Or, go to the required company in the **Company screen**, select the **Contacts** section tab, and click the **Add** button.

1. **Provide essential contact details:**

    * Enter the **First name** and/or **Last name** (mandatory: at least one must be filled in)
    * Optional: Choose salutation (***Mr/Ms***)
    * Select the **Company**:
      * Start typing to search for a company or select **(No Selection)** if the contact is not linked to a company.
    * Optional: Add a **Contact image** by dragging an image file onto the image field or right-clicking to upload.

    ![Empty Contact card showing required First and Last Name fields highlighted and optional fields like Title and Company. -screenshot][img1]

1. Fill in the **Contact** tab fields.

    * Fill in the **Country** field. This updates the address format for that country automatically. The default country is the country recorded for the company.
    * Complete any additional fields as required, such as **Mobile**, and **Email**.

1. Add further information in the **Details tab** (optional):

    * Enter key details like **Position**, **Birth date**, and **Preferred language**.
    * Add contact-specific communication details: **Website**, **Chat**, and **Internet phone** (for example, Skype or Microsoft Teams).
    * If applicable, set Service priority and select an Our service contact (requires a SuperOffice Service or Customer Centre license).

    ![Contact Details tab with additional fields -screenshot][img2]

1. Go to the **Interests tab** to set interests and subscriptions:

    * Check the boxes for relevant interests (defined in Settings and maintenance).
    * Configure **E-marketing/subscriptions** for legal consent on email campaigns.

1. **Review privacy settings:**

    * Click **Legal basis** at the bottom of the Contact card to [review or update GDPR consent][7] and privacy information. Click **Close** when you are done.

1. **Mark as a former employee** (optional):

    * Check **Former employee** if the contact has left the company. Former employees do not appear in contact lists or projects.

1. Click **Save** to store the contact details.

The contact information is then saved in the database and displayed in the contact card. If you linked the contact to a company, the contact will be displayed in the **Contacts** tab in the Company screen.

## <a id="fields"></a>Key fields explained

The following fields are available in the Contact card. Some fields are filled automatically, while others require input.

> [!NOTE]
> Fields and layout may vary based on [Screen designer][9] configurations and other UI customizations.

<!-- markdownlint-disable-file MD051 -->
### [Contacts tab](#tab/contacts)

**Basic details:**

* **First name** / **Last name**: At least one of these fields must be filled (mandatory).
* **Salutation**: Optional. Choose **Mr/Ms** based on the contact's preference.
* **Title**: Enter the contact's position or job title.

**Contact information:**

* **Email**: Add multiple email addresses with descriptions, such as *Work* or *Private*.
* **Mobile** / **Direct phone**: Add multiple phone numbers with labels, such as *Mobile* or *Work*.
  * Press **TAB** or click outside the table to save entries.

**Address:**

* **Home address**: Complete the contact's address details.
  * The address format updates automatically based on the **Country** field.
* **Country**: Specifies the country of the contact. Defaults to the country linked to the company.
* **Use as postal address**: Check this box if you want direct mail sent to the contact's address instead of the company address.

**Inherited fields:**

* **Our Contact**: Automatically assigns your name. Click the arrow to choose someone else from your organization.
* **Category**: Select from a predefined list. Defaults to the company's category if linked.
* **Business**: Select the relevant business type. Defaults to the company's business type if linked.

**System fields:**

* **Number**: Auto-generated as the next available contact number if configured in **Settings and maintenance**. You can edit this manually if required.

[!include[3 udef](../../learn/includes/more-udef.md)]

### [Details tab](#tab/details)

**Personal information:**

* **Position:** Select the contact's position or job title from a predefined list (configured in **Settings and maintenance**).
* **Birth date:** Add the contact's date of birth.

**Communication details:**

* **Website:** Enter a URL for the contact's website, LinkedIn, Facebook, or other pages. Include a title for clarity.
* **Chat**: Add chat application addresses (such as, Microsoft Teams, Google Chat). Select a service provider from the list.
* **Internet phone:** Add a VOIP address, such as Skype or another internet-based phone service.
* **Direct fax:** Enter the contact's fax number.

**Service-specific fields** *(requires SuperOffice Service or Customer Centre license)*

* **Preferred language:** Select the contact's preferred language for all reply templates.
* **Service priority:** Set the priority for new service requests (for example, Low, Medium, High, or custom). Defaults to company priority if not set.
* **Our service contact:** Choose a service representative to manage this contact's requests.

**Private fields:**

* **Private**: Add personal phone numbers or contact details not linked to the company.

### [More tab](#tab/more)

Enter any [custom fields][12] specific to your CRM setup.

### [Interests tab](#tab/interests)

**Interests and subscriptions:**

* **Interests**: Select the contact's interests by checking the relevant boxes. Interests are used to create targeted selections, such as for mailings or campaigns.

  * Interests are predefined in **Settings and maintenance**.
  * A dot appears next to the **Interests** tab name when one or more interests are selected.

* **E-marketing/subscriptions**: Manage consent for sending email campaigns.

  * If the contact has agreed, enable the **E-marketing** option to confirm legal consent for sending mailings. This automatically sets the legal basis to **Legitimate interest**.
  * Specify subscription types to determine which kinds of e-marketing the contact agrees to receive.
  * Subscription options can also be adjusted by the contact through a customer portal.

### [Note tab](#tab/note)

[Add free-text notes][5] about the contact.

***

## <a id="interests-tab"></a>Add interests

Interests are useful for creating targeted selections, such as marketing campaigns for specific groups. For example, defining *reference account* as an interest lets you quickly create a selection of all reference accounts.

1. Go to the **Interests** tab.

1. In edit mode, select relevant interests by checking the boxes. Available options are defined in **Settings and maintenance**.

1. If you select one or more interests, a dot appears next to the tab name.

1. Click **Save** to store your changes.

## Tips

* You can add multiple phone numbers, emails, and other entries with descriptions (for example, Switchboard).

    If you click the contact's email address in the **Contact** tab, you can click the required email address in the list that appears. A blank email message opens, with the email address entered in the **To** field.

* Use the phone icon to call directly if your system is configured.

* If the contact is part of a company, fields like **Category**, **Business**, and **Our Contact** inherit company values but cannot be edited.

* Go to the [Relations section tab][8] to link this contact to other companies or contacts.

## Related content

* [Add contact as a favorite][4]
* [Scan a business card][1]

<!-- Referenced links -->
[1]: ../../../en/mobile/superoffice-mobile/company-contact/scan-business-card.md
[2]: ../../admin/import/learn/index.md
[4]: ../../learn/basics/fav.md
[7]: ../../security/privacy/learn/edit-legal-base.md
[8]: ../../learn/basics/relations.md
[5]: ../../learn/basics/notes.md
[9]: ../../ui/screen-designer/learn/index.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/new-contact.png
[img2]: ../../../media/loc/en/contact/contact-details.png
