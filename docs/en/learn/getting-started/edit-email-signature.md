---
uid: help-en-edit-email-signature
title: Edit signatures
description: How to edit email signature and request signature
keywords: Email signature, Request signature, email, signature
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Edit signatures

The default templates contain template variables that are replaced with data from SuperOffice, ensuring your signatures are always updated with the correct information.

* **Email signature:** The template contains variables for your name, company, address, phone numbers, email address, website, and so on [from your contact card][3].

* **Request signature:** The template contains variables for your name, company, email address, and so on specific to [reply templates][2].

> [!NOTE]
> You cannot mix these two sets of template variables. Additionally, personal signatures cannot be overridden by admins.

## Steps

1. Click the **Personal settings** button  (<i class="ph ph-user-circle" aria-hidden="true"></i>) in the top bar.

1. Select **Edit personal signature**.

1. In the dialog, select either the **Email signature** tab or the **Request signature** tab.

1. Edit text and add additional content.

    * Click **[v]** in the toolbar to add variables, or go to the above-linked references for the complete list of available variables.

    * Add images and links using the buttons in the toolbar. You can also drag and drop links and images. Select **Insert link** to add links to relevant resources or social media.

    ![Edit personal email signature -screenshot][img1]

1. Click **Save** when you are done.

1. Optional: Test the signature by sending an email to yourself (for email signatures) or by creating a new request (for request signatures). Check that all information is displayed correctly, and the links work and images are displayed as intended.

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
[img1]: ../../../media/loc/en/learn/getstarted-preferences-email-signature.png
