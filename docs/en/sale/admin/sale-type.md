---
uid: help-en-sale-type-add
title: Add sale type
description: Add sale type
keywords: add sale type, Sale - Type Stages Quote list, Sale - Category list, Quote attachments tab, Quote defaults, Quote approval, sale type, sale, quote
author: Bergfrid Dias
date: 01.03.2025
version: 10.5.2
topic: howto
license: salesessentials
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Sale type

[!include[Must be admin](../../learn/includes/req-admin.md)]

The **Sale type** field in the Sale screen categorizes sales and defines their workflows. These types are predefined in the **Sale - Type, Stages, Quote** list, which you can manage in **Settings and maintenance** under **Lists**.

Each sale must have a type, and these types can be linked to specific [stages][1] and, optionally, to [sales guides][4]. Sales guides streamline the process by guiding sales staff through predefined stages, follow-ups, and documents.

## Add a sale type

1. Select <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lists** in the Navigator.

1. Select **Sale - Type, Stages, Quote** from the dropdown menu. The **Items** tab displays all existing sale types.

1. Click **Add** to open the **Edit list item** dialog.

    ![Edit list item dialog showing fields for sale type configuration -screenshot][img1]

1. Enter a name for the sale type in the **Name** field. *(Mandatory)*

    This name will appear in the **Sale type** field on the Sale card.

1. Select the required category for the sale type from the **Sale type category** list.

    > [!TIP]
    > You can create new options in the **Sale - Category (for sale type)** list.

1. Specify the typical sales duration in the **Estimated time for this sale process** field (number of weeks, days or months).

    This determines the default end date when creating a sale.

1. In the **Stages** tab, select the required stages in the **Stages used for this sale type** list.

    > [!NOTE]
    > To link the sale type to a sales guide, select at least two stages.

1. (Optional) Check **This sale type is linked to a guide** to link the sale type to a [sales guide][4].

1. (Optional) Check **Suggest moving the sale into next stage automatically** to prompt users to move to the next stage when all activities for the current stage are completed.

1. (Optional) Check **This sale type has stakeholders** to allow linking of [stakeholders][5] to sales of this type. *(Requires the SalesPremium license)*

1. Add a description of the sale type in the **Description** field, if needed.

1. For quote management, configure the fields in the **Quote attachments**, **Quote defaults**, and **Quote approval** tabs as described in [Quote fields explained](#quote-fields) below. *(Requires the SalesPremium license)*. These settings allow you to tailor quotes to match your organization's specific needs and processes.

1. Click **Save** to apply your changes or **Cancel** to discard them.

1. In the **Stages used for this sale type** list, check off the stages you want to include for the sale type. This step is optional, but to link the sale type to a sales guide, you should check at least two stages.

## <a id="quote-fields"></a>Quote fields explained

A quote belongs to a sale, and all sales have a sale type. In each sale type, you can define many of the properties of a quote, such as attachments, settings for approval, use of alternatives and templates.

<!-- markdownlint-disable MD051 -->
### [Quote attachment tab](#tab/quote-attachment)

In the **Quote attachments** tab, you can add documents to be sent to the customer along with a quote, such as product specifications or brochures.

> [!NOTE]
> The documents must first be added as document templates in SuperOffice.

#### Add quote attachments

1. Click **Add**.
1. In the **Find** dialog, [search for the documents you want to add][7].
1. Select one or more documents and click **OK**. The documents are displayed in the **Quote attachments** tab.
1. Select the documents you want to include in the **Include** column.

When creating a quote with this sale type, the selected documents are attached to the quote. However, they will not appear in the **Activities** section tab for the sale.

### [Quote defaults tab](#tab/quote-defaults)

In the **Quote defaults** tab, configure the following:

* **Allow alternatives to be added to quote:** Check to allow multiple alternatives in a single quote.
* **Default days a quote is valid:** Set the number of days a quote remains valid. This value can be adjusted when the quote is sent.
* **Quote format template:** Select the template to use for the quote.
* **Order confirmation template:** Select the template to use for order confirmations.

### [Quote approval tab](#tab/quote-approval)

In the **Quote approval** tab, specify if approval is required for quotes under certain conditions:

* **No approval required:** No limits. The quote does not require approval.
* **Total discount is over limit:** Enter a percentage threshold for discounts requiring approval.
* **Total earnings are below limit:** Enter a percentage threshold for earnings requiring approval.

***
<!-- markdownlint-enable MD051 -->

## Edit or delete a sale type

1. Follow steps 1–2 in **Add a sale type** to access the **Sale - Type, Stages, Quote** list.

1. To edit:
   * Double-click the required sale type to open the **Edit list item** dialog.
   * Update the fields as needed and click **Save**.

1. To delete:
   * Select the sale type in the list and click **Delete**.

    > [!CAUTION]
    > Deleting a sale type also removes its link to stages and sales guides. Ensure it is not in active use before proceeding.

## <a id="restore"></a>Restore a deleted sale type

If a sale type has been deleted, you can restore it from the **Sale - Type, Stages, Quote** list. However, restoring does not automatically reestablish any links between the restored item and related sale stages or guides. You must recreate these connections manually if needed.

1. Go to the **Sale - Type, Stages, Quote** list.

1. Check **Show deleted items and headings** in the footer. Deleted items appear strike-through in the **Items** tab.

1. Double-click the deleted item you want to restore. The **Edit list item** dialog opens.

1. Click **Restore**.

1. Update any necessary fields and click **Save**. The item is now active and will appear in the **Items** tab.

## Related content

* [Add a sale stage][1]
* [Create a sales guide][2]
* [Edit a sales guide][3]
* [Quote templates][6]

<!-- Referenced links -->
[1]: sale-stage.md
[2]: create-sales-guide.md
[3]: edit-sales-guide.md
[4]: ../learn/sales-guides.md
[5]: ../learn/stakeholders/index.md
[6]: ../../document/templates/learn/quote-templates.md
[7]: ../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/edit-sale-type.png
