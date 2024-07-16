---
uid: help-en-edit-email-signature
title: Edit signatures
description: How to edit email signature and request signature
keywords: email, signature
author: Bergfrid Dias
date: 07.11.2024
version: 10.2.8
topic: howto
language: en
audience: person
audience_tooltip: SuperOffice CRM
---

# Edit signatures

The default templates contain template variables that are replaced with data from SuperOffice, ensuring your signatures are always updated with the correct information.

* **Email signature:** The template contains variables for your name, company, address, phone numbers, email address, website, and so on [from your contact card][3].

* **Request signature:** The template contains variables for your name, company, email address, and so on specific to [reply templates][2].

> [!NOTE]
> You cannot mix these two sets of template variables.

## Steps

1. Click the **Personal settings** button in the top bar.

2. Select **Edit personal signature**.

3. In the dialog, select either the **Email signature** tab or the **Request signature** tab.

4. Click ![icon][img2] to open the text editor toolbar. Here you have various options for editing text and adding additional content.

    ![Edit personal email signature -screenshot][img1]

    * Click ![icon][img3] in the toolbar to add variables, or go to the above-linked references for the complete list of available variables.

    * Add images and links using the buttons in the toolbar. You can also drag and drop links and images. Select **Insert link** to add links to relevant resources or social media.

5. Click **Save** when you are done.

6. Optional: Test the signature by sending an email to yourself (for email signatures) or by creating a new request (for request signatures). Check that all information is displayed correctly, and the links work and images are displayed as intended.

## Example

This is an example of a signature that can be used by anyone in your company.

**Template:**

```text
Best Regards,
{auth}
{atit}
{onam}
Address: {opad}, {ozip} {ocit}
Phone: {audp}
Mobile phone: {aupc}
{auem}
{owww}
```

**Result:**

```text
Best Regards,
John Jones
Sales Manager
SuperShop
Address: High Street 12, 223-344, Springfield
Phone: 22334455
Mobile phone: 99887766
jj@supershop.com
supershop.com
```

## Related topics

* [Change default mail client in SuperOffice][1]

<!-- Referenced links -->
[1]: ../../email/learn/change-default-mail-client.md
[2]: ../../request/reply-templates/learn/template-variables.md
[3]: ../../document/templates/variables/for-selected-contact.md

<!-- Referenced images -->
[img2]: ../../../../common/icons/editor-toolbar-icon.png
[img3]: ../../../media/icons/sign-editor-variables.png
[img1]: ../../../media/loc/en/learn/getstarted-preferences-email-signature.png
