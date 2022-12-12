---
uid: help-en-so-add-product-to-price-list
title: SO add product to price list
description: SO add product to price list
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add product to a price list

In the **Add/Edit product** dialog, you enter all the information about a product, including an image.

[!include[Go to products](../includes/goto-products.md)]

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

In the field at the bottom left you can enter a description of the product.

## Add product information

<details><summary>How do I change the name and order of these fields and define if they should be editable and/or mandatory?</summary>

In the [Configure product dialog][3] you define the order and name of the field that are shown here and if they are editable or mandatory.

You can override the editable and mandatory settings by checking **Override default security** at the bottom of the **Add/Edit product** dialog. The changes will only apply for this one product.
</details>

In the list on the right you can add product information. This can include:

* Text field: Here you enter text and numbers, such as a product name, product code and VAT information.

* Number field: Here you enter a number, such as cost price, minimum price and quantity.

* Lists: Here you select alternatives from the list such as units, product type and product group. You can add more alternatives to these lists in the **Lists** screen [Add items to a list][4]).

* Lists with search options ( ![icon][img1] ): Here you can choose from list of recent records, enter text to start a search, or click the search button ![icon][img1] to initiate an advanced search.

<details><summary>Are all these fields displayed in SuperOffice CRM?</details>

[!include[Why set all fields when creating product](../includes/quote-config-product.md)]

To find out which fields are displayed, go to the **Settings** tab and click **Configure product** (see [Configure products][3]).
</details>

<!-- Referenced links -->
[1]: so-add-price-list.md
[2]: so-select-product-image.md
[3]: settings-configure-product.md
[4]: ../../../../settings/lists/adding-items.md
[5]: ../../../../import/import-products-from-excel.md

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/search-icon-black.png
