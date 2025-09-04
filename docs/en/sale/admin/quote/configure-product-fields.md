---
uid: help-en-product-fields-configure
title: Configure fields in the Add/edit product dialog
description: Learn how to control which fields appear in the Add/edit product dialog and how they behave.
keywords: Configure product dialog, Add/edit product dialog, configure product, product dialog, product field, product, quote
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from: /en/quote/learn/admin/product/configure
---

# Configure fields in the Add/edit product dialog

Use the **Configure product** dialog to control which fields are shown when users add or edit a product in a quote. You can show or hide fields, change labels, define tooltips, and make fields editable and/or mandatory.

These settings apply globally to all quote connector ERP connections and affect two dialogs:

* **Add/edit product dialog (user):** Shown when users add a product to a quote line.
* **Add/edit product dialog (admin):** Used in the **SuperOffice products** tab when administrators add products to a price list.

## Steps

1. In Settings and maintenance, select <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Quote/Sync** in the navigator.

1. Go to the **Settings** tab.

1. Click **Configure product**.

    ![Configure product dialog -screenshot][img1]

1. In the dialog, choose the language to configure. You can localize labels and tooltips per language.

1. For each field in the list:

    * **Show field:** Control visibility in the **Add/edit product** dialog for quotes. Fields are always shown in Settings and maintenance. Some fields are greyed-out and cannot be hidden.

        Use **Activate all** or **Deactivate all** to quickly toggle field visibility.

    * **Label:** Enter a user-friendly display name for the field. Leave blank to use the default label.
    * **Tooltip:** Add a short help text shown when users hover over the field. Use the scrollbar if the text is long.
    * **Editable:** Allow users to modify the value.
    * **Mandatory:** Require users to fill out the field in the quote line. Automatically enables **Editable**.

        You can override editable and mandatory settings per product. However, for system-controlled fields, these settings are disabled both in the **Configure product** dialog and in the **Add/Edit product** dialog.

    * **Order:** Use the up/down arrows <i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i> to change the field order in the dialog.

        Field order affects both dialogs. However, a few fields have fixed positions in the **Add/edit product** dialog for quotes and cannot be moved.

1. Click **OK** to save your changes.

1. Optionally, repeat this procedure for additional languages.

## Tips

* Not all fields need to be shown. You can hide fields not to be filled in by users, such as supplier code.

* Provide descriptive labels and tooltips for extra fields.

* Label changes take effect after the next login.

## Related content

* [Add product to a price list][1]
* [Add/edit a product in the quote][2]

<!-- Referenced links -->
[1]: price-list-and-products.md
[2]: ../../learn/quote/create.md#add-products

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/configure-product-dialog.png
