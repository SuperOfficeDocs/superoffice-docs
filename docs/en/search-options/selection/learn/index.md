---
uid: help-en-selection
title: Selection
description: Selection
keywords: dynamic selection, static selection, combined selection, selection member, Selection screen, selection member, selection
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: concept
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/search-options/selection/learn/combined-selections
  - /en/search-options/selection/learn/dynamic-selections
  - /en/search-options/selection/learn/static-selections
  - /en/search-options/selection/learn/screen/index
---

# Selection

You can create selections of records/data that you work a lot with.

> [!TIP]
> You can create charts from selections and also use selections to create mailings.

All the selections also contain an overview of companies and contacts linked to the records in the selection. For example, companies and contacts linked to the sales in a sale selection.

## <a id="types"></a>Types

There are three different types of selections in SuperOffice CRM:

* **Static selection:** Contains only manually added members.
* **Dynamic selection:** Automatically updates with members that match the selection criteria.
* **Combined selection:** A combination of two existing selections.

### Static selections

A static selection contains only the members you added individually or by searching, in contrast to a dynamic selection. After you created a static selection and added members to it, it will always contain the same members until you either add or remove some.

Use a static selection to maintain absolute control at all times of its members. You can manually [add and remove members][7], either one by one or through a search.

Example: A hand-picked list of VIP customers for a personalized outreach campaign.

### Dynamic selections

A dynamic selection can be compared to a saved search that is executed each time you view the selection. Each time you add records to SuperOffice CRM containing data that fulfil the search criteria in a dynamic selection, the selection will be updated with the new member, unlike a static selection.

Use a dynamic selection if you want an updated list of companies, contacts, sales, projects, documents, follow-ups, requests or products that meet a specific set of criteria.

Example: A real-time list of all open sales opportunities in the current quarter, automatically updated as new deals are created.

### Combined selections

A combined selection is a combination of two existing selections (static or dynamic). It can contain records that are common to the two existing selections, records that are different, records that are only in one of the selections or all records in the two selections.

Example: A filtered view of all customers who purchased a specific product and have an open support request, helping you prioritize follow-ups.

After [creating a combined selection][4], you can choose to turn it into a static selection.

## <a id="tabs"></a>Tabs in the Selection screen

| Tab | Description |
|---|---|
| List of members | Displays the list of records in the selection. |
| Company/contact | Shows companies and contacts linked to selection members. If the selection is for companies or contacts, this is the only tab with members. |
| Criteria | View and [edit the criteria][9] for a dynamic selection. |
| Details | View and edit general selection information. |
| Charts | [View selection data as a chart.][3] Charts can also be used in [dashboards][16]. |
| Mailings | Show mailings archived on this selection. [Create a mailing][8] to contacts in the selection. |

> [!TIP]
> Click <i class="ph ph-gear" aria-label="Gear"></i> to the right of the column headers in a selection to group and filter records, add/remove columns, and specify calculations. These settings can be saved for the active selection by selecting **Save columns for current selection only**.

## <a id="members"></a>Selection members

The **Members** tab displays the records in the selection. Double-click a record to open and view its details

The layout varies depending on what the selection contains. All selections except **Company/contact** have two member lists: one for selection data and another for linked companies and contacts.

> [!NOTE]
> By default, only the first 100 records are displayed. To change this, go to <i class="ph ph-user-circle" aria-hidden="true"></i> **Personal settings** > **Preferences** > **Functions** > **Archive page size**.

### <a id="filter"></a>Filtering the list of members

1. Click **Show all** in the tab footer to include all records.

1. To activate the [column filter][12], click <i class="ph ph-gear" aria-label="Gear"></i> and select **Enable filter**. The filter button (<i class="ph ph-funnel" aria-hidden="true"></i>) will appear on columns that can be filtered.

## Buttons

| Button | Name | Description |
|---|---|---|
| <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i> | Task menu | Perform various tasks for selection members, such as sending emails, mass-editing, and exporting. The available tasks depend on the record type in the **Selection of** field. |
| <i class="ph ph-arrow-clockwise" aria-hidden="true"></i> | Refresh | Updates the data in the list. |
| **Count: number** | | Displays the number of members in the active selection. |
| <i class="ph ph-download-simple" aria-hidden="true"></i> | Export | [Exports the list to a spreadsheet.][6] |

## <a id="ex"><a>Examples of how you can use selections

Selections allow you to group and filter data based on specific criteria. Below are examples of different types of selections and their potential use cases.

### Companies

You could create a dynamic selection containing all companies in the "Supplier" category located in Germany if you were planning further activities in Germany.

### Contacts

* All the contacts created the last 30 days.
* All the contacts where you have defined *Christmas card* or *Newsletter* as an interest.

### Sales

A selection of all sales you have achieved in the first quarter, or all your sales with the **Stalled** status will enable you to spot trends and assess where to direct your future sales efforts.

> [!TIP]
> [Group columns and summarize amounts][10] to spot trends and get a clear overview of your data.

![Selection of sales - grouping and sum of amount -screenshot][img3]

### Projects

* A selection of all projects of the type "Internal" that are current would allow you to assess which can be closed/completed, and which are worth still working on.

* All active projects you are participating in.

### Documents

* A selection of all documents you have created in the last month will give you an overview of what documents have been produced and call attention to any that you may have forgotten about.

* All the contracts registered in SuperOffice CRM.

### Follow-ups

* A selection of all follow-ups for a specific customer can give you an idea of the sort of relationship you have with them before a sales meeting.

* A selection of all follow-ups you have this month, to see what follow-up you have and if you should set up more.

### Products (requires a Sales Premium license)

* A list of all customers who have purchased a specific product or a specific product category.

* A selection of all products sold this year, based on sales that contain quotes and have the status Sold. The selection can be limited to specific products categories, product families, and son on based on the type of statistical output you need.

* If you are going to upgrade one of your products from, say, version 2 to version 3, you can create a selection of all customers who have purchased version 2, and use this as a basis for a campaign.

### Requests

* A list of open request with priority **High** for your department (category).

* A selection of all open request that have not been updated for over a week enables you follow up on the request handlers responsible for these requests.

### Selections

* All active selections owned by you.
* All selections with a specific category or of a specific type.

### Marketing and customer engagement

* Non-processed form submissions for your customers.
* Your chat conversations.
* Your customers' chat conversations with specific ratings.
* Mailings with a specific open-rate or click-rate.
* Mailings with high bounce rates.

## Related content

* [Add selection as a favorite][11]
* [Create selections][2]
* [Edit and delete selections][5]
* [Perform tasks using selections][1]
* [Display selections as charts][3]

<!-- Referenced links -->
[1]: howto/index.md
[3]: howto/display-as-charts.md
[6]: howto/export.md
[8]: howto/create-mailings.md
[2]: create.md
[4]: combine.md
[5]: update.md
[7]: add-remove-members-static.md
[9]: ../../learn/search-criteria.md
[11]: ../../../learn/basics/fav.md
[10]: ../../../learn/section-tabs/configure-columns.md#calculate
[12]: ../../../learn/section-tabs/filter.md
[16]: ../../../dashboard/learn/create.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/sale/selection-sales-column-calculation-grouping.png
