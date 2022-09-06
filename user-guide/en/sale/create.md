---
uid: help-en-sale-create
title: Record a sale
description: Record a sale
author: SuperOffice RnD
so.date: 07.04.2022
keywords: sale
so.topic: help
language: en
---

# Record a sale

In the **Sale** screen you can enter information about sales on several levels, represented by the **Sale**, **Details**, **Links** and **Note** tabs.

To edit an existing sale, browse to the sale and click **Edit** at the bottom of the **Sale** screen.

> [!NOTE]
> When you browse through sales using the arrow keys (or similar) and when you search for sales using FastSearcher, by default all sales are displayed. If you do not want to show completed sales (i.e. ones that are sold or lost), click ![icon][img1] **Task** and select **Skip completed sales**.

## Create the sale

1. Click **New** on the top bar and select **Sale**. An empty sale card opens.

    ![New sale -screenshot][img1]

2. Type in the name of the sale in the field with a red underline. This field is mandatory.

3. Enter the required information in the other fields.

    <details><summary>What goes in the various fields?</summary>

    [!include[Steps to populate company fields](includes/sale-fields.md)]

    </details>

4. Optionally, go to the **Details**, **Links**, or **Note** tab to enter further information about the sale.

5. When you have entered the required information in all the tabs, click **Save**. You have now created a sale card for the new sale.

## The Details tab

This tab contains fields that focus, in particular, on the financial details of the sale.

![Sale Details tab -screenshot][img1]

| Field | Description | Defined in Settings and maintenance |
|---|---|---|
|Number | The ID number for the sale, where the next free sale number is entered automatically. | x |
| Source | Displays the source of the sale, as specified in the **Sale** tab. You can also edit the source here. |
| Competitor | Contains a predefined list of competitors. Here you can enter any competitor for the sale. You can only choose one competitor. | x |
| Total cost | Enter here the cost connected with the sale. It is displayed in the same currency as the amount. The default value is 0. When you enter an amount in this field, the profit percentage and amount are automatically calculated in the field below. | |
| Profit | Enter the profit connected with the sale here. It is displayed in the same currency as the amount. | |
| Credited | Contains a predefined list of departments that can be responsible for the sale. | x |
| User-defined fields | In the user-defined fields you can enter further information about the sale. | |

> [!NOTE]
> If you change the value in the **Total cost** field, the **Profit** field or the field for the profit percentage, the other fields are automatically updated.

## The Links tab

Here you can add links that are relevant for the sale you are working on, such as URL addresses, projects, other sales, follow-ups and documents. For example, if you are going to a meeting with a company you have previously communicated with, you can add links to documents you have already created for this company.

[!include[How to add links](../includes/howto-add-links.md)]

### Open links

You can open links by clicking on them in the **Links** tab. URLs/websites open in a new window.

### Remove links

If you want to remove a link, go to the **Links** tab, click **Edit**, click the delete button next to the link. The link will be deleted from the tab.

## The Note tab

[!include[About the Note tab](../includes/about-note-tab.md)]

## What would you like to do now?

* [Create a quote][4]

<!-- Referenced links -->
[4]: quote/create.md

<!-- Referenced images -->
[img1]: ../../media/icons/btn-menu.png
