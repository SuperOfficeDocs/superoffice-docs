---
uid: help-en-so-add-product-to-pricelist
title: SO add product to pricelist
description: SO add product to pricelist
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add products to a price list

In the **Add/Edit product** dialog, you enter all the information about a product, including an image.

To add a product to a price list in SuperOffice CRM:

1. Go to the **Quote/Sync** screen.
2. Select the **SuperOffice products** tab.
3. In the **Price list** list, select the price list you want to add products to. If you want to add a new price list, see [Add a price list](SO_add_pricelist.md).
4. Click **Add** at the bottom of the tab. The **Add/Edit product** dialog appears.
5. Enter information about the product and add an image as described below.
6. Check **Include in price list** to make the product available in the price list. You should not do this until you have entered all the necessary information about the product.
7. Click **Save + new** to save this product and add another product. Click **Save** to save and close the dialog. The product is added to the price list.

> [!NOTE]
> You can also import products from a spreadsheet. See [Import products from Excel](../import_web/Import_products_from_Excel.md).

## Add image

See [Select a product image](SO_select_product_image.md).

## Add description

In the field at the bottom left you can enter a description of the product.

## Add product information

<!-- Fix reuse ID=a1 -->

In the **Configure product** dialog (see [Configure products](settings_configure_product.md)) you define the order and name of the field that are shown here and whether they are editable or mandatory. You can override the editable and mandatory settings by checking **Override default security** at the bottom of the **Add/Edit product** dialog. The changes will only apply for this one product.

In the list on the right you can add product information. This can include:

* Text field: Here you enter text and numbers, such as a product name, product code and VAT information.
* Number field: Here you enter a number, such as cost price, minimum price and quantity.
* Lists: Here you select alternatives from the list such as units, product type and product group. You can add more alternatives to these lists in the **Lists** screen [Add items to a list](../chap08/Adding_items.md)).
* Lists with search options ( ![icon](../media/Soek.bmp) ): Here you can choose from list of recent records, enter text to start a search, or click the search button ![icon](../media/Soek.bmp) to initiate an advanced search.

<!-- Fix reuse ID=a2 -->

Since some of these fields are not to be filled in by users, it is not necessary to display them in the **Product** dialog in SuperOffice CRM. It is nonetheless important to complete these fields when you create new products in the **Add/edit product** dialog. This might apply to, for example, product category/group, supplier code or specific extra fields.

If you want to know which fields are displayed or not displayed, go to the **Settings** tab and click **Configure product** (see [Configure products](settings_configure_product.md)).
