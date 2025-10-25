---
uid: help-en-price-list-and-products
title: Manage price lists and products
description: Learn how to create and manage price lists and products in the SuperOffice product register for use in quotes.
keywords: price list, add product, configure product, product image, deactivate product, product, quote
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from:
  - /en/quote/learn/admin/product/add-price-list
  - /en/quote/learn/admin/product/add-product-to-price-list
  - /en/quote/learn/admin/product/index
  - /en/quote/learn/admin/product/quote-delete-deactivate-price-list-or-product
  - /en/quote/learn/admin/product/select-product-image
---

# Manage price lists and products

In the **SuperOffice products** tab of the **Quote/Sync** screen, you define price lists and add products to make them available for quoting in SuperOffice CRM. This setup applies when using the **SuperOffice Standalone connector** (no ERP integration).

![You can add and edit all your price lists in the SuperOffice products tab -screenshot][img2]

Use multiple price lists to support seasonal pricing, campaigns, or different customer segments. Set limited validity to control when each list is available. Add products to your price list so that salespeople can include them in quotes with correct prices and discount rules.

## Add a price list

1. In Settings and maintenance, select <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Quote/Sync** in the navigator.

1. Go to the **SuperOffice products** tab.

1. Click **Add** at the top. The **Add/Edit price list** dialog opens.

1. Fill in the following fields:

    * **Price list name:** Enter a descriptive name (to make it easier to distinguish from any other price lists).
    * **Description:** (Optional) Add a short description.
    * **Active:** Check to activate the list to make it available for creating quotes. You should not activate the price list until it is completely ready.
    * **Limited validity:** (Optional) Enable and set a date range if the list should only be available for a specific period. You can choose a start and end date *OR* just an end date.

    > [!NOTE]
    > You cannot change the currency or validity after creating the price list. To enable multiple currencies, go to **Preferences** > **System** > **Enable use of currency**.

1. Choose one of the following options:

    * **Add empty price list:** Start from scratch.
    * **Copy existing price list:** Duplicate an existing list.
      * **Convert prices from original price list to &lt;currency&gt;**: Select this option to use the existing prices in the price list. If you copy a price list with a different currency that the price list you are creating, the prices are converted into the right currency.

      * **Set prices to zero &lt;currency&gt;**: Select this option if you do not want to copy the prices from the price list. You must enter the prices of all the products in the price list manually.

1. Click **OK**.

## <a id="add-product"></a>Add products to a price list

1. In the **SuperOffice products** tab, select a price list.

1. Click **Add** at the bottom. The **Add/Edit product** dialog opens.

1. Fill in the product details. You can configure:

    * Text fields (name, code, VAT, and so on)
    * Number fields (cost, minimum price, quantity)
    * Dropdown lists (units, product group, product type)
    * Searchable lists (for suppliers or related items) Here you can choose from list of recent records, enter text to start a search, or click the search button (<i class="ph ph-magnifying-glass" aria-hidden="true"></i>) to initiate an advanced search.

1. (Optional) Click **Change image** to add a product image.

1. (Optional) Add a description in the lower-left text area.

1. (Optional) Check **Override default security** to adjust field-level security for this product.

1. Check **Include in price list** to activate the product. You should not do this until you have entered all the necessary information about the product.

1. Click **Save** or **Save + new** to continue adding products.

> [!TIP]
> You can add more alternatives to these lists in the **Lists** screen.
>
> You can [import products from a spreadsheet][5] instead of adding them manually.

## <a id="image"></a>Add or change product image

Add high quality product images to your proposals to show your customers the products they are interested in.

1. Select a price list and double-click a product.

1. Click **Change image** at the bottom of the preview area in the **Add/Edit product** dialog.

1. In the **Select image** dialog, select an image from the database. Only available images are shown.

1. Click **OK** to add the image to the product.

![You can add an image to every product you add to your price list -screenshot][img1]

[!include[File type and size](../../../learn/includes/image-type-and-size.md)]

## <a id="deactivate"></a>Deactivate products or price lists

We recommend **deactivating** items rather than deleting them, to preserve quote history and avoid errors. Deactivated products and price lists are not available for new quotes but remain in existing ones.

### Deactivate a price list

1. Select a price list and click **Edit**.
2. Do one of the following:
    * Uncheck **Active**
    * Enable **Limited validity** and set a past **Valid to** date
3. Click **OK**.

### Deactivate a product

1. Select the price list containing the product.
2. In the product list, clear the checkbox next to the product you want to deactivate.

## <a id="export"></a>Export a price list

1. In the **SuperOffice products** tab, select a price list.
2. Click <i class="ph ph-download-simple" aria-hidden="true"></i> **Export** at the bottom.

You can export selected products or the entire list.

> [!TIP]
> Make sure you [adjust visible columns][4] before exporting.

### Export not available?

Check if the user has [access rights][7] and that the export [preference][8] is enabled.

## Related content

* [Configure fields in the Add/edit product dialog][3]
* [Import products from Excel][5]
* [Set up ERP connection][1]

<!-- Referenced links -->
[1]: set-up-quote-connector.md
[3]: configure-product-fields.md
[4]: ../../../learn/section-tabs/configure-columns.md
[5]: ../../../admin/import/products-from-excel.md
[7]: ../../../admin/user-management/role/index.md
[8]: ../../../admin/preferences/index.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/sale/add-products-to-price-list.png
[img1]: ../../../../media/loc/en/sale/add-edit-product.png
