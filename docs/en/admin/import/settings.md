---
uid: help-en-import-settings
title: Import settings
description: Import settings
keywords: import
author: SuperOffice Product and Engineering
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /en/admin/import/learn/configure-import-settings
language: en
---

# Configure import settings

Adjusting the import settings will save you time and make it easier to import your data correctly.

[!include[Back up database before import](includes/caution-backup-before-import.md)]

In the **Import settings** dialog, you can customize the import to include precisely the what you want. To ensure that the quality of the imported data is as good as possible, it is important to specify the correct import settings.

This applies to the following, among other things:

* Duplicates: Select the preferred method for managing information that occur in both the import file and the database.
* Contacts that are not linked to companies.
* Legal basis and consent source for contacts.
* Lists: Select the preferred method for managing list elements in the import. For example, new categories, business types and phone numbers, new product categories, product families and product types.

## What to consider before you import your contact or product information

* You can define what the system should do if you import contacts that already exist in SuperOffice CRM. The system can overwrite or skip updating – it is your choice.

* You can choose to have the system create new categories automatically, if you use a category that does not exist in SuperOffice CRM in your import file.

## Typical scenarios

* I want to import information that does not exist in the SuperOffice data, but I do not want to overwrite existing information.
    Select the **Merge - update empty fields** option. Only empty fields in SuperOffice will then be updated with imported information.

* The data I want to import has been quality-assured and I want to update the SuperOffice database.
    Select the **Replace - overwrite existing** option. The data from the import will overwrite existing fields in SuperOffice.

* I only want to import new companies and contacts into SuperOffice.
    Select the **Skip record - do not import** option. Companies and contacts that already exist in SuperOffice will not be updated.

* I only want to import new products into the selected price list.
    Select the **Skip record - do not import** option. Products that already exist in the selected price list will not be updated.

* I want to import all companies and contacts into SuperOffice and manage any duplicates myself.
    Select the **Always add** option.

* I want to import all products into selected price list and manage any duplicates myself.
    Select the **Add always** option.

### Example

**Existing data:**

| | Company | Address | VAT No. | Code |
|---|---|---|---|---|
| **Import Excel/Outlook/Gmail** | ACME Inc. | Broadway 123 | 11223344 | - |
| **SuperOffice** | ACME Inc. | Main street 456 | - | ACME1 |

**Action:**

| Action | Company | Address | VAT No. | Code |
|---|---|---|---|---|
| **Merge** | ACME Inc. | Broadway 123 | 11223344 | ACME1 |
| **Replace** | ACME Inc. | Main street 456 | 11223344 | - |
| **Skip record** | ACME Inc. | Broadway 123 | - | ACME1 |

## Manage duplicates (company/contact)

A duplicate occurs if you have the same record in the import file and in the database. In the import settings, you must always specify rules for managing duplicates.

Under **Company**, and **Contact**, and **Product** in the **Import settings** dialog, specify how duplicates are to be managed.

1. Click the **Duplicate match** list box and select the fields that are to be used to identify duplicate companies or contacts.

    > [!NOTE]
    > To avoid the risk of overwriting data, you should choose the option that is unique for each company, contact, and product.
    >
    > The data selected for duplicate check MUST exist in the import file. If you select name+code, you import file must at minimum contain these columns.

1. Click the **Action** list box and choose how duplicate hits are to be managed:

    * **Add always**:
      * New companies, contacts, and products will always be added, even if there are duplicates.
      * New products will always be added, even if there are duplicates.

    * **Merge - update empty fields**:
      * If existing companies and contacts in SuperOffice have empty fields, these empty fields are populated with data from the import source. Existing data in SuperOffice fields will not be overwritten.

      * If existing products in the selected price list have empty fields, these empty fields are populated with data from the import source. Existing data in the selected price list will not be overwritten.

    * **Replace - overwrite existing**:
      * Import data will overwrite existing data in SuperOffice fields.
      * Import data will overwrite existing data in the selected price list.

    * **Skip - do not import**:
      * If companies and contacts already exist in SuperOffice, they will not be imported.
      * If products already exist in the selected price list, they will not be imported.

### Duplicate match options

**Company:**

* **Name**: The company name must be identical.
* **Name + Department**: Both the company name and the department must be identical.
* **Number**: The company number must be identical.
* **Code**: The company's code must be identical.
* **VAT number**: The company's VAT number must be identical.
* **ID**: The company's ID must be identical.

**Contact:**

* **Name**: The contact's full name (first name+last name) must be identical.
* **Email address**: The contact's email address must be identical.
* **Mobile phone**: The contact's mobile phone number must be identical.
* **Number**: The contact number must be identical.
* **None - do not import contact**: Select this option if you do not want to import contacts.
* **ID**: The contact ID must be identical.

**Product:**

* **Name**: The product name must be identical.
* **Code**: The product code must be identical.
* **Name + Code**: Both the product name and the product code must be identical.

## Manage contacts that do not belong to a company

If contacts in the import source are not listed with a company, you have three options in the **If no company name** list box:

* **Create company using contact name**: A company will be created using the contact name, with himself as the only contact.

* **Skip - do not create company or contact**: The contact will not be imported.

* **Import contacts without company**: The contact will be imported with no link to a company. This option is possible only if the global preference **Mandatory company on contact** is set to **No**.

## Privacy options for imported contacts

When you import contacts, you must also set the legal basis and consent source for the purpose **Sales and service**:

* **Legal basis**: Select a [legal basis][1] from the list, or select **Use default** to use the default value defined in the Privacy screen.

* **Consent source**: This value is by default set to **Import**, but you can select another value in the list.

## Manage list values that do not exist in SuperOffice

The import source may, for example, contain businesses that are not registered in SuperOffice. You must then choose how new categories, businesses, positions, custom list values and interests are to be managed. In the list boxes under **Lists**, you have the following options:

* **Add new item to the list**: New values will be added to SuperOffice.
* **Ignore - use default**: New values will not be imported, and the default value for category or business will be used. You specify the default value under **Preferences** > **Default values**.

    > [!NOTE]
    > **Position** does not have a default value.

* **Ignore - set to blank**: No new values will be imported into SuperOffice.

## Manage new phone numbers, links and email addresses

The import source may, for example, contain phone numbers, links and email addresses that are not registered in SuperOffice. As is it possible to register several phone numbers, links and email addresses for a single company/contact, you must specify how new values are to be managed. In the **Phone number** and **URLs + email** list boxes under **Lists**, you have the following options:

* **Add new - keep existing**: New values will be added to SuperOffice and existing values will be retained.
* **Replace - overwrite existing**: Existing values in SuperOffice will be overwritten by imported values.
    For example: This may be relevant if you know that the import contains correct email addresses for your contacts. If the email addresses that are registered in SuperOffice are outdated, you can overwrite them to clean up the system.
* **Ignore - keep existing**: No new values will be imported into SuperOffice.

## Manage product categories, product families and product types not in SuperOffice

The import source may, for example, contain product categories that are not registered in SuperOffice. You must then choose how new product categories, product families and product types are to be managed. In the **New values for...** list boxes, you have the following options:

* **Add new item to the list**: New values will be added to SuperOffice.
* **Ignore - set to blank**: No new values will be added to SuperOffice.

<!-- Referenced links -->
[1]: ../../security/privacy/learn/index.md

<!-- Referenced images -->
