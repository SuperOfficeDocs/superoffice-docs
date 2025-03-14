---
uid: help-en-sale
title: Sale
description: SuperOffice Sales helps sales teams stay in control of their sales pipelines and processes.
keywords: Sale card, Sale screen, sale, lead
author: Bergfrid Dias
date: 01.06.2025
version: 10.3.11
topic: concept
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Sale

The **Sale** feature in SuperOffice CRM helps you manage sales opportunities efficiently by tracking all related information, activities, and documents in one place. By structuring sales processes, you can ensure no opportunities are missed, and your team is always focused on the most critical tasks - closing more deals and hitting their targets.

![Sales screen -screenshot][img1]

You can link sales to companies, contacts, and projects, enabling seamless collaboration across teams. Sales can also be guided using sales guides, assuming the selected sale type has a guide defined.

Watch this video and see how easy pursuing sales opportunities can be with SuperOffice CRM:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/VTgBzMk_qvk]

(video length - 2:16)

The Sale screen organizes sales like index cards, providing a detailed overview of each opportunity. Navigate between sales using the **Previous** and **Next** buttons (<i class="ph ph-caret-circle-left" aria-hidden="true"></i><i class="ph ph-caret-circle-right" aria-hidden="true"></i>) at the lower right of the cards. By default all sales are displayed. If you do not want to show completed sales (sold or lost), click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and select **Skip completed sales**.

> [!TIP]
> Sales are also visible in the [Sales section tab][13] of the Company, Contact, Project, and Diary screens. Double-click a sale in these locations to open it in the Sale screen.

## Tabs on the Sale card

| Tab | Description |
|---|---|
| [Sale][4] | Contains the main fields for the sale, such as Title (mandatory), Stage, and Amount. |
| [Details][4] | Focuses on financial details, including Total Cost, Profit, and Competitor. |
| [More][12] | Custom fields for additional sale-specific information. Up to three fields from this tab can also appear in the **Sale** tab for better visibility. |
| [Notes][19] | Free text area to add notes about the sale. The tab is marked with a dot when it contains text. |
| [Links][18] | Connect relevant activities, documents, or opportunities to the sale. |

Each tab serves a specific purpose, ensuring sales information is organized and easily accessible.

## <a id="section-tabs"></a>The Sale screen section tabs

The lower part of the Sale screen consists of section tabs.

* [Activities][14]
* [Sales guide][16] (requires Sales Premium)
* [Stakeholders][15] (requires Sales Premium)
* [Quote][17] (requires Sales Premium)

[Sales guides][3] are only shown for specific sale types (defined in Settings and maintenance). If you select a sale type for which a sales guide is defined, the **Sales guide** section tab is displayed.

[!include[Add more section tabs](../../learn/includes/more-tab.md)]

## Stalled, sold, and lost sales

In the **Stage** field on the **Sale** tab, you can:

* **Mark a sale as Sold** or **Lost**: This updates the sale's status and allows you to specify details like competitors or reasons for the outcome.
* **Mark a sale as Stalled**: Puts the sales process on hold. Additional fields like **Re-open date** and **Reason (stalled)** become available.

| Icon | Meaning |
|:-:|---|
| <i class="ph ph-currency-circle-dollar" aria-label="Sale icon"></i> | Open |
| <i class="ph ph-check" aria-label="Check icon"></i> | Sold |
| <i class="ph ph-x" aria-label="X icon"></i> | Lost |
| <i class="ph ph-triangle" aria-label="Red triangle icon"></i> | Stalled |

## Use sales overview to prioritize

Keep your sales organized so that you are always focused on the sales that matter the most to you.

After you have registered all your sales in SuperOffice CRM, they will appear in your personal sales overview in the **Sales** section tab and in your Diary. You can organize your sales list by [filtering, grouping and adding the columns][3] that are most important for you. The most used columns are sales amount, sales date and sale stage.

The **Sales** tab also acts like a sales secretary by highlighting all your upcoming planned activities in the **Next Activity** field, as well as drawing your attention to those that you may have forgotten in red font.

![Go to the Diary and get an overview of all the sales that are not yet completed -screenshot][img3]

## <a id="side-panel"></a>Using the side panel for sales

When you have the **Sale** screen open, you can use the **Selection members** [side panel][20] to view your sales opportunities. Select any sales opportunity to view it in detail in the **Sale** screen.

![Use the side panel on the sale card to view selection members and the sale selection -screenshot][img2]

### Tips for efficiency

* **Check overdue sales**: Sales opportunities marked in **red** in the **Selection members** list indicate overdue activities or sale dates. Make sure to review and update these.

* **Sequential review**: Use the side panel to click through your sales one by one, ensuring you know the current status of each and have appropriate follow-up activities in place.

* **Similar workflows**: You can use selections for contacts as a calling list or follow up on outstanding sales proposals to ensure no opportunity is missed.

For more details on setting up your sales opportunities, see the [guide to sales forecasting][21].

## Related content

* [Add sale as a favorite][10]
* [Register a sale][4]
* [Add stakeholders][5]
* [Mark sale as stalled, lost, or sold][2]
* [Create a quote][1]
* [Work with sales guides][6]
* [Work with sales targets][7]
* [Print info about a sale][11]

<!-- Referenced links -->
[1]: ../../quote/learn/create.md
[3]: ../../learn/section-tabs/index.md
[13]: ../../learn/section-tabs/sales-tab.md
[14]: ../../learn/section-tabs/activities-tab.md
[4]: create.md
[2]: update.md#stalled
[5]: stakeholders/create.md
[15]: stakeholders/index.md
[6]: tutorial.md
[16]: sales-guides.md
[7]: sales-targets/index.md
[21]: forecasting.md
[10]: ../../learn/basics/fav.md
[11]: ../../learn/basics/print.md
[18]: ../../learn/basics/links.md
[19]: ../../learn/basics/notes.md
[20]: ../../learn/getting-started/main-screen/side-panel.md
[12]: ../../custom-objects/learn/more-tab.md
[17]: ../../quote/learn/quote-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/sales-screen.png
[img2]: ../../../media/loc/en/sale/getstarted-sidepanel-saleselection.png
[img3]: ../../../media/loc/en/sale/user-diary-sales.png
