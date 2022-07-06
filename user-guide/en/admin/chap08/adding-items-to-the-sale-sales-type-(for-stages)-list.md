---
uid: help-en-adding-items-to-the-sale
title: Adding items to the Sale - Sales type (for stages) list
description: Adding items to the Sale - Sales type (for stages) list
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add items to the Sale – Type, Stages, Quote list

When you add an item to the **Sale – Type, Stages, Quote** list, the **Edit list item** dialog is not the same as described under [Add items](Adding-items.md).

> [!NOTE]
> A quote belongs to a sale, and all sales have a sale type. In each sale type, you can define many of the properties of a quote, such as attachments, settings for approval, use of alternatives and templates.

To complete the fields in the **Edit list item** dialog when the list items are sale types:

1. Enter the required name of the item in the **Name** field.

    > [!NOTE]
    > This is a mandatory field and must therefore be filled in.

2. Select the required category for the sale type in the **Sale type category** list box.

    > [!TIP]
    > You can create new options in addition to the predefined ones by adding items to the **Sale - Category (for sale type)** list in Settings and maintenance. Follow the procedure under [Add items](Adding-items.md).

3. In the **Estimated time for this sale process**, enter a duration for the sale type (number of weeks, days or months). When you create a new sale of this sale type, the sale date will be set relative to the time you enter here (today's date + estimated time).

4. Enter a description of the sale type at the bottom of the dialog.

5. Enter information in the **Stages**, **Quote attachments**, **Quote defaults** and **Quote approval** tabs. This is described below.

    > [!NOTE]
    > the **Quote attachments**, **Quote defaults** and **Quote approval** tabs are only relevant if you have access to the quotes module.

6. Click **Save** to save the changes in Settings and maintenance, or **Cancel** to reject your changes.

## Stages tab

In the **Stages** tab, you do the following:

1. In the **Stages used for this sale type** list, check off the stages you want to include for the sale type. This step is optional, but if you want to link the sale type to a sales guide, you should check at least two stages. For more details on how to create stages, see [Sale - Stage](Sale-Stage.md).
2. Check **This sale type is linked to a guide** if you want all sales of this sale type to follow a [sales guide](../Sale/Sale.md).
3. If you wish, select **Suggest moving the sale into next stage automatically**. When all follow-ups and documents for a stage have been completed, you will be asked if you want to move to the next stage.
4. Check **This sale type has stakeholders** if you want to allow linking of stakeholders to sales of this sale type. See [Sale - Stakeholder Role](Sale-Sales-role-(Stakeholders).md).

Quote attachments tab

In the **Quote attachments** tab you can add documents to be sent to the customer along with a quote. These might be, for example, product specs, brochures and so on.

> [!NOTE]
> The documents must first be added as document templates in SuperOffice.

To add quote attachments:

1. Click **Add**. The **Find** dialog opens.
2. Search for the document(s) you want to add. See [Use search criteria](../chap06/using-search-criteria.md).
3. Select one or more documents and click **OK**. The document(s) is/are displayed in the **Quote attachments** tab.
4. Select the documents you want to include in the **Include** column.

When you create a quote with this sale type, the selected documents will be added to the quote as attachments. They will not however be added in the **Activities** section tab in the sale.

## Quote defaults

Here you specify the following settings for quotes with this sale type:

* **Allow alternatives to be added to quote**: Check here if users are to be allowed to add several alternatives to a quote.
* **Default days a quote is valid**: Enter the number of days a quote will remain valid for. This value can be changed when the quote is sent.
* **Quote format template**: Check the template you want to use for the quote.

[!include[Link to quote template docs](../includes/learn-quote-templates.md)]

* **Order confirmation template**: Check the template you want to use for the confirmation.

## Quote approval

Here you can choose whether the quote must be approved if the total discount is above a certain threshold or the total earnings are below a certain threshold:

* No approval required. No limits. The quote will not require approval.
* **Total discount is over limit**. Enter a percentage value.
* **Total earning is below limit**. Enter a percentage value.

<!-- Referenced links -->
[1]: ../Quote-templates.pdf

<!-- Referenced images -->
