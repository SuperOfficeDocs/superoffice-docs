---
uid: help-en-quote-template-tutorial
title: Customize order confirmation template
description: Customize order confirmation template
keywords: document template, document, template, quote, order confirmation
author: Bergfrid Dias
date: 07.31.2024
version: 10
topic: tutorial
language: en
audience: settings
audience_tooltip: Settings and maintenance
---

# Customize order confirmation template

In this tutorial, we will use an order confirmation template as a basis to create a new template.

We will:

* Add the name of the alternative (taken from the quote).
* Add the number of lines in the alternative.
* Add a thumbnail of the product.
* Sort the products by product name.
* Group the products in the template document by product family. A product family could for example be "hardware", "software" or "accessory".
* Enter a sum total for the products in each group, but retain the sum total for the alternative that already exists in the template document.

## Preparations

### Create a sale for testing the template

1. In SuperOffice CRM, [create a quote][5] with various products from different product families to test the grouping feature.

2. Ensure the sale has the same type as the one you will link the template to (later in this tutorial).

3. In the quote, click **Place Order** to enable the **Show Confirmation** button.

### Select the fields to be displayed

1. Verify that the required product fields are visible in the **Configure Product** dialog.

* Only fields marked as visible in Settings and maintenance will appear in the template.

* See [Configure products][4] for more details on setting field visibility.

### Copy the template to be modified

1. In Settings and maintenance, select **Lists** from the Navigator.
2. Click the arrow and select **Document - Template**.
3. Double-click the *Order Confirmation* template and click **Edit** to open it in Microsoft Word.
4. Save the document with a new name in an easily accessible location.
5. [Add the template document][1].
6. Name the document logically, such as *Order Confirmation – Grouped*.
7. Check the **Quote document type** option to make it available for quotes in SuperOffice CRM.
8. Select the **Template for order confirmations type**.

### Link the template document to a sale type

1. In the **Lists** screen, double-click **Sale - Type, Stages, Quote**.
2. In the **List items** overview, double-click a sale type to open the **Edit list item** dialog.
3. Go to the **Default values** tab, open the **Order confirmation template** list, and select your new template.
4. Click **OK** to save your changes.

## Modify the template

In this section, you will learn how to modify the template document by inserting fields, adding product images, grouping products, and choosing sorting orders.

### Insert fields in Word

1. Open the template document from the **Document - Template** list.

1. **Copy** an existing field from the template. Ensure you copy the entire field, including the «» brackets.

1. **Paste** the field into your template after the title ("Details").

1. Right-click the pasted field and select **Edit fields**. In the **Field name** box under **Field properties**, enter *alternative/name* (without «»). Click **OK**.

    > [!NOTE]
    > It is important that you distinguish between capital and lower-case letters when you type in the field names.

1. Copy an existing field (again) and paste it below the product table (left-aligned on the same row as the sum total for the alternative).

1. Enter *alternative/numLines* as field name and click **OK**.

1. Enter the label *Lines:* to the left of the numLines field.

1. Insert a new column with the title "Image" (`Image:line/quoteLineThumbnail`.)

1. Your template should now look like this:

    ![Order confirmation with new fields -screenshot][img1]

1. Save the template document, but do not close it.

### View the order confirmation in SuperOffice CRM (optional)

To ensure your changes are correctly reflected, follow these steps to view the order confirmation:

1. **Open a sale** of the same type to which your template is linked.
2. Navigate to the **Quote** tab within the sale and click **Open**.
3. Click **Place order** if you have not done so already.
4. In the **Edit quote** dialog, click **Show confirmation**. The order confirmation will open as a PDF file.
5. Verify the order confirmation:
    * Ensure all table content displays correctly, with no numbers split over two lines.
    * Check that no field names appear in the document; if they do, you might have used incorrect field names.
    * Confirm that all inserted fields are present. Missing fields might indicate that the required data is not available in the quote or product.
6. Make any necessary adjustments to the template and save it.
7. Review the order confirmation again to ensure all changes are correctly displayed.

### Specify sort order

1. Insert the **OrderBy** field in the template document.

    `«TableStart:alternative»«OrderBy:name»`

Products will now be sorted by product name within each alternative. After defining the grouping area, products will also be sorted within each group.

### Specify the grouping area and key

1. Insert `«TableStart:group»` before TableStart:line.
1. Insert `«TableEnd:group»` after TableEnd:line.
1. Insert `«GroupBy:productFamilyKey»` anywhere in the document to define the grouping key.

### Add group-specific fields

1. Move the table with the sum total for the alternative (including the total number of lines) down a few lines, so that you have room to insert the group fields between TableStart:group and TableEnd:group.

1. Between the title and the table containing the products, insert `«group/groupField»`. Give the field a header style.

    This is the title of the group (the name of the field by which the products are grouped).

1. At the bottom of the column with prices, insert `«group/sumtotalPrice»`.

    This is the sum total for the entire group.

1. In the cell to the left of the sum total for the entire group, insert `«group/groupField»`. Type in the label *Sum* to the left of the field.

### Save and verify

1. Your template should now look like this:

    ![Order confirmation result -screenshot][img2]

1. Save the template document and verify as described above.

## Related topics

* [Create a template document][2]
* [Template variable reference][3]

<!-- Referenced links -->
[1]: link-template.md
[2]: ../learn/create.md
[3]: ../variables/index.md
[4]: ../../../quote/learn/admin/product/configure.md
[5]: ../../../sale/learn/create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/tutorial-insert-fields.png
[img2]: ../../../../media/loc/en/document/tutorial-grouped.png
