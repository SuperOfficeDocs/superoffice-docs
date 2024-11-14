---
uid: help-en-product-add-to-price-list
title: Add product to price list
description: How to add a product to price list
author: SuperOffice RnD
date: 02.23.2023
keywords: product, price list
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Add product to a price list

After you have added your price list to SuperOffice Quote, you want to populate it with your products, so your salespeople can use them when they create a new sales proposal.

After your products and the product information are added, your salespeople can use the same price details and follow the discount guidelines you have set up.

![You can add as many products and services to your price list as you need -screenshot][img2]

## Steps

In the **Add/Edit product** dialog, you enter all the information about a product, including an image.

1. [!include[Go to products](../includes/goto-products.md)]

1. In the **Price list** list, select the price list you want to add products to.

    [How do I add a price list?][1]

1. Click **Add** at the bottom of the tab. The **Add/Edit product** dialog appears.

1. Enter information about the product and add an image as described below.

1. Check **Include in price list** to make the product available in the price list. You should not do this until you have entered all the necessary information about the product.

1. Click **Save + new** to save this product and add another product.
    Click **Save** to save and close the dialog.
    The product is added to the price list.

> [!NOTE]
> You can also [import products from a spreadsheet][5].

## Add image

See [Select a product image][2].

## Add description

In the field at the lower left you can enter a description of the product.

## Add product information

In the list on the right you can add product information. This can include:

* Text field: Here you enter text and numbers, such as a product name, product code and VAT information.

* Number field: Here you enter a number, such as cost price, minimum price and quantity.

* Lists: Here you select alternatives from the list such as units, product type and product group. You can add more alternatives to these lists in the **Lists** screen [Add items to a list][4].

* Lists with search options : Here you can choose from list of recent records, enter text to start a search, or click the search button (<i class="ph ph-magnifying-glass" aria-hidden="true"></i>) to initiate an advanced search.

### How to change name and order, and make fields editable and/or mandatory

In the [Configure product dialog][3] you define the order and name of the field that are shown here and if they are editable or mandatory.

You can override the editable and mandatory settings by checking **Override default security** at the bottom of the **Add/Edit product** dialog. The changes will only apply for this one product.

### Are all these fields displayed in SuperOffice CRM?

[!include[Why set all fields when creating product](../includes/quote-config-product.md)]

To find out which fields are displayed, go to the **Settings** tab and click **Configure product** (see [Configure products][3]).

<!-- Referenced links -->
[1]: add-price-list.md
[2]: select-product-image.md
[3]: configure.md
[4]: ../../../../admin/lists/learn/adding-items.md
[5]: ../../../../admin/import/learn/import-products-from-excel.md

<!-- Referenced images -->
[img2]: ../../../../../media/loc/en/quote/add-products-to-price-list.png
