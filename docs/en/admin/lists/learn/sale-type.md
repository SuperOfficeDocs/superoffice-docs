---
uid: help-en-sale-add-type
title: Add sale type
description: Add sale type
author: SuperOffice RnD
date: 06.29.2022
keywords: sale type
topic: howto
language: en
---

# Add sale type

[!include[Must be admin](../../../learn/includes/req-admin.md)]

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

> [!NOTE]
> A quote belongs to a sale, and all sales have a sale type. In each sale type, you can define many of the properties of a quote, such as attachments, settings for approval, use of alternatives and templates.

[!include[Edit list item](includes/edit-list-item.md)] when the list items are sale types:

1. Enter the required name of the item in the **Name** field.

    [!include[Mandatory](includes/note-mandatory-field.md)]

2. Select the required category for the sale type in the **Sale type category** list box.

    > [!TIP]
    > You can create new options in addition to the predefined ones by [adding items][2] to the **Sale - Category (for sale type)** list in Settings and maintenance.

3. In the **Estimated time for this sale process**, enter a duration for the sale type (number of weeks, days or months). When you create a new sale of this sale type, the sale date is set relative to the time you enter here (today's date + estimated time).

4. Enter a description of the sale type at the bottom of the dialog.

5. Enter information in the **Stages**, **Quote attachments**, **Quote defaults** and **Quote approval** tabs. This is described below.

    > [!NOTE]
    > The **Quote attachments**, **Quote defaults**, and **Quote approval** tabs are relevant only if you have the Sales Quote Management license.

6. [!include[Save or cancel](includes/save-or-cancel.md)]

## Stages tab

In the **Stages** tab, you do the following:

1. In the **Stages used for this sale type** list, check off the stages you want to include for the sale type. This step is optional, but to link the sale type to a sales guide, you should check at least two stages.

    [How to create a stage][3].

2. Check **This sale type is linked to a guide** if you want all sales of this sale type to follow a [sales guide][5].

3. If you wish, select **Suggest moving the sale into next stage automatically**.

    When all follow-ups and documents for a stage are completed, you will be asked if you want to move to the next stage.

4. Check **This sale type has stakeholders** to allow linking of [stakeholders][4] to sales of this sale type.

## Quote attachments tab

In the **Quote attachments** tab you can add documents to be sent to the customer along with a quote. For example, product specs, brochures and so on.

> [!NOTE]
> The documents must first be added as document templates in SuperOffice.

### Add quote attachment

1. Click **Add**.
2. In the Find screen, [search for the documents you want to add][1].
3. Select one or more documents and click **OK**. The documents are displayed in the **Quote attachments** tab.
4. Select the documents you want to include in the **Include** column.

When you create a quote with this sale type, the selected documents are added to the quote as attachments. They will not however be added in the **Activities** section tab in the sale.

## Quote defaults

Settings for quotes with this sale type:

* **Allow alternatives to be added to quote**: Check here if users are to be allowed to add several alternatives to a quote.
* **Default days a quote is valid**: Enter the number of days a quote will remain valid for. This value can be changed when the quote is sent.
* **Quote format template**: Check the template you want to use for the quote.
* **Order confirmation template**: Check the template you want to use for the confirmation.

## Quote approval

Here you can choose if the quote must be approved if the total discount is above a certain threshold or the total earnings are below a certain threshold:

* No approval required. No limits. The quote will not require approval.
* **Total discount is over limit**. Enter a percentage value.
* **Total earning is below limit**. Enter a percentage value.

## Related content

* [Quote templates][6]

<!-- Referenced links -->
[2]: adding-items.md
[3]: ../../../sale/learn/screen/sale-stage.md
[4]: ../../../sale/learn/stakeholders/index.md
[5]: ../../../sale/learn/screen/sales-guide-admin.md
[1]: ../../../search-options/learn/search-criteria.md
[6]: ../../../document/templates/learn/quote-templates.md

<!-- Referenced images -->
